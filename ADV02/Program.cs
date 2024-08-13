using System;
using System.Collections;

namespace ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            /*
                Structure:
                ArrayList : is a non-generic collection that can hold items of any type. It is backed by an array and automatically resizes itself.
                Time Complexity:

                -Access: O(1) – Direct access by index.
                -Insert/Delete: O(n) – Requires shifting elements when items are added or removed.
                -Business Case:

                -Buisness Case : Suitable when the collection size needs to change dynamically, but the type of elements is not fixed.
             */
            ArrayList list = new ArrayList();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");

            Console.WriteLine("Element at index 1: " + list[1]);
            list.Remove("Banana");
            Console.WriteLine("List after removal:");
            foreach (var item in list)
                Console.WriteLine(item);
            #endregion


        }
    }
}
