// print the pyramid in the number format
/*
   1
  2 3
 4 5 6 
7 8 9 10

 
 */

using System;
public class Pyramid { 
    static void Main(String[] args)
    {
        int a = 4;
        int c = 1;
        for (int i = 0; i <= a; i++)
        {
            for (int k = 0; k < a - i; k++)
            {
                Console.Write(" ");
            }


            for (int j = 0; j < i; j++)
            {
                Console.Write(c + " ");
                c++;
            }
            Console.WriteLine();
        }

    }

}
