using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class CatManagement : IAction<Cat>
    {
        private List<Cat> catList = new List<Cat>();

        public void AddToList(Cat item)
        {
            catList.Add(item);
        }

        public void Display()
        {
            if (catList.Count == 0)
            {
                Console.WriteLine("No cats in the list.");
                return;
            }

            Console.WriteLine("\nList of Cats:");
            foreach (var cat in catList)
            {
                cat.DisplayData();
            }
        }

        public Cat this[int index]
        {
            get
            {
                try
                {
                    return catList[index];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Error: Index out of range.");
                    return null;
                }
            }
        }
    }
}
