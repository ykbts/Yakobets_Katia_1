using System;
using System.IO;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        { 
            List<int> list = new List<int>() { -5, 3,-7,2,9,-4};
            var dodatni = list.Count(i => i > 0);
            Console.WriteLine("Кількість додатніх елементів: "+dodatni);
            var sum = list.Where(i=> i % 2 != 0).Sum(i => i);
            Console.WriteLine("Сума непарних елементів: " + sum);
        }
    }
}
