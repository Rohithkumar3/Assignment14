using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
               using (var intCollection = new LargeDataCollection<int>(new[] { 1, 2, 3, 4 }))
               {
                   Console.WriteLine("Integer Collection:");
                   intCollection.AccessElements();

                   intCollection.AddElement(5);
                   intCollection.RemoveElement(2);
                   Console.WriteLine("\nCollection after adding One and removing One integer:");
                   intCollection.AccessElements();
               } 

               using (var stringCollection = new LargeDataCollection<string>(new[] { "Raj", "Shyam", "Ramu" }))
               {
                   Console.WriteLine("\nString Collection:");
                   stringCollection.AccessElements();

                   stringCollection.AddElement("Kiran");
                   stringCollection.RemoveElement("Raj");
                   Console.WriteLine("\nCollection after adding One and removing One string:");
                   stringCollection.AccessElements();
               } 
       Console.ReadKey();           
        }
        }

    }
