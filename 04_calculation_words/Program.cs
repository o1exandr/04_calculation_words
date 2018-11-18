/*
 4.  Дано текстовий файл з cs - програмою. Знайти службові слова С#, які зустрілися у файлі та їх кількість.
Для підрахунку кількості службових слів використайте колекцію типу словник(Dictionary<>, SordetDictionary<> або SortedList)
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace _04_calculation_words
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objReader = new StreamReader("01_dictionary.cs");
            string str = "";
            string[] words;

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            SortedDictionary<string, int> WordsCS = new SortedDictionary<string, int>();
            WordsCS.Add("bool", 1);
            WordsCS.Add("case", 1);
            WordsCS.Add("class", 1);
            WordsCS.Add("const", 1);
            WordsCS.Add("do", 1);
            WordsCS.Add("double", 1);
            WordsCS.Add("else", 1);
            WordsCS.Add("enum", 1);
            WordsCS.Add("false", 1);
            WordsCS.Add("float", 1);
            WordsCS.Add("for", 1);
            WordsCS.Add("foreach", 1);
            WordsCS.Add("if", 1);
            WordsCS.Add("int", 1);
            WordsCS.Add("interface", 1);
            WordsCS.Add("internal", 1);
            WordsCS.Add("namespace", 1);
            WordsCS.Add("new", 1);
            WordsCS.Add("null", 1);
            WordsCS.Add("object", 1);
            WordsCS.Add("override", 1);
            WordsCS.Add("private", 1);
            WordsCS.Add("protected", 1);
            WordsCS.Add("public", 1);
            WordsCS.Add("return", 1);
            WordsCS.Add("string", 1);
            WordsCS.Add("struct", 1);
            WordsCS.Add("switch", 1);
            WordsCS.Add("this", 1);
            WordsCS.Add("true", 1);
            WordsCS.Add("try", 1);
            WordsCS.Add("void", 1);
            WordsCS.Add("while", 1);

            ArrayList arrText = new ArrayList();
            while (str != null)
            {
                str = objReader.ReadLine();
                try
                {
                    string[] separators = { ",", ".", "!", "?", ";", ":", " ", "(", ")", "{", "}", "\"", "\\", "'", "$", "<", ">", "-", "=", "+", "*", "/", "[", "]", "\t" };
                    words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        
                        if (dictionary.TryGetValue(word, out int result))
                            dictionary[word] = ++result;
                        else
                            dictionary.Add(word, 1);
                            
                        //Console.WriteLine(word);
                    }
                }
                catch
                { }

            }
            objReader.Close();

            
            foreach (var el in dictionary)
            {
                if (WordsCS.ContainsKey(el.Key))
                    Console.WriteLine($"{el.Key, 10} - {el.Value}");
            }

            Console.ReadKey();
        }
    }
}
