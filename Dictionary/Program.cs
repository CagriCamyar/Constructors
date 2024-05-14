using System;
using System.Collections.Generic;

namespace Dictionary
{

        class Program
        {
            static void Main(string[] args)
            {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Çağrı");
            myDictionary.Add(2, "Emre");
            Console.WriteLine(myDictionary.Count);

            }
        }

        class MyDictionary <Key, Value>
        {
            Key[] keyArray;
            Value[] valueArray;

            Key[] tempKeyArray;
            Value[] tempValueArray;

            public MyDictionary()
            {
            keyArray = new Key[0];
            valueArray = new Value[0];
            }

            public void Add (Key key, Value value)
            {
            tempKeyArray = keyArray;
            tempValueArray = valueArray;
            keyArray = new Key[keyArray.Length + 1];
            valueArray = new Value[valueArray.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++) 
            {
                tempKeyArray[i] = keyArray[i];
                tempValueArray[i] = valueArray[i];
            }

            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] =value;
        
            }

        private int _count;

        public int Count
        {
            get { return keyArray.Length; } 
        }

        }


}