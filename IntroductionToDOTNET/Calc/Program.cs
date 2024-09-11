using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{
			//2+3
			Console.Write("Введите выражение: ");
			string expression = Console.ReadLine();
			Console.Write(expression + " = ");
			String[] tokens = expression.Split('+', '-', '*', '/');
			//for (int i = 0; i < tokens.Length; i++)
			//{
			//	Console.Write(tokens[i] + "\t");
			//}
			//Console.WriteLine();
			double a = Convert.ToDouble(tokens[0]);
			double b = Convert.ToDouble(tokens[1]);
			//Метод Contains() класса 'string' определяет, содержит ли строка указанный символ или подстроку.
			if (expression.Contains("+")) Console.WriteLine(a + b);
			else if (expression.Contains('-')) Console.WriteLine(a - b);
			else if (expression.Contains('*')) Console.WriteLine(a * b);
			else if (expression.Contains('/')) Console.WriteLine(a / b);
			else Console.WriteLine("No operation");
		}
	}
}
