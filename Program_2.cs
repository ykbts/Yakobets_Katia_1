using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;


namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            string k = @"{ 'Mather':81, 'Physics':83, 'Chemistry':87}";
            Dictionary<string, int> d = JsonConvert.DeserializeObject<Dictionary<string,int>>( k);
      
            Dictionary<string, int> dSort = d.OrderBy(x => x.Value).ToDictionary(pair => pair.Key,
                                                      pair => pair.Value);
          dSort= dSort.Reverse().ToDictionary(pair => pair.Key,
                                                      pair => pair.Value);
          
            
            string file = "File.json";
            string j = JsonConvert.SerializeObject(dSort);
            File.WriteAllText(file, j);
            Console.WriteLine(File.ReadAllText(file));
        }
       
    }
}