//#define OUTPUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	class Program
	{
		static void Main(string[] args)
		{
#if OUTPUT_TO_SCREEN
			Console.Title = "Introduction to .NET"; //Задает заголовок окна консоли
													//Console.Write("Hello .NET");//выводит строку на экран
			Console.WriteLine("Hello .NET");//выводит строку на экран и переходит в начало новой строки

			Console.BackgroundColor = ConsoleColor.Blue;    //цвет фона
			Console.ForegroundColor = ConsoleColor.Black; //цвет текста

			//Console.CursorLeft = 24;    //координата курсора по оси 'X'
			//Console.CursorTop = 5;      //координата курсора по оси 'Y'
			Console.SetCursorPosition(16, 5);
			Console.WriteLine("Вот так задаются координаты");
			Console.ResetColor();       //применяыет цветовую схему по умолчанию

			//Задаем размеры окна:
			//Console.WindowWidth = 64;
			//Console.WindowHeight = 16;
			Console.SetWindowSize(64, 16);

			//Для того чтобы свернуть часть кода, этот код нужно поместить в #region ... #endregion:
			#region CodeSnippet	
			//Задаем положение окна на экране:
			//Console.WindowLeft = 10;
			//Console.WindowTop = 10;
			//Console.SetWindowPosition(10, 10); 
			#endregion

			//Задаем размер буфера консоли:
			Console.BufferWidth = Console.WindowWidth;
			Console.BufferHeight = Console.WindowHeight; 
#endif

			Console.Write("Введите Ваше имя: ");
			string first_name = Console.ReadLine(); //Метод ReadLine() читает строку с клавиатуры до нажатия 'Enter', и возвращает прочитанную строку.
			//Console.WriteLine(first_name);

			Console.Write("Введите Вашу фамилию: ");
			string last_name = Console.ReadLine();
			//Console.WriteLine(last_name);

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());
			/*
			 ------------------------------
			 Класс 'Convert' представляет собой набор статических методов для преобрахования типов.
			 Этот класс используется как правило в том случае, когда другие преобразования не работают.
			 ------------------------------
			 */
			//Console.WriteLine(a);


			//			Операции над строками:
			Console.WriteLine(last_name + " " + first_name + " " + age + " years");    //Конкатенация строк
			
			//Кроме конкатенации строк C# поддерживает форматирование строк:
			Console.WriteLine(String.Format("{0} {1} {2} years", last_name, first_name, age));

			//Самая удобная операция - Интерполяция строк:
			Console.WriteLine($"{last_name} {first_name} {age} years");	//Интерполяция - изменение, искажение.
		}
	}
}
