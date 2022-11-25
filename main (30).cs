//Program will print numbers 1 to 30 with 10 on each line and spaced out
using System;

class Program {
  public static void Main (string[] args) {
    int n = 3;
    for (int i = 1; i <= n; i++)  //outer loop
    {
      for (int j = 1; j <= 10; j++) //inner loop
      {
        Console.Write ( (i * j) + "\t");
      }
      Console.WriteLine ();
    }
    
  
  }
}