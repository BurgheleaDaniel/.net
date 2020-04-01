using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TemaWeek4
{
	class Ex4
	{
		static public void Run()
		{
			ScanDir(@"D:\.net\week1\home\Tema1r\Tema1r", @"Ex1.cs", 5, 10);
		}

		private static void ScanDir(string d, string f, int from, int to)
		{
			Console.WriteLine($"=====Dir {d}=====");
			foreach (string file in Directory.GetFiles(d))
			{
				string fName = Path.GetFileName(file);
				Console.WriteLine(fName + " - FILE");
				if (fName == f)
				{
					int counter = 1;
					string line;

					System.IO.StreamReader actualFile = new System.IO.StreamReader(d + "\\" + f);
					while ((line = actualFile.ReadLine()) != null)
					{
						if (counter >= from && counter <= to)
						{
							System.Console.WriteLine(line);
						}
						counter++;
					}

					actualFile.Close();
				}
			}
			foreach (string dir in Directory.GetDirectories(d))
			{
				Console.WriteLine(Path.GetFileName(dir) + " - DIR");
				ScanDir(dir, f, from, to);
			}
		}
	}
}
