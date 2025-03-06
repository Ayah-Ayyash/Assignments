using System;
using System.Collections.Generic;

public class Random
{
    //Task 4 Solve
    private Dictionary<int, int> dictionary;
    private List<int> list;
    private Random random;

    public Random()
    {
        dictionary = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }

    public bool Insert(int val)
    {
        if (dictionary.ContainsKey(val)) return false;
        dictionary[val] = list.Count;
        list.Add(val);
        return true;
    }

    public bool Remove(int val)
    {
        if (!dictionary.ContainsKey(val)) return false;

        int index = dictionary[val];
        int lastElement = list[list.Count - 1];

        list[index] = lastElement;
        dictionary[lastElement] = index;

        list.RemoveAt(list.Count - 1);
        dictionary.Remove(val);

        return true;
    }

    public int GetRandom()
    {
        int randomIndex = random.Next(list.Count);
        return list[randomIndex];
    }


    //Task 5 Solve
    public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; 
        Array.Reverse(nums); 
        Array.Reverse(nums, 0, k); 
        Array.Reverse(nums, k, n - k); 
    }
}


}
