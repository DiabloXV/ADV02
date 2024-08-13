using System;
using System.Collections;

namespace ADV02
{
    internal class Program
    {
        public class ReverseArrayList
        {
            public static void Reverse(ArrayList list)
            {
                int start = 0;
                int end = list.Count - 1;

                while (start < end)
                {
                    // Swap elements
                    var temp = list[start];
                    list[start] = list[end];
                    list[end] = temp;

                    // Move towards the middle
                    start++;
                    end--;
                }
            }




        }

        public class EvenNumbersList
        {
            public static List<int> GetEvenNumbers(List<int> numbers)
            {
                List<int> evenNumbers = new List<int>();

                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        evenNumbers.Add(number);
                    }
                }

                return evenNumbers;
            }

            static void Main(string[] args)
            {
                #region Report
                #region ArrayList
                ///*
                //    Structure:
                //    ArrayList : is a non-generic collection that can hold items of any type. It is backed by an array and automatically resizes itself.
                //    Time Complexity:

                //    -Access: O(1) – Direct access by index.
                //    -Insert/Delete: O(n) – Requires shifting elements when items are added or removed.
                //    -Business Case:

                //    -Buisness Case : Suitable when the collection size needs to change dynamically, but the type of elements is not fixed.
                // */
                //ArrayList list = new ArrayList();
                //list.Add("Apple");
                //list.Add("Banana");
                //list.Add("Cherry");

                //Console.WriteLine("Element at index 1: " + list[1]);
                //list.Remove("Banana");
                //Console.WriteLine("List after removal:");
                //foreach (var item in list)
                //    Console.WriteLine(item);
                //#endregion

                //#region List
                ///*
                // * 
                // * 
                //-Structure:
                //List<T> is a generic collection that is backed by an array. It can store elements of a specific type and resizes automatically.

                //-Time Complexity:
                //Access: O(1) – Direct access by index.
                //Insert/Delete: O(n) – Requires shifting elements when items are added or removed.

                //-Business Case:
                //Used when you need a dynamic array that can store a specific type of elements.*/

                //List<string> list01 = new List<string>();
                //list01.Add("Apple");
                //list01.Add("Banana");
                //list01.Add("Cherry");

                //Console.WriteLine("Element at index 1: " + list01[1]);
                //list01.Remove("Banana");
                //Console.WriteLine("List after removal:");
                //foreach (var item in list01)
                //    Console.WriteLine(item);
                //#endregion

                //#region LinkedList
                ///*
                // * 
                //-Structure:
                //LinkedList<T> is a doubly linked list that allows sequential access to elements.

                //-Time Complexity:
                //Access: O(n) – Sequential access required.
                //Insert/Delete: O(1) – No shifting required, just pointer changes.

                //-Business Case:
                //Ideal for scenarios where frequent insertions and deletions at the beginning or middle of the list are required.
                // */
                //LinkedList<string> list02 = new LinkedList<string>();
                //list02.AddLast("Apple");
                //list02.AddLast("Banana");
                //list02.AddLast("Cherry");

                //Console.WriteLine("First element: " + list02.First.Value);
                //list02.Remove("Banana");
                //Console.WriteLine("List after removal:");
                //foreach (var item in list02)
                //    Console.WriteLine(item);
                //#endregion

                //#region Array
                ///*
                //Structure:
                //Fixed-size, strongly typed collection that can store elements of the same type.

                //Time Complexity:
                //Access: O(1) – Direct access by index.
                //Insert/Delete: O(n) – Requires shifting elements (if it's not the last element).

                //Business Case:
                //Used when the size of the collection is known in advance and does not change.
                // */

                //string[] array = new string[3];
                //array[0] = "Apple";
                //array[1] = "Banana";
                //array[2] = "Cherry";

                //Console.WriteLine("Element at index 1: " + array[1]);
                //#endregion

                //#region Queue
                ///*
                //Structure:
                //Queue<T> is a first-in, first-out (FIFO) collection.

                //Time Complexity:
                //Enqueue: O(1) – Adds an element to the end.
                //Dequeue: O(1) – Removes the element from the front.

                //Business Case:
                //Used in scenarios like task scheduling where you need to process elements in the order they were added.
                // */
                //Queue<string> queue = new Queue<string>();
                //queue.Enqueue("Apple");
                //queue.Enqueue("Banana");
                //queue.Enqueue("Cherry");

                //Console.WriteLine("Dequeued: " + queue.Dequeue());
                //Console.WriteLine("Queue after dequeue:");
                //foreach (var item in queue)
                //    Console.WriteLine(item);
                //#endregion

                //#region Stack
                ///*
                //Structure:
                //Stack<T> is a last-in, first-out (LIFO) collection.

                //Time Complexity:
                //Push: O(1) – Adds an element to the top.
                //Pop: O(1) – Removes the element from the top.

                //Business Case:
                //Suitable for scenarios like expression evaluation or backtracking algorithms.
                // */
                //Stack<string> stack = new Stack<string>();
                //stack.Push("Apple");
                //stack.Push("Banana");
                //stack.Push("Cherry");

                //Console.WriteLine("Popped: " + stack.Pop());
                //Console.WriteLine("Stack after pop:");
                //foreach (var item in stack)
                //    Console.WriteLine(item);
                //#endregion


                //#region HashTable 
                ///*
                //Structure:
                //Hashtable is a non-generic collection that stores key-value pairs. It uses hashing to store and retrieve values efficiently.

                //Time Complexity:
                //Insert/Access/Delete: O(1) on average, O(n) in the worst case due to collisions.

                //Business Case:
                //Useful when you need fast lookups and the type of keys and values is not fixed.

                // */
                //Hashtable table = new Hashtable();
                //table.Add("A", "Apple");
                //table.Add("B", "Banana");
                //table.Add("C", "Cherry");

                //Console.WriteLine("Value for key 'B': " + table["B"]);
                //table.Remove("B");
                //Console.WriteLine("Hashtable after removal:");
                //foreach (DictionaryEntry entry in table)
                //    Console.WriteLine(entry.Key + ": " + entry.Value);
                //#endregion

                //#region Dictionary
                ///*
                //Structure:
                //Dictionary<TKey, TValue> is a generic collection that stores key-value pairs. It is more type-safe compared to Hashtable.

                //Time Complexity:
                //Insert/Access/Delete: O(1) on average, O(n) in the worst case due to collisions.

                //Business Case:
                //Used when you need fast lookups with a specific type for keys and values.
                // */
                //Dictionary<string, string> dictionary = new Dictionary<string, string>();
                //dictionary.Add("A", "Apple");
                //dictionary.Add("B", "Banana");
                //dictionary.Add("C", "Cherry");

                //Console.WriteLine("Value for key 'B': " + dictionary["B"]);
                //dictionary.Remove("B");
                //Console.WriteLine("Dictionary after removal:");
                //foreach (var entry in dictionary)
                //    Console.WriteLine(entry.Key + ": " + entry.Value);
                //#endregion

                //#region HashSet
                ///*
                //Structure:
                //HashSet<T> is a collection that contains no duplicate elements and is backed by a hash table.

                //Time Complexity:
                //Insert/Contains/Delete: O(1) on average, O(n) in the worst case due to collisions.

                //Business Case:
                //Used when you need to maintain a collection of unique elements and perform fast operations like add, remove, and search.
                // */
                //HashSet<string> set = new HashSet<string>();
                //set.Add("Apple");
                //set.Add("Banana");
                //set.Add("Cherry");

                //Console.WriteLine("Contains 'Banana': " + set.Contains("Banana"));
                //set.Remove("Banana");
                //Console.WriteLine("HashSet after removal:");
                //foreach (var item in set)
                //    Console.WriteLine(item);
                #endregion
                #endregion

                
                #region Q1
                ArrayList list03 = new ArrayList() { 1, 2, 3, 4, 5 };
                Console.WriteLine("Original ArrayList:");
                foreach (var item in list03)
                {
                    Console.Write(item + " ");
                }

                ReverseArrayList.Reverse(list03);

                Console.WriteLine("\nReversed ArrayList:");
                foreach (var item in list03)
                {
                    Console.Write(item + " ");


                }
                #endregion

                #region Q2
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                List<int> evenNumbers = GetEvenNumbers(numbers);

                Console.WriteLine("Even numbers:");
                foreach (int number in evenNumbers)
                {
                    Console.Write(number + " ");

                }
                #endregion

                #region Q3
                try
                {
                    FixedSizeList<int> list = new FixedSizeList<int>(3);
                    list.Add(10);
                    list.Add(20);
                    list.Add(30);

                    // Uncommenting the following line will throw an exception
                    // list.Add(40); // Exception: List is full. Cannot add more elements.

                    Console.WriteLine("Element at index 1: " + list.Get(1)); // Outputs: 20

                    // Uncommenting the following line will throw an exception
                    // Console.WriteLine(list.Get(3)); // Exception: Invalid index. Index is out of bounds.

                    Console.WriteLine("Current count: " + list.Count); // Outputs: 3
                    Console.WriteLine("Capacity: " + list.Capacity);   // Outputs: 3
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                #endregion

                #region Q4
                string input = "swiss";
                int index = FirstNonRepeatedCharacter.FindFirstNonRepeatedCharacter(input);

                if (index != -1)
                {
                    Console.WriteLine($"The first non-repeated character is '{input[index]}' at index {index}.");
                }
                else
                {
                    Console.WriteLine("There is no non-repeated character in the string.");
                }

                #endregion


            }
        }
    }
}