﻿using System;
namespace programm7
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[100];
            System.Random rand = new System.Random();
            int firHalf = 0;
            int secHalf = 0;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-50, 50);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length / 2)
                    if (arr[i] < 0)
                        firHalf++;

                if (i > arr.Length / 2)
                    if (arr[i] < 0)
                        secHalf++;
            }

            if (firHalf > secHalf)
                System.Console.WriteLine("1");

            if (firHalf < secHalf)
                System.Console.WriteLine("2");

            if (firHalf == secHalf)
                System.Console.WriteLine("0");

            System.Console.ReadKey();

        }
    }
}