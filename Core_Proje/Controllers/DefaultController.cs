using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessage(Message message)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());

            //Mesajın kaydedildiği andaki tarihi DB ye yansıtılsın.
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.Status = true; // Başlangıçta aktif olsun. Okuduktan sonra false a çekeceğiz.
            messageManager.TAdd(message);
            return PartialView();
        }
    }
}
