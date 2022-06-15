﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = (List<int>)Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int newElement = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(newElement);
            }

            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
