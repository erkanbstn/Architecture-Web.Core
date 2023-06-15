﻿using Layers.Dto.Dtos.UserDto;
using Layers.Service.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LayersArchitecture.Core.Controllers
{
	[AllowAnonymous]
	public class AuthController : Controller
	{
		// User Manager Instance

		private readonly IUserService _userService;

		// Auth Constructor

		public AuthController(IUserService userService)
		{
			_userService = userService;
		}

		// GET Sign Up Page
		public IActionResult SignUp()
		{
			return View();
		}

		// POST Sign Up Page
		[HttpPost]
		public async Task<IActionResult> SignUp(int id)
		{
			return View();
		}

		// GET Sign In Page
		public IActionResult SignIn()
		{
			return View();
		}

		// POST Sign In Page
		[HttpPost]
		public async Task<IActionResult> SignIn(UserLoginDto userLoginDto)
		{
			await HttpContext.SignInAsync(await _userService.SignInWithClaimAsync(new() { UserName = userLoginDto.UserName, Password = userLoginDto.Password }));
			return Redirect("~/Admin/Dashboard/Index");
		}

		// GET Sign Up Page
		public async Task<IActionResult> SignOut()
		{
			await HttpContext.SignOutAsync();
			return RedirectToAction("Index", "Main");
		}

		// Error Page
		public IActionResult Error()
		{
			return View();
		}
	}
}
