﻿//#define LOAD_TO_FILES
//#define SAVE_TO_FILES
//#define INHERITANCE_CHECK
//#define SAVE_CHECK
#define LOAD_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_CHECK
			Human human = new Human("Montana", "Antonio", 25);
            human.Print();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
            student.Print();
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            teacher.Print();
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate("Smith", "John", 24, "Chemistry", "WW_220", 90, 98,
				"Nanofiber", "Dr. Alan Turing"
            );
            graduate.Print();
            Console.WriteLine(graduate);
#endif

#if SAVE_TO_FILES
			//// Перезапись информации о каждом объекте в файл
			//using (StreamWriter sw = new StreamWriter("Group.txt"))
			//{
			//	foreach (Human person in group)
			//	{
			//		sw.WriteLine(person.ToString());
			//		sw.WriteLine();
			//	}
			//}

			// Добавление информации о каждом объекте в файл
			StreamWriter sw = File.AppendText("Group.txt");
            foreach (Human person in group)
            {
                sw.WriteLine(person.ToString());
                sw.WriteLine();
            }
            sw.Close();
#endif

#if LOAD_TO_FILES
			// Чтение данных из файла и вывод их в консоль
			Console.WriteLine("Содержимое файла: ");
			StreamReader sr = new StreamReader("Group.txt");
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(buffer);
			}
			sr.Close();
			// Открываем файл в блокноте для просмотра
			Process.Start("notepad", "Group.txt"); 
#endif

#if SAVE_CHECK
			Human[] group = new Human[]
			{
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 97, 98),
				new Graduate("Smith", "John", 24, "Chemistry", "WW_220", 90, 98, "NanoFiber", "Dr. Alan Turing"),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
			};

			Streamer.Print(group);
			Streamer.Save(group, "group.csv");
#endif

#if LOAD_CHECK
			Human[] group = Streamer.Load("group.csv");
			Streamer.Print(group);
#endif

		}
	}
}