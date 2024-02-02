using System;
using System.ComponentModel;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public MagicWand(string des)
        {
            Description = des;
        }
        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine($"MagicWand is Used");
        }
    }
}