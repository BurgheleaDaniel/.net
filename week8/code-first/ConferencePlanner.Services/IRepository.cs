using System.Threading.Tasks;

namespace ConferencePlanner.Services
{
	public interface IRepository<TEntity> where TEntity : class
	{
		void Get(int id);

		void Insert(TEntity entity);

		void Delete(TEntity entity);

	}
}
