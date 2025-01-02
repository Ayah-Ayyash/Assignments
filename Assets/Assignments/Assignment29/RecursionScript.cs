using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    public int FibonacciRecursive(int n)
    {
        if (n < 0) return -1;
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    public int FibonacciIterative(int n)
    {
        if (n < 0) return -1;
        if (n == 0) return 0;
        if (n == 1) return 1;

        int a = 0;
        int b = 1;

        for (int i = 2; i <= n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
        }
        return b;
    }

    void Start()
    {
        Debug.Log("FibonacciIterative(10): " + FibonacciIterative(10));
        Debug.Log("FibonacciIterative(30): " + FibonacciIterative(30));
        Debug.Log("FibonacciRecursive(10): " + FibonacciRecursive(10));
        Debug.Log("FibonacciRecursive(30): " + FibonacciRecursive(30));
    }
}