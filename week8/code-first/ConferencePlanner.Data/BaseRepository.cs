using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConferencePlanner.Services;

namespace ConferencePlanner.Data
{

	public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		internal ApplicationDbContext context;

		public BaseRepository(ApplicationDbContext context)
		{
			this.context = context;
		}

		public void Get(int id)
		{
			// return context.Get
		}

		public void Delete(TEntity entity)
		{
			context.Remove(entity);
		}

		public void Insert(TEntity entity)
		{
			context.Update(entity);
		}
	}


}

