using System;
using System.Collections.Generic;

namespace GenericsMyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        protected Dictionary<Tkey, Tvalue> myDictionary = new Dictionary<Tkey, Tvalue>();

        public void Add(Tkey tkey, Tvalue tvalue)
        {
            myDictionary.Add(tkey, tvalue);
        }

        public Tvalue Indexer(Tkey tkey)
        {
            if(!myDictionary.ContainsKey(tkey))
            {
                throw new Exception("The value with key doesn't exist!");
            }

            return myDictionary[tkey];
        }

        public int Count
        {
            get { return myDictionary.Count; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var example = new MyDictionary<int, string>();

            example.Add(0, "Hello world!");
            example.Add(3, "Hi people!");
            example.Add(5, "I am from Canada!");

            Console.WriteLine(example.Indexer(3));
            Console.WriteLine(example.Indexer(5));

            Console.WriteLine();

            Console.WriteLine(example.Count);
        }
    }
}
