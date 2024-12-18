using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACarFilterProject.DAL.Entities;
using RentACarFilterProject.Models;

namespace RentACarFilterProject.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public RegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(RegisterViewModel model)
		{
			var checkUser = await _userManager.FindByNameAsync(model.UserName);
			if (checkUser != null)
			{
				return View(model);
			}
			else
			{
				AppUser user = new AppUser()
				{
					UserName = model.UserName,
					Email = model.Email,
					Name = model.Name,
					Surname = model.Surname,
				};

				var register = await _userManager.CreateAsync(user, model.Password);
				if (register.Succeeded)
				{
					return RedirectToAction("Index", "Login");
				}
				else
				{
					return View(model);
				}

			}

		}
	}
}
