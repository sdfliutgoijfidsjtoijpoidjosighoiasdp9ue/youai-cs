using System;

public class Program
{
    public static void Main()
    {
        int inside = 0;
        int total = 0;
        Random rand = new Random();

        while (total < 10000)
        {
            double x = rand.NextDouble();
            double y = rand.NextDouble();

            if (x * x + y * y <= 1.0)
            {
                inside++;
            }

            total++;
        }

        double pi = 4.0 * inside / total;
        Console.WriteLine("Pi = {0}", pi);
    }
}
