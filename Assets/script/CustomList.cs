using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
namespace L_15
{
    public class CustomList : MonoBehaviour
    {

        void callbyRef(ref int num)
        {
            num *=2;
        }


        void callbyout(int a, int b, out int sum , out int product)
        {
            sum=a+b;
            product=a*b;
        }


        //    public void printValue(in int number)
        //     {
        //         Debug.Log(number);
        //     }
        void callbyvalue(int number)
        {
            number=10;
        }

        
        void Start()
        {
            int a = 3;
            int b = 4;
            
            callbyvalue(3);
            Debug.Log(a);




            // int sum , product;
            // calculater(5,9, out sum , out product);
            // Debug.Log($"Sum ={sum} +Product ={product}");



            int value =5;
            callbyRef(ref value);
            Debug.Log(value);
            //5*2=10


            // int value = 9;
            // printValue =value;  //لا يسمح بالتعديل على القيمة الاصلية

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}