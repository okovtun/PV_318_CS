﻿//#define INHERITANCE_1
//#define INHERITANCE_2
//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Academy
{
	class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_1
			Human human = new Human("Vercetty", "Tommy", 30);
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			Console.WriteLine(teacher); 
#endif

#if INHERITANCE_2
			Human tommy = new Human("Vercetty", "Tommy", 30);
			Console.WriteLine(tommy);

			Student student_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
			Console.WriteLine(student_tommy);

			Human ricardo = new Human("Diaz", "Ricardo", 50);
			Console.WriteLine(ricardo);

			Teacher teacher_ricardo = new Teacher(ricardo, "Weapons distribution", 20);
			Console.WriteLine(teacher_ricardo);

			Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 50, 40, "How to catch Hiesenberg");
			Console.WriteLine(graduate);

			Graduate graduate_tommy = new Graduate(student_tommy, "How to make money");
			Console.WriteLine(graduate_tommy); 
#endif

#if WRITE_TO_FILE
			Human[] group = new Human[]
					{
					new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
					new Teacher("White", "Walter", 50, "Chemistry", 25),
					new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 50, 40, "How to catch Hiesenberg"),
					new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 95, 98),
					new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
					};
			Print(group);
			Save(group, "group.csv");   //CSV - Comma-Separated Values (Значения разделенные запятыми).
										//CSV - это общепринятый фармат файлов для хранения таблиц в текстовых файлах.  
#endif
			Human[] group = Load("group.csv");
			Print(group);
		}
		static void Print(Human[] group)
		{
			//for (int i = 0; i < group.Length; i++)
			//{
			//	Console.WriteLine($"{group[i]};");
			//}
			foreach (Human i in group)
			{
				Console.WriteLine(i);	//Downcast - преобразрвание от базового типа к дочернему
			}
		}
		static void Save(Human[] group, string filename)
		{
			StreamWriter sw = new StreamWriter(filename);
			foreach (Human i in group)
			{
				sw.WriteLine(i.ToFileString()); //Downcast - преобразрвание от базового типа к дочернему
			}
			sw.Close();
			Process.Start("excel", filename);
		}
		static Human[] Load(string filename)
		{
			List<Human> list = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				//Console.WriteLine(buffer);
				string[] values = buffer.Split(',');
				//Human human = HumanFactory(values[0]);
				//human.Init(values);
				//list.Add(human);
				list.Add(HumanFactory(values[0]).Init(values));
			}
			sr.Close();
			return list.ToArray();
		}
		static Human HumanFactory(string type)	//Upcast - преобразование дочернего типа к базовому.
		{
			Human human = null;
			switch (type)
			{
				case "Human":		human = new Human("", "", 0);						break;
				case "Teacher":		human = new Teacher("", "", 0, "", 0);				break;
				case "Student":		human = new Student("", "", 0, "", "", 0,0);		break;
				case "Graduate":	human = new Graduate("", "", 0, "", "", 0,0,"");	break;
			}
			return human;
		}
	}
}
