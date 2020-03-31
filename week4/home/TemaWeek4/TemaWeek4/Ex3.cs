using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TemaWeek4
{
	class Ex3
	{
		static public void Run()
		{
			String text = "karunya123.edu  , www.karunya.edu, www.karunya.edu,  http://karunya.edu, https://karunya.edu, www.karunyauniversity.in  ,  https://mykarunya.edu, https://www.karunya.edu  ,  google.com,  google.co.in, www.google.com,  https://www.gmail.com, gmail.com";
			string[] vowels = new string[] { "a", "e", "i", "o", "u" };
			Random rand = new Random();

			IEnumerable<String> urls = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

			Console.WriteLine("1.Extract all the URLs");
			foreach (var item in urls)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("2.Display all the URLs which start with https://");
			foreach (var item in urls.Where(a => a.StartsWith("https://")))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("3.URLs ending with .edu");
			foreach (var item in urls.Where(a => a.EndsWith(".edu")))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("4.Replace all the vowels in url with given character");
			foreach (var item in urls.Select(item => Regex.Replace(item, @"[aeiou]", "x", RegexOptions.IgnoreCase)))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("5.Replace all the numbers in the URL with 1 and display");
			foreach (var item in urls.Select(item => Regex.Replace(item, @"\d", "1", RegexOptions.IgnoreCase)))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("6.Display all duplicate URLs");
			foreach (var item in urls.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => (y.Key, y.Count())))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("7.Concatenate any two URLs");
			Console.WriteLine(urls.ElementAt(rand.Next(urls.Count())) + urls.ElementAt(rand.Next(urls.Count())));

			Console.WriteLine("8.Given any URL, display last occurence of any repeating character");
			String anyUrl = "google.com";
			var repeatedCharsLast = anyUrl.GroupBy(x => x).Select(z => z.Key).Last();
			Console.WriteLine(repeatedCharsLast);

			Console.WriteLine("9.Insert [URL] at the beginning of URLs");
			String delimiter = "[URL]";
			foreach (var item in urls.Select(z => delimiter + z))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("10.Find out first occurence of character in given url");
			anyUrl = "google.com";
			var repeatedCharsFirst = anyUrl.GroupBy(x => x).Select(z => z.Key).First();
			Console.WriteLine(repeatedCharsFirst);

			Console.WriteLine("11.List out all the URLs with substring 'oo' in it.");
			foreach (var item in urls.Where(z => z.Contains("oo")))
			{
				Console.WriteLine(item);
			}
		}
	}
}
