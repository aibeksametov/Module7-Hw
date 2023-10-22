using MyClassLib.WordOfTanks;
using System;

class Program
{
    static void Main()
    {
        Tank[] t34Tanks = new Tank[5];
        Tank[] pantherTanks = new Tank[5];

        for (int i = 0; i < 5; i++)
        {
            t34Tanks[i] = new Tank("T-34");
            pantherTanks[i] = new Tank("Panther");
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Battle {i + 1}:");
            Console.WriteLine(t34Tanks[i].GetTankInfo());
            Console.WriteLine(pantherTanks[i].GetTankInfo());

            if (t34Tanks[i] ^ pantherTanks[i])
                Console.WriteLine("T-34 wins!");
            else
                Console.WriteLine("Panther wins!");

            Console.WriteLine();
        }
        Console.ReadKey();
    }
}