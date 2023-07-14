using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an ArrayList with values
            ArrayList fruits = new ArrayList { "apple" ,"banana","cherry","date","elderberry"};

            //printing all items inside ArrayList fruits
            Console.WriteLine("Initial Array List: ");
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }

            //Searching element present in fruits list
            Console.WriteLine("\n****************************************");
            Console.WriteLine("enter element to search in list: ");
            string item = Console.ReadLine();
            int search = fruits.IndexOf(item);
            if(search == -1)
            {
                Console.WriteLine($" Element {item} not found");
            }
            Console.WriteLine($"Element {item} found at position: "+search);

            //
            Console.WriteLine("\n****************************************");
            Console.WriteLine("enter element to insert in list: ");
            string item1 = Console.ReadLine();
            Console.WriteLine("Enter position to insert: ");
            int position = int.Parse(Console.ReadLine());
            fruits.Insert(position,item1);
            Console.WriteLine($"List after inserting {item1} at position {position} ");
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n****************************************");
            Console.WriteLine("enter element to remove from list:");
            string item2 = Console.ReadLine();
            fruits.Remove(item2);
            Console.WriteLine($"List after removing {item1} ");
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n****************************************");
            Console.WriteLine("All fruits: ");
            foreach(string i in fruits) {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
