﻿namespace ConferencePlanner.App
{
	using System;
	using System.Linq;
	using ConferencePlanner.Data.Entities;
	using Data;
	using Microsoft.EntityFrameworkCore;

	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			using var context = new ApplicationDbContext();

			// Ex03.Run(context);

			// var track = new BaseRepository<Track>(context);

			Ex04.Run(context);
		}
	}

	internal class Ex01
	{
		public static void Run(ApplicationDbContext context)
		{
			// Todo
			// write a simple query to validate ApplicationDbContext
			var atendee = context.Attendees.FirstOrDefault();

			context.Tracks.Add(new Track
			{
				Name = "JS"
			});
			context.SaveChanges();
		}
	}

	internal class Ex02
	{
		public static void Run(ApplicationDbContext context)
		{
			// Todo
			// on Tracks table, add PHP, C# tracks with a seed
			// update ApplicationDbContext to run a seed

		}
	}

	internal class Ex03
	{
		public static void Run(ApplicationDbContext context)
		{
			// Todo
			// on Attendee model, add a new property, date of birth
			// add a migration, run the migration
			// insert then read a Attendee

			context.Attendees.Add(new Attendee
			{
				FirstName = "Daniel",
				LastName = "Burghelea",
				UserName = "danielburghelea",
				EmailAddress = "danielburghelea@webbeds.com",
				DateOfBirth = new DateTime(1992, 10, 19),
			});
			context.SaveChanges();
		}
	}

	internal class Ex04
	{
		public static void Run(ApplicationDbContext context)
		{
			var filteredSessions = context.Sessions.Where(s => s.Title.Contains(".NET")).ToList();

			foreach (var s in filteredSessions)
			{
				Console.WriteLine(s);
			}
		}
	}

	internal class Ex05
	{
		// todo
		// rename the Speaker.Name to Speaker.FullName
		// you should add a migration
	}

	internal class Ex06
	{
		public static void Run(ApplicationDbContext context)
		{
			// todo
			// all Sessions that title contains ".NET"
			Func<string, string> someFunction = s => s.ToLower();
			var sessions = context.Sessions.Where(s => s.Title.ToLower().Contains(".NET")).ToList();
			// var sessions2 = context.Sessions.Where(s => someFunction(s.Title).Contains(".NET")).ToList();
			// number of sessions for each speaker
			var session = context.SessionSpeaker
				.GroupBy(x => x.SpeakerId)
				.Select(x => new
				{
					Id = x.Key,
					Count = x.Count()
				})
				.ToList();
			// number of tracks per session
			// all tracks for each session
		}

		internal class Ex07
		{
			public static void Run(ApplicationDbContext context)
			{
				//var speakers = context.Speakers.ToList();
				// todo
				// get all sessions for one speaker
				var speakers = context.Speakers.Include(c => c.SessionSpeakers).ToList();
			}
		}

		internal class Ex08
		{
			public static void Run()
			{
				// todo
				// create a separate project for dapper
				// implement the ISpeakerRepository using dapper
			}
		}

		internal class Ex09
		{
			public static void Run()
			{
				// todo
				// create view
				/*
				   create view AllSessionsAndSpeakersView as
				   select ses.Title, sp.Name, ses.StartTime from Sessions ses
				   join SessionSpeaker ss on ses.Id = ss.SessionId
				   join Speakers sp on sp.Id = ss.SpeakerId
				*/

				// use the view from Dapper
				// display all information at console
			}
		}

		internal class Ex10
		{
			public static void Run()
			{
				// todo
				// use Dapper Plus
				// bulk insert 10 attendees
			}
		}
	}
}
