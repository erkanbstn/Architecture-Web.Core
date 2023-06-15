using Layers.Core.Models;
using Layers.Repository.Interfaces;

namespace Layers.Repository.DataAccess
{
	public interface IUserRepository : IModelRepository<User>
	{
		// Sign In User

		Task<User> SignInAsync(User user);

		// Find User by UserName
		Task<User> FindByUserNameAsync(string userName);

	}
}
