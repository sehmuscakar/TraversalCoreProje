using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        //etribüt oluştuman lazım arae yazman lazım ve area nın ismini yazman lazım
        [Area("Member")]// bunu yazmasan çalıştırdığın index çalışmaz büyle bir sayfa bulunamadı der
        //area ismini yaz sonra memberi yaz
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
