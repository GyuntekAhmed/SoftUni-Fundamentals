﻿using System;
using System.Linq;

namespace _9.___Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequenceLenght];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStartIndex = -1;
            int dnaSamples = 0;
            int sample = 0;

            while (input != "Clone them!")
            {
                sample++;

                int[] currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currCount = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                int currDnaSum = 0;
                bool isCurrDnaBetter = false;
                int count = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++;

                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }

                currStartIndex = currEndIndex - currCount + 1;
                currDnaSum = currentDNA.Sum();

                if (currCount > dnaCount)
                {
                    isCurrDnaBetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            isCurrDnaBetter = true;
                        }
                    }
                }

                if (isCurrDnaBetter)
                {
                    DNA = currentDNA;
                    dnaCount = currCount;
                    dnaStartIndex = currStartIndex;
                    dnaSum = currDnaSum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}