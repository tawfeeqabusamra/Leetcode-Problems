using System.Collections;
using System.Collections.Generic;
using System;
public class RandomizedSet
{
    List<int> nums;
    Dictionary<int, int> indexMap;
    Random rand;
    


    public RandomizedSet()
    {
        nums = new List<int>();
        indexMap = new Dictionary<int, int>();
        rand = new Random();

    }

    public bool Insert(int val)
    {
        if (indexMap.ContainsKey(val))
            return false;
        else
            nums.Add(val);
        indexMap[val] = nums.Count - 1;
        return true;

    }

    public bool Remove(int val)
    {
        if (indexMap.ContainsKey(val))
        {
            int valIndex = indexMap[val];
            nums.RemoveAt(valIndex);
            indexMap.Remove(val);
            return true;
        }
        else
            return false;
    }

    public int GetRandom()
    {
        int randImdex = rand.Next(nums.Count);
        return nums[randImdex];
        
    }
}