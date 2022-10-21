using System;

class Program {
  public static void Main (string[] args) {
    
    /* int a,b; // declaration 
    a=10; b=5; // initialization */
    /* int a=10, b=5;
    int exp= 7; */
    int a,b; 
    Console.WriteLine("Enter two numbers");
    a= Convert.ToInt32(Console.ReadLine());
    b= Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the option");
    string exp =Console.ReadLine();

    
    //Console.Writeline ("Hello World");
    
  switch(exp)  
  {
    case "+": Console.WriteLine((a+b));
      break;

    case "-": Console.WriteLine((a-b));
      break;
      
    case "*": Console.WriteLine((a*b));
      break;

    case "/": Console.WriteLine((a/b));
      break;

    case "%": Console.WriteLine((a%b));
      break; 

    default: Console.WriteLine("some other choice");
  break;
  }  
  }
}
    
