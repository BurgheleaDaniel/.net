using System;

namespace Demo01
{
	using ClassLibrary1.Base;

	class Human
	{
		public string Name;

		public void Method() { }
	}

	class Student : Human
	{
		public string Name;

		public void Method() { }
	}
	class Profesor : Human
	{
		public string Name;

		public void Method() { }
	}


	class Calc
	{
		static public void Main(String[] args)
		{
			/*Console.WriteLine("Main Method");

			var sum = ClassLibrary1.Calc.Sum(12, 122);
			Console.WriteLine("sum: " + sum);

			var sum2 = ClassLibrary1.Calc.Sum(12, 12);
			Console.WriteLine("sum: " + sum2);

			var bases = new BaseClass();

			decimal a = 1.0m;
			decimal b = 0.33m;
			decimal suma = 1.33m;
			bool equal = a + b == suma; // False!!!
			Console.WriteLine("a+b={0}  sum={1}  equal={2}",
							  a + b, suma, equal);*/

			object s = new Student();

			object p = new Profesor();

			bool r = s is Student;

			Student x = s as Student;

			Student y = p as Student;

			Console.WriteLine(s is Student);
			Console.WriteLine(x is Student);
			Console.WriteLine(y is Human);
			Console.WriteLine(typeof(Human));

		}

	}

}
