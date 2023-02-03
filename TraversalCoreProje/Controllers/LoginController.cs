using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;// sisteme otantik olmak için 

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()//kayıt olmak için Kallanılacak 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)//kayıt olmak için Kallanılacak ,burda identity işlemler yapılacaksa burası asekronik olması lazım 
        {
            AppUser appUser = new AppUser()
            {
                Name=p.Name,
                Surname=p.Surname,
                Email=p.Mail,
                UserName=p.Username
            };

            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);//birinci paremtre  key değeri 
                    }
                }
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);//await kulanman için task async de fonksiyonda yazman lazım ,false anlamı şifre hatırlanmasın,true anlamı şifre 5 defa yanlış girilirse kilitlensin veritabanında 
                if (result.Succeeded) //kullanıcı adı ve şifre doğru bi şekilde karşılanırsa
                {
                    return RedirectToAction("Index", "Profile",new {area="Member" });// bu kısım ıu katmanın içinden ama parçalandığı için yolu vermen lazım ki buraya yönlendirsin 
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            
            }

            return View();
        }
    }
}
