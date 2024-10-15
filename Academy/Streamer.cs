using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	// Single responsibility principle
	internal class Streamer
	{
		// Метод для вывода группы в консоль
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}

		// Метод для сохранения группы в файл
		internal static void Save(Human[] group, string filename)
		{
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.WriteLine("Sep=,");
				for (int i = 0; i < group.Length; i++)
				{
					sw.WriteLine(group[i].ToFileString());
				}
			}
			Process.Start("excel", filename);
		}

		// Метод для загрузки группы из файла
		internal static Human[] Load(string filename)
		{
			List<Human> group = new List<Human>();

			using (StreamReader sr = new StreamReader(filename))
			{
				sr.ReadLine(); // Пропускаем строку с "Sep=,"
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					string[] parts = line.Split(',');

					// Проверяем тип (Student, Teacher, Graduate)
					string type = parts[0];
					if (type == "Student")
					{
						group.Add(new Student(
							parts[1], parts[2], int.Parse(parts[3]),
							parts[4], parts[5], double.Parse(parts[6]), double.Parse(parts[7])));
					}
					else if (type == "Teacher")
					{
						group.Add(new Teacher(
							parts[1], parts[2], int.Parse(parts[3]),
							parts[4], int.Parse(parts[5])));
					}
					else if (type == "Graduate")
					{
						group.Add(new Graduate(
							parts[1], parts[2], int.Parse(parts[3]),
							parts[4], parts[5], double.Parse(parts[6]), double.Parse(parts[7]),
							parts[8], parts[9]));
					}
				}
			}

			return group.ToArray();
		}
	}

}