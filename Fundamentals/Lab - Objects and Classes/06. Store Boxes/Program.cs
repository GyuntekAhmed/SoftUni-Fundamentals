﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string[] data = Console.ReadLine().Split();

                if (data[0] == "end")
                {
                    break;
                }

                Box box = new Box
                {
                    SerialNumber = data[0],
                    Item = new Item(data[1], double.Parse(data[3])),
                    ItemQuantity = int.Parse(data[2])
                };

                boxes.Add(box);
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.Price).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }

    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }
    }
}
