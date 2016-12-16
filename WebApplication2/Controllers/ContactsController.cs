using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security;

namespace WebApplication2.Controllers
{
    public class ContactsController : Controller
    {
        //
        // GET: /Contacts/
        public ActionResult Index()
        {
            return View();
        }
	}
}