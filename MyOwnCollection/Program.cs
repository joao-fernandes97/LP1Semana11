using System;

namespace MyOwnCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortQueue<int> sq5 = new ShortQueue<int>();
            ShortQueue<int> sq3 = new ShortQueue<int>(3);

            sq5.Add(1);
            Console.WriteLine(sq5.Count);
            sq5.Add(2);
            Console.WriteLine(sq5.Count);
            sq5.Add(3);
            Console.WriteLine(sq5.Count);
            sq5.Add(4);
            Console.WriteLine(sq5.Count);
            sq5.Add(5);
            Console.WriteLine(sq5.Count);
            sq5.Add(6);
            Console.WriteLine(sq5.Count);

            sq5.Clear();
            Console.WriteLine(sq5.Count);

            sq5.Add(7);
            Console.WriteLine(sq5.Count);
            sq5.Add(8);
            Console.WriteLine(sq5.Count);
            sq5.Add(9);
            Console.WriteLine(sq5.Count);
            sq5.Add(10);
            Console.WriteLine(sq5.Count);



        }
    }
}
