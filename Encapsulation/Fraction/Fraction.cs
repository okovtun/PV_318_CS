using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Fraction
	{
		public int Integer { get; set; }	//Автосвойства, которые не требую объявления переменной, поскольку сами, неявно ее объявляют.
		public int Numerator { get; set; }
		/// ////////////////////
		int denominator;
		// Обычные свойства, которые применяются к переменной 'denominator':
		public int Denominator
		{
			get => denominator;
			set => denominator = value == 0 ? 1 : value;
		}
		/// ////////////////////
		/// 

		//			  Constructors:
		public Fraction(int integer)
		{
			this.Integer = integer;
			Console.WriteLine($"1ArgConstructor:{GetHashCode()}");
		}
		~Fraction()
		{
			Console.WriteLine($"Destructor:{GetHashCode()}");
		}
		//				Methods:
		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				Console.Write("(");
				Console.Write($"{Numerator}/{Denominator}");
				Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}
	}
}
