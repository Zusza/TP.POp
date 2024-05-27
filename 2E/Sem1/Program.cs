using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuza.Jerzynska._2E.popr.kolekcje._27._05._24r
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Zad.2
			List<int> list = new List<int>();
			for (int i = 10; i <= 20; i++)
			{
				for (int j = 1; j <= 20; j++)
				{
					if (i % j == 0)
					{
						list.Add(j);
						Console.WriteLine($"{i} - {j}");
					}
				}
				//Console.WriteLine($"{i} -");

			}

			//for(int i = 10; i <= 20; i++)
			//{

			//}
			//Zad.1
			//int n = int.Parse(Console.ReadLine());
			//int[] T = new int[n];
			//for (int i = n; i == n; i++)
			//{
			//	for (int j = i; j < n; j++)
			//	{

			//	}
			//}
		}
	}
}
