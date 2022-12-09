using System;

class Program {
  public static void Main (string[] args) {
    // 'numbers' array that stores intergers
    int[] numbers = { 3, 14, 59, 67, 1, 5 }; 
    // 2 is the index of value 59
    Console.WriteLine (numbers[5]);
    Console.WriteLine ("Length of the array is {0}",numbers. Length);  

    // declaring string array with length 4
    // initializing string array homework

    //displaying all the elements of the array 

    for(int i=0; i<6; i++)
    {
      Console.WriteLine(numbers[i]); 
    }
  }
}