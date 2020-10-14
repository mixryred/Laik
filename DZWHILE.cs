using System;
class MainClass
{
    static void Main()
    {
        while4();
    }
    static void while4()
    {
        while (N >= 3)
            N = N / 3;
        if (N == 1)
            Console.Write("TRUE");
        else
            Console.Write("FALSE");
    }
    static void while8()
    {
        int n = 27;
        int k = 5;
        while (Math.Pow(3, k) < n)
        {
            k++;
        }
        Console.WriteLine(k);
    }
}
