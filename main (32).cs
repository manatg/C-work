//Program will output 5 lines of stars staring from 1 and increasing by one per line, until reached 5 stars
using System;

class Program {
  public static void Main (string[] args) {
    int n = 5;
    for (int i = 1; i <= n; i++) //outer loop
    {
      for (int j = 1; j <= i; j++) //inner loop
      {
        Console.Write("*"); 
      }
      Console.WriteLine (); 
    }
    
  
    Console.WriteLine ("");
  }
}