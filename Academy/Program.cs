//#define SAVE_TO_FILES
//#define INHERITANCE_CHECK
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

			Human[] group = new Human[]
			{
				new Human("Montana", "Antonio", 25),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
				new Graduate("Smith", "John", 24, "Chemistry", "WW_220", 90, 98, "NanoFiber", "Dr. Alan Turing"),
			};
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
		}
	}
}