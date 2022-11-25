//Program will print the sum of the ood numvers between 1 and 10
using System;

class Program {
  public static void Main (string[] args) {
    int sum = 0;
    for (int i = 1; i < 10; i += 2)
    {
      sum += i;
    }
    
    Console.WriteLine (sum);
  }
}


