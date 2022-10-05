using System;

class Factors
{
    static void PrintFactors(int number)
    {
        int i= 0;
        Console.WriteLine("The all factors of " + number + " are :");

        for (i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
    static void Main(string[] args)
    {
        int number= 0;
        
        Console.Write("Enter an integer number: ");
        number = int.Parse(Console.ReadLine());

        PrintFactors(number);

        Console.WriteLine();
    }
}