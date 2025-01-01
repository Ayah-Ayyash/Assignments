using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TestGameManager : MonoBehaviour
    {

        CustomObject co = new CustomObject(1, "Ayah");
        

        void Start()
        {
            //3
            print(co.ToString());
            Debug.Log("ayah".RepeatString(3));

        }
        //Done

        void Update()
        {

        }
    }
}