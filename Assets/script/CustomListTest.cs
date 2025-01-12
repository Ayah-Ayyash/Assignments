using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CustomListTest : MonoBehaviour
{

    List<int> ints = new List<int>() { 1, 2, 3, 4 };
    ayahList<int> ayah = new ayahList<int>() { 1, 2, 3, 4, 5 ,6,7,8,9,10,11,12,13};
    void Start()
    {
        ints.Add(5);
      
        foreach (int num in ints)
        {
            print(num);
        }
    }

    public class ayahList<T> : IEnumerable<T>
    {
        T[] _value = new T[10];
        int _count = 0;
        public int Count
        {
            get=> _count;
            private set => _count = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        public void Add(T v)
        {
            // T[] tempArr = T[]
            // _value[Count++] = v;
        }
     }
    void Update()
    {

    }
}
