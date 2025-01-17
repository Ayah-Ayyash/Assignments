using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;

            object objBox = health; // Boxing
            int objUnbox = (int)objBox; // Unboxing
            Debug.Log($"Original value: {health}");
            Debug.Log($"Boxed value as object: {objBox}");
            Debug.Log($"Unboxed and modified value: {objUnbox}");
        }



        // int myInt = (int)myObject; //unboxing



        void Update()
        {

        }
    }
}