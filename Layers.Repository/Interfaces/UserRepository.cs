using Layers.Core.Models;
using Layers.Repository.DataAccess;

namespace Layers.Repository.Interfaces
{
	public class UserRepository : ModelRepository<User>, IUserRepository
	{
		public UserRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
