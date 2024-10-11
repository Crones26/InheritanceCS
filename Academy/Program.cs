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
			// Запись информации о каждом объекте в файл
			using (StreamWriter sw = new StreamWriter("Group.txt"))
			{
				foreach (Human person in group)
				{
					sw.WriteLine(person.ToString());
					sw.WriteLine();
				}
			}

			// Открываем файл в блокноте для просмотра
			Process.Start("notepad", "Group.txt");
		}
	}
}