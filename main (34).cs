//Program will find the sum of odd numbers, no matter how many numbers are added. -999 needs to be added at the end to get the sum 
using System;

class Program {
  public static void Main (string[] args) {
    int sum = 0;
    int num = Convert.ToInt32(Console.ReadLine());
    while (num != -999)
    {
      if (num % 2 != 0)
      {
        sum += num;
      }
      num = Convert.ToInt32 (Console.ReadLine ());
    }
    
  
    Console.WriteLine (sum);
  }
}