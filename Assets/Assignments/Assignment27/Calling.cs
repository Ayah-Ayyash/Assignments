using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class Calling : MonoBehaviour
    {
        // Start is called before the first frame update

        //1
        public void Num(int number)
        {
            number = 15;
            Debug.Log("Inside number =" + number);
        }


        //2
        void Ref(ref int number)
        {
            number *= 2;
        }


        //3
        public void OutValue(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        //يشمل كل شيء
        public void Playerstats(ref int health, out int damage)
        {
            health += 10;
            damage = health * 2;
        }



        public void Start()
        {
            //1
            int value = 5;
            Num(value);
            Debug.Log("Outside number =" + value);

            //2
            int val = 9;
            Ref(ref val);
            Debug.Log("Ref Value" + val);

            //3
            int sum;
            int product;
            OutValue(5, 4, out sum, out product);
            Debug.Log("Sum =" + sum + " Product =" + product);

            //يشمل كل شيء
            int health = 50;
            int damage;
            Playerstats(ref health, out damage);
            Debug.Log("Health = " + health + " Damage = " + damage);

        }






















        // Update is called once per frame
        void Update()
        {

        }
    }
}