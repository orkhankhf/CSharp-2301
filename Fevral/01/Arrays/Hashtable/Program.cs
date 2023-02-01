using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            #region Adding values to ArrayList
            string[] arr = new string[2];

            string[] arr2 = new string[]
            {
                "One",
                "Two"
            };

            ArrayList arrayList = new ArrayList();

            int capacity = 0;
            int count = 0;

            ArrayList students = new ArrayList();
            students.Add("Samir");
            students.Add("Javid");
            students.Add("Teymur");
            students.Add("Gunay");
            students.Add("Aynur");
            students.Add("Zaur");

            capacity = students.Capacity;
            count = students.Count;

            students.Add(5);
            students.Add(true);
            #endregion



            #region Adding Collection to ArrayList
            //A1 sinifi
            ArrayList A1 = new ArrayList();
            A1.Add("Samir");
            A1.Add("Javid");
            A1.Add("Teymur");

            //A2 sinifi
            ArrayList A2 = new ArrayList();
            A2.Add("Gunay");
            A2.Add("Aynur");
            A2.Add("Zaur");
            A1.AddRange(A2); //A2 sinifini A1 sinifine elave edir
            #endregion



            #region Getting values from ArrayList
            var samir = A1[0]; //object tipinde data qaytarir
            object objGunay = A1[3];
            string strGunay = A1[3].ToString();

            ArrayList mixArray = new ArrayList();
            mixArray.Add("string value");
            mixArray.Add(1);
            mixArray.Add(5.5F);
            mixArray.Add('C');
            mixArray.Add(1.2D);
            mixArray.Add(true);

            var strVal = mixArray[0].ToString();
            var numVal = (int)mixArray[1];
            var floatVal = (float)mixArray[2];
            var charVal = (char)mixArray[3];
            var doubleVal = (double)mixArray[4];
            var boolVal = (bool)mixArray[5];
            #endregion



            #region Sorting values in ArrayList
            A1.Reverse();

            A1.Sort();
            #endregion



            #region Removing values
            A1.RemoveAt(3);
            A1.RemoveRange(2, 2);
            A1.Remove("Zaur");
            #endregion


            #region Checking if value exists
            A1.Add("Malik");

            bool ct = A1.Contains("Malik");

            if (A1.Contains("Malik"))
            {
                int indexOfName = A1.IndexOf("Malik");
                A1.RemoveAt(indexOfName);
            }
            #endregion


            #region Clearing (TrimToSize) Array
            var capacityOfA1 = A1.Capacity;
            var countOfA1 = A1.Count;
            A1.Clear();
            A1.TrimToSize();
            #endregion
            #endregion

            #region HashTable
            #region What is HashTable and how to use it?
            Hashtable ht = new Hashtable();
            ht.Add("Human", "Insan");
            ht.Add("House", "Ev");
            ht.Add("You", "Sen");

            //Key'e gore deyer axtarmaq
            bool ct1 = ht.Contains("House");
            bool ct2 = ht.Contains("You");

            //Key ve Value'e gore axtarmaq
            bool ctKey = ht.ContainsKey("House");
            bool ctValue = ht.ContainsValue("Ev");

            ht["House"] = "Villa";

            ht.Remove("House");

            int countOfht = ht.Count;
            ht.Clear();
            #endregion
            #endregion



            #region SortedList
            SortedList sortedListEngAz = new SortedList();

            sortedListEngAz.Add("Hello", "Salam");
            sortedListEngAz.Add("Car", "Avtomobil");
            sortedListEngAz.Add("Home", "Ev");
            sortedListEngAz.Add("One", "Bir");
            //sortedListEngAz.Add(100, "Bir"); //Xeta cixacaq
            #endregion

            #region Stack
            Stack stack = new Stack();

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");

            object O1 = stack.Pop();

            object O2 = stack.Peek();
            #endregion

            #region Queue
            Queue queue = new Queue();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");

            object obj = queue.Peek();

            object obj1 = queue.Dequeue();
            #endregion
        }
    }
}
