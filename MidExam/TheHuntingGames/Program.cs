using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double waterTotal= water * players * days;
            double foodTotal = food * players * days;
            double temp = 0;
            for (int i = 1; i <= days; i++)
            {
                double lossEnergy = double.Parse(Console.ReadLine());
                groupsEnergy -= lossEnergy;
                
                if (groupsEnergy <= 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    groupsEnergy += groupsEnergy * 0.05;
                    waterTotal -= waterTotal * 0.3;
                }
                if (i % 3 == 0)
                {
                    groupsEnergy += groupsEnergy * 0.1;
                    temp = foodTotal / players;
                    foodTotal -= players;
                }
                
            }
            if (groupsEnergy >= 0)
            {

                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy} energy!"); 
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodTotal} food and {waterTotal} water.");
            }    
        }
    }
}
