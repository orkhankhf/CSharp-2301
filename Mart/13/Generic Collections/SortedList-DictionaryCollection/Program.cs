using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary Generic Collection
            //Generic collection deyil
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "salam");
            hashtable.Add(2, "sagol");
            //hashtable.Add(2, "necesen");

            //Dictionary<TKey, TValue> T tipinde Key ve Value
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(1, "salam");
            dictionary1.Add(2, "sagol");
            dictionary1.Add(3, "necesen");
            //dictionary1.Add(1, "yaxsiyam");

            Dictionary<bool, char> dictionary2 = new Dictionary<bool, char>();
            dictionary2.Add(true, 'A');
            
            Dictionary<decimal, long> dictionary3 = new Dictionary<decimal, long>();
            dictionary3.Add(20.2m, 51561561561565651);


            bool delResult = dictionary1.Remove(2);
            if(delResult)
                Console.WriteLine("Deyer silindi!");
            else
                Console.WriteLine("Deyer tapilmadi!");

            hashtable[0] = 100;
            dictionary1[0] = "changed value";

            bool key100 = dictionary1.ContainsKey(100);
            if (key100)
            {
                var test = dictionary1[100];
            }
            else{
                Console.WriteLine("100-cu key movcud deyil!");
            }

            bool valHello = dictionary1.ContainsValue("salam");
            if (valHello)
            {
                Console.WriteLine("Salam deyeri tapildi!");
            }
            else
            {
                Console.WriteLine("Salam deyeri tapilmadi!");
            }

            foreach (KeyValuePair<int, string> item in dictionary1)
            {
                Console.WriteLine("Acar: {0} || Deyer: {1}", item.Key, item.Value);
            }
            #endregion

            #region SortedList & SortedDictionary Generic Collection
            SortedList<int, string> sortedListCollection = new SortedList<int, string>();
            sortedListCollection.Add(10, "salam");
            sortedListCollection.Add(5, "sagol");
            sortedListCollection.Add(3, "necesen");
            sortedListCollection.Add(18, "yaxsiyam");

            SortedDictionary<int, string> sortedDictionaryCollection = new SortedDictionary<int, string>();
            sortedDictionaryCollection.Add(30, "salam");
            sortedDictionaryCollection.Add(53, "sagol");
            sortedDictionaryCollection.Add(42, "necesen");
            sortedDictionaryCollection.Add(79, "yaxsiyam");
            #endregion

        }
    }
}
