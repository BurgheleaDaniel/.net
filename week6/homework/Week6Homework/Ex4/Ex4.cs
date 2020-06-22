using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace Ex4
{
	class Ex4
	{
		static async Task Main(string[] args)
		{

			ContentReader reader = new ContentReader();
			var task0 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.0.dat");
			var task1 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.1.dat");
			var task2 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.2.dat");
			var task3 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.3.dat");
			var task4 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.4.dat");
			var task5 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.5.dat");
			var task6 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.6.dat");
			var task7 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.7.dat");
			var task8 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.8.dat");
			var task9 = reader.ReadContentFromFile(@"D:\.net\week6\wantsome-dotnet-public\group2\asyncprog.home\data\file.9.dat");

			string[] fileContents = await Task.WhenAll(task0, task1, task2, task3, task4, task5, task6, task7, task8, task9);

			var allText = string.Join("\r\n", fileContents);
			string[] stringSeparators = new string[] { " ", ",", ".", ":", "\t", "\n", "\r", "\r\n" };
			string[] allWords = allText.Split(stringSeparators, StringSplitOptions.None);

			var countAllWords = allWords.LongCount();
			var countDistinctWords = allWords.Distinct().LongCount();

			Console.WriteLine($"count of all words - {countAllWords}");
			Console.WriteLine($"count of distinct words - {countDistinctWords}");

			var searchWord = "jvipedewifimeje";
			if (allText.Contains(searchWord))
			{
				Console.WriteLine($"search for a specific word: {searchWord}");
			}


			var groups = from word in allWords
						 orderby word ascending
						 group word by word.Length into lengthGroups
						 orderby lengthGroups.Key descending
						 select new { Length = lengthGroups.Key, Words = lengthGroups };
			Console.WriteLine($"group words per categories");
			foreach (var group in groups)
			{
				Console.WriteLine(group.Words.ToString());
				Console.WriteLine(group.Length);
			}


			Console.ReadKey();
		}
	}

	class ContentReader
	{
		public async Task<string> ReadContentFromFile(string file)
		{
			string content = "";
			try
			{
				content = File.ReadAllText(file);

			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}

			return content;
		}
	}
}
