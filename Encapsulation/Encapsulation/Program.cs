//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSTRUCTORS_CHECK
			//Stack - статическая память;
			//Heap - динамическая память;

			//Point A = new Point();  //Оператор 'new' вызывает конструктор класса.
			//A.SetX(2);
			//A.SetY(3);
			//Console.WriteLine($"X = {A.GetX()}, Y = {A.GetY()};");
			//A.Print();

			Point B = new Point();  //Default constructor
			B.X = 7;
			B.Y = 8;
			B.Print();

			Point C = new Point(11, 12);
			C.Print();

			//Console.WindowWidth;
			//Console.SetWindowSize

			Point D = C;    //Здесь копируется НЕ объект, а ссылка на него
			D.Print();
			D.X = 111;
			C.Print();

			//Объекты копируются следующим образом:
			Point E = new Point(D); //Здесь вызывается конструктор копирования
			E.Print();
			E.X = 11;
			D.Print();

			E = new Point(B);
			E.Print(); 
#endif
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);
			C.Print();
		}
	}
}
