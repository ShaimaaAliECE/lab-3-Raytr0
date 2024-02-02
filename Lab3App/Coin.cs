using System;
using System.Collections.Generic;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int Value;
        public Coin(string des, int score, int value)
        {
            Description = des;
            Score = score;
            Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }
        public override void Display()
        {
            Console.WriteLine($"{nameof(Coin)} {Description} is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
    }
}