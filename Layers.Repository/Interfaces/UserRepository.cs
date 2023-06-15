﻿using Layers.Core.Models;
using Layers.Repository.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Layers.Repository.Interfaces
{
	public class UserRepository : ModelRepository<User>, IUserRepository
	{
		// AppDbContext Instance

		private readonly AppDbContext _appDbContext;

		// UserRepository Constructor

		public UserRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			_appDbContext = appDbContext;
		}

		// Sign In User

		public async Task<User> SignInAsync(User user) => await _appDbContext.Users.FirstOrDefaultAsync(x => x.UserName.Equals(user.UserName) && x.Password.Equals(x.Password));

		// Find User by UserName

		public async Task<User> FindByUserNameAsync(string userName) => await _appDbContext.Users.FirstOrDefaultAsync(x => x.UserName.Equals(userName));
	}
}
