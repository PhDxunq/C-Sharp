using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lesson10
{
    internal class Word : IWord
    {
        public string Text { get; set; }
        public string Meaning { get; set }

        public Word (string text, string meaning)
        {
            Text = text;
            Meaning = meaning;
        }

        public void Display()
        {
            Console.WriteLine($"Word: {Text} - Meaning: {Meaning}");
        }
    }
}
