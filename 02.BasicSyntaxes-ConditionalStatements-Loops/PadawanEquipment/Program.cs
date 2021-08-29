using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBells = double.Parse(Console.ReadLine());

            double totalSum = priceLightsabers * Math.Ceiling(studentsCount * 1.1) + priceRobes * studentsCount + priceBells * (studentsCount- (studentsCount/6));

            if (amountOfMoney >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalSum - amountOfMoney):F2}lv more.");
            }
            
        }
    }
}
