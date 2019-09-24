
//Add more comments. describe every code through comments.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_HashTable_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hashtable ht = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", "Five" },
                    { 8.5F, 8.5 }
                };


            //for itirating the full list and dispaying all key and value.
            //method 1
             foreach (DictionaryEntry item in ht)
                 Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
             Console.ReadLine();


            //method 2
            /*  foreach (var key in ht.Keys)
                  Console.WriteLine("Key:{0}, Value:{1}", key, ht[key]);
              Console.ReadLine(); */


            //method 3(for displaying only the values)
            /* foreach (var value in ht.Values)
                 Console.WriteLine("Value:{0}", value);
             Console.ReadLine();  */


            //Remove the particular element.
            ht.Remove("Fv");
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
            Console.ReadLine();


            //Check if HashTable contains that particular Element.
            ht.Contains(2);
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
            Console.ReadLine();

            
            
            // removes all elements
            ht.Clear(); 
            Console.WriteLine("Total Elements: {0}", ht.Count);
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
            Console.ReadLine();
        }
    }
}
