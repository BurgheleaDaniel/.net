using System;
using System.Data.SqlClient;
using System.Linq;
using ConferencePlanner.Data.Entities;
using Dapper;

namespace DapperQueries
{
	class Program
	{
		static void Main(string[] args)
		{
			string sqlTracks = "SELECT * FROM Tracks;";

			using (var connection = new SqlConnection(@"data source=.\SQLExpress; database=ConferencePlanner; integrated security=SSPI"))
			{
				var orderDetails = connection.Query<Track>(sqlTracks).ToList();

				Console.WriteLine(orderDetails.Count);
			}
		}
	}
}
