﻿using System;

namespace PrimeNumberApp
{
  class Program
  {
    static void Main(string[] args)
    {
          Console.WriteLine("\nHien thi cac so nguyen to nho hon 100:");

      bool isPrime = true;
      for (int i = 2; i <= 100; i++)
      {
        for (int j = 2; j <= 100; j++)
        {
          if (i != j && i % j == 0)
          {
            isPrime = false;
            break;
          }
        }

        if (isPrime)
        {
          Console.Write($"{i}  ");
        }
        isPrime = true;
      }

      Console.WriteLine("\n");
    }
  }
}