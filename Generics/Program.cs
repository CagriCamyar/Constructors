using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            Console.WriteLine(list.Count);

            MyList<string> myList = new MyList<string>();
            myList.Add("a");
            myList.Add("b");
            myList.Add("c");
            myList.Add("d");
            Console.WriteLine(myList.Count);
        }
    }
        class MyList<T>
        {
            T[] array;
            T[] temparray;

            public MyList()
            {
                array = new T[0];
            }

            public void Add(T item)
            {
                temparray = array;
                array = new T[array.Length + 1];
                for (int i = 0; i < temparray.Length; i++)
                {
                array[i] = temparray[i];
                }                                
                array[array.Length - 1] = item;
            }
            
            private int _count;

            public int Count
            {
                get { return array.Length; }
            }

        }
}