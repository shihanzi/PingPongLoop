// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("PingPong");
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Ping");
        continue;
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Pong");
        continue;
    }
    Console.WriteLine(i);
}
    
