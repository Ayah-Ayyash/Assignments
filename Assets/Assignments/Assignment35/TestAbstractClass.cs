using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        private DerivedClassExample derivedClassExample;

        void Start()
        {

            derivedClassExample = gameObject.AddComponent<DerivedClassExample>();


            derivedClassExample.PerformAction();


            derivedClassExample.PrintInfo();
        }

        void Update()
        {
        }
    }
}
