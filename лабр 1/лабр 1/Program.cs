using System;
using System.IO;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> poem = new List<string>();
            StreamReader sr = new StreamReader("C:\\poem.txt");
            string line = sr.ReadLine();
            string w = string.Empty;
            while (line != null)
            {
                poem.Add(line);
                line = sr.ReadLine();
                if (line != null)
                {
                    string[] words = line.Split(' ', ',', '.', ';', ':', '!', '?', '-');

                    for (int i = 0; i < words.Length; i++)
                    {

                        if (words[i].Length > w.Length)
                        {
                            w = words[i];

                        }

                    }
                }

               }
                Console.WriteLine(w);

                List<string> poemSort = poem.OrderBy(x => x.Length).ToList();
                foreach (var i in poemSort)
                {

                    Console.WriteLine(i);


                }
                sr.Close();
            }
        }
    }

