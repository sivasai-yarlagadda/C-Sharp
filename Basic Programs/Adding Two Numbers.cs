
using System;
public class adding2Numbers { 
    static void Main(String[] args)
    {
        // Method 1 
        int a = 10;
        int b = 20;
        Console.WriteLine("Sum of a+b = " + (a + b));

        // Method 2
        // Taking input from the user
        Console.WriteLine("Enter the First number ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second number ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum of Two Numbers are : " +  (num1+num2));

    }

}
