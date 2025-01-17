using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{

    public class ListMethodsExample : MonoBehaviour
    {




        void Start()
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };

            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log("Sorted List (Descending): " + string.Join(" , ", numbers));

            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };

            List<int> filteredNumbers = numbers2.FindAll(x => x % 2 == 0);
            Debug.Log("Even Numbers: " + string.Join(", ", filteredNumbers));
        }




        void Update()
        {

        }
    }
}