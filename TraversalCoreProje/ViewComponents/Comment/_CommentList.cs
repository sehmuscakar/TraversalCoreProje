using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id) // bu invoke metotu view kısmında onu çağırıyor döndürüyor    @await Component.InvokeAsync("_CommentList")
        {
            var values = commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}
