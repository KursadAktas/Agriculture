using Agriculture.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager; //DI

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); // kullanıcı adı
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.mail = values.Email;
            userEditViewModel.phone = values.PhoneNumber;
            return View(userEditViewModel);
           
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel formData)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); // kullanıcı adı

            if (formData.password == formData.confirmPassword)
            {
            values.Email = formData.mail;
            values.PhoneNumber = formData.phone;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values,formData.password);
                var result = await _userManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View(formData);
        }
        }
}
