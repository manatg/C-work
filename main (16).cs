//Difference between while and do while loop
using System;

class Program {
  public static void Main (string[] args) {
    int i=1; //initialization
    while(i<1) //condition
    {

    Console.WriteLine("Hello World");
      i+=2; //increment
    }  
   
  }
}

using System;

class Program {
  public static void Main (string[] args) {
 int i=1; //initialization
    do 
    {

    Console.WriteLine ("Hello World");
      i++; //increment
    } while(i<1);   //condition
  }
}