using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]// index ekleyebilmen için bunu hariçi oluşturdupun iççin area yı area  ismini vermen lazım 
    public class RezervationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        RezervationManager rezervationManager = new RezervationManager(new EfRezervationDal());

        private readonly UserManager<AppUser> _userManager;//sisteme otantik olan kişinin bilgisini almak için gerekli

        public RezervationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult MyCurrentRezervation()
        {
            return View();
        }

        public IActionResult MyOldRezervation()
        {
            return View();
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            //sisteme otantik olan kişinin bilgisini alıyoruz burda
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
          var valuesList=rezervationManager.GetListApprovalRezervation(values.Id);
            //   ViewBag.v = values.Id;//MyApprovalReservation sayfası yuklendiği zaman bana v isimindeki viewbag ı valuesten gelen id yi taşısın  
            return View(valuesList);
        }
        [HttpGet]
        public IActionResult NewRezervation()
        {
            // yeni rezervasyon işlemi dropdwn dan alacaz 
            List<SelectListItem> values = (from x in destinationManager.TGetList() //destinationManager bu nesne sayesinde ordaki listeye ulaştık bu listeyi x içine atadık
                                           select new SelectListItem // yeni öğe seç x atama yaptık yukarda 
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;// values değerleri viewbag view tarafına taşı
            return View();
        }
        [HttpPost]
        public IActionResult NewRezervation(Rezervation p)
        {
            p.AppUserId = 1;
            p.Status = "Onay Bekliyor";
            rezervationManager.TAdd(p);
            return RedirectToAction("MyCurrentRezervation");
        }
    }
}
