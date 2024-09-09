//#define RHOMBUS_1
#define RHOMBUS_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int n = Convert.ToInt32(Console.ReadLine());

#if RHOMBUS_1
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
				for (int j = 0; j < i; j++) Console.Write("  "); Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
				for (int j = i; j < n - 1; j++) Console.Write("  "); Console.Write("/");
				Console.WriteLine();
			} 
#endif
			#region RhombusHard
			//for (int i = 0; i < n * 2; i++)
			//{
			//	for (int j = 0; j < n * 2; j++)
			//	{
			//		if (i < n && i == j - n || i >= n && j == i - n) Console.Write("\\");
			//		else if (i == n - 1 - j || j - n == n*2 - 1 - (i)) Console.Write("/");
			//		else Console.Write(" ");
			//	}
			//	Console.WriteLine();
			//} 
			#endregion

			for (int i = 0; i < n * 2; i++)
			{
				for (int j = 0; j < n * 2; j++)
				{
					if (i == j - n || j == i - n) Console.Write("\\");
					else if (i == n - 1 - j || i - n == n * 2 - 1 - j) Console.Write("/");
					else Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
	}
}
