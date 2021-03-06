﻿namespace AbstractFactory
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            Console.WriteLine();

            AbstractFactory factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }
}
