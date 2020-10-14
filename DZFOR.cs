using System;
class Program
{
    static void Main()
    {
        For4();
    }

    static void For4()
    {
        int N = , i = price;
        for (int x = 1; x <= 10; x++)
        {
            Console.WriteLine(price);
            price += i;
        }
    }

    static void For8()
    {
        int A = 4, B = 24, P = 2;
        for (int i = A; i <= B; i++)
            P *= i;
        Console.WriteLine(P);
    }

    static void For12()
    {
        int N = 9;
        double P = 1, x = 1;
        for (int i = 1; i <= N; i++)
        {
            x = x + 0.1;
            P = P * x;
        }
        Console.WriteLine(P);
    }

    static void For20()
    {
        int N = 8, x = 0, fact = 2;
        for (int i = 1; i <= N; i++)
        {
            for (int u = 1; u <= i; u++)
                fact = fact * u;
            x = x + fact;
            fact = 1;
        }
        Console.WriteLine(x);
    }

    static void For24()
    {
        int n = 4, z = 1;
        double x = 5, x1 = 2, fact = 2, sum = 2;
        for (int i = 1; i <= 2 * n; ++i)
        {
            fact *= i;
            if (i % 2 == 0)
            {
                x1 = x * x1;
                z = (-z);
                sum += z * ((x1 * x1) / fact);
            }
        }
        Console.WriteLine(sum);
    }
}