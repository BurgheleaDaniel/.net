using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Week6Homework
{
	class Ex2
	{
		static async Task Main(string[] args)
		{
			ReadPostsAndComments commentsReader = new ReadPostsAndComments();
			await commentsReader.RunAsync();
			commentsReader.PrintAll();
			Console.ReadKey();
		}
	}

	class ReadPostsAndComments
	{
		private List<Dictionary<int, string>> CommentList = new List<Dictionary<int, string>>();

		public async Task RunAsync()
		{
			List<int> idList = new List<int>();
			var t1 = ReadAllPosts();

			string[] posts = await Task.WhenAll(t1);
			JArray details = JArray.Parse(posts[0]);

			foreach (var element in details)
			{
				if (int.TryParse((string)element["id"], out int postId))
				{
					idList.Add(postId);
				}
			}

			int proccessedPosts = 25;
			var taskComments1 = ReadAllCommentsForAPost(idList, 0, proccessedPosts);
			var taskComments2 = ReadAllCommentsForAPost(idList, 25, proccessedPosts);
			var taskComments3 = ReadAllCommentsForAPost(idList, 50, proccessedPosts);
			var taskComments4 = ReadAllCommentsForAPost(idList, 75, proccessedPosts);

			await Task.WhenAll(taskComments1, taskComments2, taskComments3, taskComments4);
		}

		private async Task<string> ReadAllPosts()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.GetAsync($"https://jsonplaceholder.typicode.com/posts");
			string value = await response.Content.ReadAsStringAsync();

			return value;
		}

		private async Task ReadAllCommentsForAPost(List<int> idList, int start, int proccess)
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();

			for (int i = start; i < start + proccess; i++)
			{
				int id = idList[i];
				HttpClient client = new HttpClient();
				HttpResponseMessage response = await client.GetAsync($"https://jsonplaceholder.typicode.com/comments?postId={id}");
				string value = await response.Content.ReadAsStringAsync();

				dictionary.Add(id, value);
			}

			CommentList.Add(dictionary);
		}

		public void PrintAll()
		{
			foreach (Dictionary<int, string> dict in CommentList)
			{
				dict.ToList().ForEach(x => Console.WriteLine(x.Value));
			}
		}
	}
}

