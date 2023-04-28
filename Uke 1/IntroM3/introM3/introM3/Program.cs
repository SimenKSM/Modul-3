using System;
using System.Xml.Schema;

namespace introM3
{
    class Program
    {
        static void Main(string[] args)
         {
            string[] letterArray = {"a","b","c","d","e","f"};
            int counter = 0;
            
            for (int i = 0; i < letterArray.Length; i++)
            {
                if (letterArray[i] == args[i])
                {
                    counter++;
                }
            }
            Console.WriteLine("Hallo Antall Parametre: " + args.Length + counter);
            
            
        }
        
    }
}