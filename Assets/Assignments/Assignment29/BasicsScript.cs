
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using System.DateTime;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var number = 40;
            // var txt = "Hi";
            // var isActive = false;

            var result = number % 2 == 0 ? "Even" : "Odd";
            Debug.Log($"Number: {number} is {result}");

           // Debug.Log("Time and date :");
            DateTime now = new DateTime(2024, 12, 27, 13, 25, 0);
            Debug.Log("Time and date :"+ now);

            Debug.Log($" Today is: {DateTime.Now.DayOfWeek}");


        }

        void Update()
        {

        }

    }
}

