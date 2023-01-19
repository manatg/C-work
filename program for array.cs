using System;

class Program {
  public static void Main (string[] args) {


    int []  num = {4,7,15,2,10,3};
    int sum=0;
    Console.WriteLine("Enter the array with a length of 6");
    for (int i=0; i<6; i++)
    { 
     sum+=num[i];

    } 
    
   Console.WriteLine("Sum is {0}", sum);

}
  }
