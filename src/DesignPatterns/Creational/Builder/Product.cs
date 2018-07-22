namespace Builder
{
    using System;
    using System.Collections.Generic;

    public class Product
    {
        private readonly List<string> parts = new List<string>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product Parts:");
            foreach (var part in this.parts)
                Console.WriteLine(part);
        }
    }
}