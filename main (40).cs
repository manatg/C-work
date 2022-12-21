using System;

class Program {
  public static void Main (string[] args) {
    double [] num = new int[8];
    int sum=0;
    Console.WriteLine("Enter the array elements");
      for (int i=-0; i<4; i++)
    {
      num[i]= Convert.ToInt32(Console.ReadLine());
        sum+=num[i]; //sum=sum+num[i]; 
    }
    Console.WriteLine("Array elements are");
    for (int i=0; i<4; i++)
    {
      Console.WriteLine(num[i]);
    }
      Console.WriteLine("Sum is (0), sum");
  }
}