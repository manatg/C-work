using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = 1;
        for (int i = 5; i >= n; i--) //outer loop
        {
            for (int j = 1; j <= 5; j++) //inner loop
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
