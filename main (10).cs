using System;

class Program {
  public static void Main (string[] args)
  {
      int result1;
      int a = 5, b = 6, c = 4;
      result1 = --a * b - ++c;
               //  5 * 6 - 4
               // 4 * 6
              // 24 - 5 = 19
    Console.WriteLine ("result is {0}",result1 );

    bool result2;
    result2 = b>=c + a;
    Console.WriteLine(" a and c {0} {1} ", a, c);
    // 6>= 5 + 4

    int result3;
    result3 = a++ - b / c;
    Console.WriteLine (result3);
   // 5 - 6 / 4
    // 6 / 4 - 5
    // 1.5 - 5 = -3.5 

   int result4;
    result4 =  a++ + ++b * c;
    Console.WriteLine (result4);
    // 5 + 6 * 4

    bool result5;
    result5 =  c <= a%c;
    Console.WriteLine (result5);
    // 4 <= 5%6
    
    Console.WriteLine(result2);
  }
}