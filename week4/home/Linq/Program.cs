namespace LinqAndLamdaExpressions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Models;

	internal class Program
	{
		private static void Main(string[] args)
		{
			List<User> allUsers = ReadUsers("users.json");
			List<Post> allPosts = ReadPosts("posts.json");

			#region Demo

			// 1 - find all users having email ending with ".net".
			var users1 = from user in allUsers
						 where user.Email.EndsWith(".net")
						 select user;

			var users11 = allUsers.Where(user => user.Email.EndsWith(".net"));

			IEnumerable<string> userNames = from user in allUsers
											select user.Name;

			var userNames2 = allUsers.Select(user => user.Name);

			foreach (var value in userNames2)
			{
				Console.WriteLine(value);
			}

			IEnumerable<Company> allCompanies = from user in allUsers
												select user.Company;

			var users2 = from user in allUsers
						 orderby user.Email
						 select user;

			var netUser = allUsers.First(user => user.Email.Contains(".net"));
			Console.WriteLine(netUser.Username);

			#endregion

			// 2 - find all posts for users having email ending with ".net".
			IEnumerable<int> usersIdsWithDotNetMails = from user in allUsers
													   where user.Email.EndsWith(".net")
													   select user.Id;

			IEnumerable<Post> posts = from post in allPosts
									  where usersIdsWithDotNetMails.Contains(post.UserId)
									  select post;

			//foreach (var post in posts)
			//{
			//	Console.WriteLine(post.Id + " " + "user: " + post.UserId);
			//}


			// 3 - print number of posts for each user.
			//var result = allPosts.GroupBy(p => p.UserId)
			//		.Select(g => new
			//		{
			//			UserId = g.Key,
			//			NumberOfPosts = g.Count()
			//		});
			//foreach (var res in result)
			//{
			//	Console.WriteLine("user: " + res.UserId + " " + "no of posts: " + res.NumberOfPosts);
			//}


			// 4 - find all users that have lat and long negative.
			//IEnumerable<User> allUsersWithNegativeGeo = allUsers.Where(user => user.Address.Geo.Lat < 0 && user.Address.Geo.Lng < 0);
			//foreach (var user in allUsersWithNegativeGeo)
			//{
			//	Console.WriteLine("user: " + user.Name + " has negatie lat and negative lng " + user.Address.Geo.Lat + "|" + user.Address.Geo.Lng);
			//}


			// 5 - find the post with longest body.
			//var biggestPost = allPosts.OrderBy(p => p.Body.Length).Last();
			//Console.WriteLine("Post with longest body: " + biggestPost.Id);


			// 6 - print the name of the employee that have post with longest body.
			//Console.WriteLine("Name of the employee that have post with longest body: " + allUsers.Where(user => user.Id == biggestPost.UserId).First().Name);


			// 7 - select all addresses in a new List<Address>. print the list.
			//List<Address> allAddresses = allUsers.Select(user => user.Address).ToList();
			//foreach (var address in allAddresses)
			//{
			//	Console.WriteLine(address.Street + "|" + address.Geo.Lat + "|" + address.Geo.Lng);
			//}


			// 8 - print the user with min lat
			//var userMinLat = allUsers.OrderBy(u => u.Address.Geo.Lat).First();
			//Console.WriteLine(userMinLat.Name);


			// 9 - print the user with max long
			//var userMaxLng = allUsers.OrderBy(u => u.Address.Geo.Lng).Last();
			//Console.WriteLine(userMaxLng.Name);


			// 10 - create a new class: public class UserPosts { public User User {get; set}; public List<Post> Posts {get; set} }
			//    - create a new list: List<UserPosts>
			//    - insert in this list each user with his posts only
			//List<UserPosts> userPosts = new List<UserPosts>();
			//foreach (var user in allUsers)
			//{
			//	UserPosts oneUserPosts = new UserPosts();
			//	oneUserPosts.User = user;
			//	oneUserPosts.Posts = allPosts.Where(post => post.UserId == user.Id).ToList();

			//	userPosts.Add(oneUserPosts);
			//}


			// 11 - order users by zip code
			//var orderedUsersByZipCode = allUsers.OrderBy(u => u.Address.Zipcode);
			//foreach (var user in orderedUsersByZipCode)
			//{
			//	Console.WriteLine(user.Address.Zipcode);
			//}


			// 12 - order users by number of posts
			//var result = allPosts.GroupBy(p => p.UserId)
			//	.Select(g => new
			//	{
			//		UserId = g.Key,
			//		NumberOfPosts = g.Count()
			//	});
			//foreach (var res in result.OrderBy(r => r.NumberOfPosts))
			//{
			//	Console.WriteLine(res.UserId);
			//}
		}

		private static List<Post> ReadPosts(string file)
		{
			return ReadData.ReadFrom<Post>(file);
		}

		private static List<User> ReadUsers(string file)
		{
			return ReadData.ReadFrom<User>(file);
		}
	}

	public class UserPosts { public User User { get; set; } public List<Post> Posts { get; set; } }
}
