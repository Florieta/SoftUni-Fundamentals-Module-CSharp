using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                double pricePerOrder = pricePerCapsule * days * capsuleCount;
                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:F2}");
                totalPrice += pricePerOrder;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
