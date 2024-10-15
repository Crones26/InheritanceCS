using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Academy
{
	internal class Graduate : Student
	{
		public string ThesisTopic { get; set; }
		public string Supervisor { get; set; }

		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string thesisTopic, string supervisor
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			ThesisTopic = thesisTopic;
			Supervisor = supervisor;
			Console.WriteLine($"GConstructor:{GetHashCode()}");
		}

		~Graduate()
		{
			Console.WriteLine($"GDestructor:{GetHashCode()}");
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{ThesisTopic}, {Supervisor}");
		}

		public override string ToString()
		{
			return base.ToString() + $" {ThesisTopic}, {Supervisor}";
		}

		public override string ToFileString()
		{
			return base.ToFileString() + $", {ThesisTopic}, {Supervisor}";
		}
	}
}