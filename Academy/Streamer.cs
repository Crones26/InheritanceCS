using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	//Single responsibility principle
	internal class Streamer
	{
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}
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
		//CSV - Comma Separated Values (Значение, разделенные запятой)

	}
}
