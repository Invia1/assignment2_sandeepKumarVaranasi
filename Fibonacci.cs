// C# program to illustrate
// switch case statement
using System;

public class Program
{

    // Main Method
    public void factorial()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number : " + n);
        if (n == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                Console.WriteLine(fact + " ");
            }

        }
    }
    public void fibonacci()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number : " + n);

        int first = 0, second = 1, third = 0;

        for (int i = 2; i <= n; i++)
        {
            third += first + second;
            Console.WriteLine("Fibonacci seeries is : " + third);
            first = second;
            second = third;
        }
    }
    public void primeNumber()
    {
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number : " + n1);

        for (int i = 2; i < n1; i++)
        {
            if (n1 % i == 0)
            {
                Console.WriteLine(n1 + " is not Prime number.");
            }
            else if (n1 % i != 0)
            {
                Console.WriteLine(n1 + " is Prime number.");
            }
        }

    }
    public static void Main(String[] args)
    {
        int num = int.Parse(Console.ReadLine());
        var obj = new Program();
        string val;
        do
        {
            switch (num)
            {

                case 1:
                    obj.fibonacci();
                    break;

                case 2:
                    obj.primeNumber();
                    break;

                case 3:
                    obj.factorial();
                    break;

                default:
                   Console.WriteLine("It is not correct output Try again......");
                    break;
            }
             Console.WriteLine("Enter yes to continue loop");
            val = Console.ReadLine();
        }
       
while(val=="yes");
    }
}
