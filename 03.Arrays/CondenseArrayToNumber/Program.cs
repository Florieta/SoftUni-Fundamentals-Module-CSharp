using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			for (int i = arr.Length; i > 0; i--)
			{
				for (int j = 0; j < i - 1; j++)
				{
					arr[j] = arr[j] + arr[j + 1];
				}
			}
			Console.WriteLine(arr[0]);
		}
    }
}
