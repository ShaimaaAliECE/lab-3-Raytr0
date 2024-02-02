using System;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string des, int score)
        {
            Description = des;
            Score = score;
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond{Description} is displayed");
        }
    }
}