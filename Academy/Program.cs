//#define INHERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			//Human[] group = new Human[]
			//	{
			//		new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
			//		new Teacher("White", "Walter", 50, "Chemistry", 25)
			//	};
		}
	}
}