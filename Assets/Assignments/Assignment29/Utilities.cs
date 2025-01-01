using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static string RepeatString(this string str, int Count)
        {

            string result = " ";
            for (int i = 1; i <= Count; i++)
            {
                result+=str;
            }
            return result;
        }
    }
}