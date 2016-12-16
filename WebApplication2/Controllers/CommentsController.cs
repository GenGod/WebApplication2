using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CommentsController : Controller
    {
        //
        // GET: /Comments/
        public ActionResult Index()
        {
            return View(WorkingWithComments.readComments());
        }

        //
        // GET: /Comments/AddComment
        public ActionResult AddComment()
        {
            Comment comment = new Comment(Request.Form["userName"].ToString(), 
                                          Request.Form["userEmail"].ToString(), 
                                          Request.Form["comment"].ToString());
            return View(WorkingWithComments.addComment(comment));
        }
	}
}