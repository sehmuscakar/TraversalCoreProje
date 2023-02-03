using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;//UserManager kütüphaneden geliyor identity core kütüphanesi appuser da concrete den geliyor

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);//isme göre arama yapacak ve valuese atacak 
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;
            return View(userEditViewModel);// userEditViewModel buraya atadığımız değerleri çağırıyoruz
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)//image boş değilse 
            {
                var resource = Directory.GetCurrentDirectory();//sistem ıo ya ait bazı komutlar,aktif ile ilgili
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;// resmin kaydedileceği konum
                var stream = new FileStream(savelocation, FileMode.Create);//kaydedileceği yer vedosya modu oluşturma 
                await p.Image.CopyToAsync(stream);//akıştan gelen değere kopyala 
                user.ImageUrl = imagename;//sisteme otantik olan kişinin atamasını yap imagename ismini
            }
            //güncelenecek değerler 
            user.Name = p.name;
            user.Surname = p.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SingIn", "Login");
            }
            return View();
        }
    }
}
