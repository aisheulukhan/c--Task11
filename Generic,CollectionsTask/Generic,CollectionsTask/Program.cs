using System;
using System.Collections.Generic;

namespace Generic_CollectionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> heyvanlar = new CustomList<string>();
            Console.WriteLine("-----Add-----");
            heyvanlar.Add("it");
            heyvanlar.Add("pisik");
            heyvanlar.Add("ayi");
            heyvanlar.Add("qartal");
            heyvanlar.ShowInfo();
            Console.WriteLine("-----Count-----");
            Console.WriteLine(heyvanlar.Count);
            Console.WriteLine("-----Exist-----");
            Console.WriteLine(heyvanlar.Exist("it"));
            Console.WriteLine("-----IndexOf-----");
            Console.WriteLine(heyvanlar.IndexOf("ayi"));
            Console.WriteLine("--------------------------------");
            CustomList<int> reqem = new CustomList<int>();
            Console.WriteLine("-----Add-----");
            reqem.Add(45);
            reqem.Add(10);
            reqem.Add(1);
            reqem.Add(200);
            reqem.ShowInfo();

        }
    }
    class CustomList<T>
    {
        private T[] _array;
        private T[] _tarray;
        public int Count {
            get
            {
                return _array.Length;
            }
        }
        public int Capacity { get; set; }
        public CustomList()
        {
            _array = new T[0];
        }
        public void Add (T item)
        {
            _tarray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tarray.Length; i++)
            {
                _array[i] = _tarray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public void Clear()
        {
            Array.Resize(ref _array, 0);
        }
        public bool Exist(T item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array.Equals(item))
                {
                    return true;
                }
                    
            }
            return false;
        }
        public void Reverse()
        {
            T item;
            for (int i = 0; i < _array.Length / 2; i++)
            {
                item = _array[i];
                _array[i] = _array[_array.Length - i - 1];
                _array[_array.Length - i - 1] = item;
            }
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (_array[i].Equals(item))
                {
                    return i;
                }
                
                    
            }
            return -1;

        }
        

        public void ShowInfo()
        {
            foreach (T item in _array)
            {
                Console.WriteLine(item);
            }
        }
        
    }
    
}
