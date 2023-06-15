using Layers.Core.Models;
using Layers.Repository.DataAccess;
using Layers.Service.Services;
using System.Linq.Expressions;

namespace Layers.Service.Managers
{
	public class UserManager : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserManager(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task ChangeStatusAllAsync(List<User> t)
		{
			await _userRepository.ChangeStatusAllAsync(t);
		}

		public async Task ChangeStatusAsync(User t)
		{
			await _userRepository.ChangeStatusAsync(t);
		}

		public async Task DeleteAllAsync(List<User> t)
		{
			await _userRepository.DeleteAllAsync(t);
		}

		public async Task DeleteAsync(User t)
		{
			await _userRepository.DeleteAsync(t);
		}

		public async Task<User> GetByIdAsync(int id)
		{
			return await _userRepository.GetByIdAsync(id);
		}

		public async Task InsertAsync(User t)
		{
			await _userRepository.InsertAsync(t);
		}

		public async Task<List<User>> ToListAsync()
		{
			return await _userRepository.ToListAsync();
		}

		public async Task<List<User>> ToListByFilterAsync(Expression<Func<User, bool>> filter)
		{
			return await _userRepository.ToListByFilterAsync(filter);
		}

		public async Task UpdateAsync(User t)
		{
			await _userRepository.UpdateAsync(t);
		}
	}
}
