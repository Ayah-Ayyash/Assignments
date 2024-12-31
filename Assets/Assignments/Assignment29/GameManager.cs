using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class GameManager : MonoBehaviour
    {


        void Start()
        {
            CustomObject customObject = new CustomObject(1, "Ayah");

            print(customObject.ToString());

        }

        void Update()
        {

        }
    }
}