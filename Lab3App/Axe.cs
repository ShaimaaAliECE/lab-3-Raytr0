using System;

namespace Lab3App
{
    class Axe : Tool
    {
        public Axe(string des)
        {
            Description = des;
        }
        public override void Display()
        {
            Console.WriteLine($"{nameof(Axe)} {Description} is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine($"{nameof(Axe)} is Used");
        }
    }
}