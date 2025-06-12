using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    internal class Dictionary : IDictionary
    {

        private List<Word> words;

        public Dictionary()
        {
            words = new List<Word>();
        }


        public void AddWord(string text, string meaning)
        {
            if (words.Any(w => w.Text.Equals(text, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("The word already exists in the dictionary.");
            }
            else
            {
                words.Add(new Word(text, meaning));
                Console.WriteLine("Word added successfully.");
            }
        }

        public void EditWord(string text, string newMeaning)
        {
            Word word = words.FirstOrDefault(w => w.Text.Equals(text, StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                word.Meaning = newMeaning;
                Console.WriteLine("Word updated successfully.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }

        public void RemoveWord(string text)
        {
            Word word = words.FirstOrDefault(w => w.Text.Equals(text, StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                words.Remove(word);
                Console.WriteLine("Word removed successfully.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }

        public void ListWords()
        {
            if (words.Count == 0)
            {
                Console.WriteLine("The dictionary is empty.");
                return;
            }

            foreach (Word word in words)
            {
                word.Display();
            }
        }

        public void SearchWord(string text)
        {
            Word word = words.FirstOrDefault(w => w.Text.Equals(text, StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                word.Display();
            }
            else
            {
                Console.WriteLine("The word is not found.");
            }
        }

        bool IDictionary.Remove(string word)
        {
            throw new NotImplementedException();
        }

        void IDictionary.List()
        {
            throw new NotImplementedException();
        }

        void IDictionary.Search(string word)
        {
            throw new NotImplementedException();
        }
    }
}
