using System;

class Program {
  public static void Main (string[] args) {
   
      int userInput;
  
      Console.WriteLine ("Press any key to continue...");
      Console.ReadKey();
      Console.WriteLine();


      Console.Write("Input using Read() - ");
      userInput = Console.Read();
      Console.WriteLine("Ascii Value = " +userInput);
  }
}