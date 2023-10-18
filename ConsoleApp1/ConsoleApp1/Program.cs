using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAY
            //Initialize
            int[] array = new int[3];

            //Add elements
            array[0] = 5;
            array[1] = 0;
            array[2] = 40;

            //Loop
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //Remove

            int[] indicesToRemove = {1,2};
            int[] newArray = array
            .Where((element, index) => !indicesToRemove.Contains(index))
            .ToArray();

            //Check exsistence
            PrintArray( array );
            PrintArray( newArray );


            //LIST
            //Initialize
            List<int> list = new List<int>();

            //Add elements
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            list.Add(4);    
            list.Add(5);

            //Loop
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //Remove
            list.RemoveAt(2); //remove the element given the index
            list.Remove(2);  //remove the element

            //Check exsistence
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            //DICTIONARY
            //Initialize
            Dictionary<string, int> dict = new Dictionary<string, int>();

            //Add elements
            dict["Height"] = 177;
            dict["Weight"] = 70;
            dict["Age"] = 24;

            //Loop
            foreach (var key in dict)
            {
                Console.WriteLine($"Key: {key.Key}, Value: {key.Value}");
            }

            //Remove
            dict.Remove("Age");

            //Check exsistence
            Console.WriteLine(dict.ContainsKey("Age"));
            Console.WriteLine(dict.ContainsValue(70));

            //SORTEDLIST
            //Initialize
            List<int> list2 = new List<int>();
            list2.Sort();

            //Add elements
            list2.Add(50);
            list2.Add(10);
            list2.Add(110);

            //Loop
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }

            //Remove the same as the lists

            //Check exsistence the same as the lists

            //HASHSET
            //Initialize
            HashSet<string> hashSetNames = new HashSet<string>();

            //Add elements
            hashSetNames.Add("Alice");
            hashSetNames.Add("Bob");
            hashSetNames.Add("John");

            //Loop
            foreach (var name in hashSetNames)
            {
                Console.WriteLine(name);
            }

            //Remove and Check exsistence
            string nameToRemove = "Bob"; //Since Bob is in the hashset he will be removed if try with Mario it will print not found
            bool removed = hashSetNames.Remove(nameToRemove);

            if (removed)
            {
                Console.WriteLine($"\n'{nameToRemove}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"\n'{nameToRemove}' not found in the HashSet.");
            }

            //SORTEDSET
            //Initialize
            SortedSet<int> sortedSet = new SortedSet<int>();

            //Add elements
            sortedSet.Add(50);
            sortedSet.Add(10);
            sortedSet.Add(15);

            //Loop
            foreach (var number in sortedSet)
            {
                Console.Write(number + " ");
            }

            //Remove
            sortedSet.Remove(10);

            //Check exsistence
            Console.WriteLine(sortedSet.Contains(10));

            //QUEUE
            //Initialize
            Queue<string> queue = new Queue<string>();

            //Add elements
            queue.Enqueue("10");
            queue.Enqueue("Weight");

            //Loop
            foreach (var element in queue)
            {
                Console.Write(element + " ");
            }

            //Remove
            queue.Dequeue();

            //Check exsistence
            queue.Contains("10");
            queue.Contains("Weight");

            //STACK
            //Initialize
            Stack<int> stack = new Stack<int>();

            //Add elements
            stack.Push(5);
            stack.Push(3);
            stack.Push(8);
            stack.Push(1);
            stack.Push(2);

            //Loop
            foreach (var number in stack)
            {
                Console.Write(number + " ");
            }

            //Remove
            stack.Pop();
            stack.Pop();

            //Check exsistence
            Console.WriteLine(stack.Contains(5));


            //LINKEDLIST
            //Initialize
            LinkedList<int> linkedList = new LinkedList<int>();

            //Add elements
            linkedList.AddLast(24);
            linkedList.AddFirst(25);

            //Loop
            foreach (var number in linkedList)
            {
                Console.Write(number + " ");
            }

            //Remove
            LinkedListNode<int> nodeToRemove = linkedList.Find(25);
            if (nodeToRemove != null)
            {
                linkedList.Remove(nodeToRemove);
            }

            //Check exsistence
            Console.WriteLine(linkedList.Contains(25));
        }
        static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
