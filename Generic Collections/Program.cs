using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            Console.Write("List: ");
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            #endregion
            #region Linked List
            Console.Write("\n\nLinked List: ");
            LinkedList<int> numbers = new LinkedList<int>();
            foreach (int number in new int[] { 10, 8, 6, 4, 2 })
            {
                numbers.AddFirst(number);
            }
            for (LinkedListNode<int> node = numbers.First; node != null; node = node.Next)
            {
                int number = node.Value;
                Console.Write(number + " ");
            }
            #endregion
            #region Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1 in queue");
            queue.Enqueue("2 in queue");
            queue.Enqueue("3 in queue");
            queue.Enqueue("4 in queue");
            queue.Enqueue("5 in queue");
            Console.Write("\n\nQueue:\n");
            foreach (var i in queue)
            {
                Console.Write($"{i}\n");
            }
            #endregion
            #region Stack
            Console.WriteLine("\nStack:");
            Stack<int> dish = new Stack<int>();
            Console.WriteLine("\nPushing items onto the stack:");
            foreach (int number in new int[5] { 9, 3, 7, 2, 10 })
            {
                dish.Push(number);
                Console.WriteLine($"{number} has been pushed to the stack");
            }
            Console.Write("\n\nPopping items from the stack:\n");
            while (dish.Count > 0)
            {
                int number = dish.Pop();
                Console.WriteLine($"{number} has been popped off the stack");
            }
            #endregion
            #region Dictionary
            Console.WriteLine("\n\nDictionary:\n");
            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages.Add("Dog", 10);
            ages.Add("Cat", 5);
            ages.Add("Bird", 7);
            ages.Add("Fish", 15);
            ages.Add("Monkey", 2);

            foreach (KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int num = element.Value;
                Console.WriteLine($"Name: {name}, Age: {num}");
            }
            #endregion
            #region SortedList
            Console.WriteLine("\n\nSortedList:\n");
            SortedList<string, int> age = new SortedList<string, int>();

            ages["Dog"] = 10;
            ages["Cat"] = 5;
            ages["Bird"]= 7;
            ages["Fish"]= 15;
            ages["Monkey"] = 2;

            foreach (KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int value = element.Value;
                Console.WriteLine($"Name: {name}, Age: {value}");
            }
            #endregion
            #region Hashset
            Console.WriteLine("\nHashSet:\n");
            HashSet<string> employees = new HashSet<string>(new string[] { "Zach", "Jeff", "Harry", "Marc", "Chris" });
            HashSet<string> customers = new HashSet<string>(new string[] { "Marc", "Woody", "Harry", "Bo Peep", "Elliot" });
            employees.Add("James");
            customers.Add("Francesca");
            Console.WriteLine("Employees:");
            foreach (string name in employees)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nCustomers:");
            foreach (string name in customers)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nCustomers who are also employees:");
            customers.IntersectWith(employees);
            foreach (string name in customers)
            {
                Console.WriteLine(name);
            }
            #endregion

        }
    }
}
