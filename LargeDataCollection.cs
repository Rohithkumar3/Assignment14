using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
       public class LargeDataCollection<T> : IDisposable 
       {
           private List<T> internalData;

           public LargeDataCollection(IEnumerable<T> initialData)
           {
               internalData = new List<T>(initialData);
           }

           public void AddElement(T element)
           {
               internalData.Add(element);
     Console.WriteLine($"Added element: {element}");
           }
           public void RemoveElement(T element)
           {
               internalData.Remove(element);
    Console.WriteLine($"Removed element: {element}");
           }
           public void AccessElements()
           {
               foreach (var element in internalData)
               {
                   Console.WriteLine(element);
               }
           }

           public void Dispose()
           {
               internalData = null;
               GC.SuppressFinalize(this);
           }
       } 
  
    }
    


