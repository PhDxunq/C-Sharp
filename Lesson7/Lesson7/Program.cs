using System;
using System.Diagnostics;
using System.Threading;

class PrimeCounter
{
    public int CountPrimesInRange(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                count++;
        }
        return count;
    }

    private bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        int sqrt = (int)Math.Sqrt(n);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}

class Program
{
    static int totalCount = 0;
    static PrimeCounter counter = new PrimeCounter();

    static void CountPrimesThread(object obj)
    {
        (int start, int end) = ((int, int))obj;
        int localCount = counter.CountPrimesInRange(start, end);
        Interlocked.Add(ref totalCount, localCount);
    }

    static void Main()
    {
        int rangeStart = 1;
        int rangeEnd = 1_000_000;
        int segmentSize = (rangeEnd - rangeStart + 1) / 4;

        Thread[] threads = new Thread[4];
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < 4; i++)
        {
            int start = rangeStart + i * segmentSize;
            int end = (i == 3) ? rangeEnd : start + segmentSize - 1;
            threads[i] = new Thread(CountPrimesThread);
            threads[i].Start((start, end));
        }

        foreach (var t in threads)
            t.Join();

        sw.Stop();
        Console.WriteLine($"Tổng số nguyên tố từ 1 đến 1.000.000: {totalCount}");
        Console.WriteLine($"Thời gian thực thi: {sw.Elapsed.TotalSeconds:F2} giây");
    }
}
