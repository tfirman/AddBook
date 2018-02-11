using Microsoft.AspNetCore.Mvc;
using AddBook.Models;
using System;
using System.Collections.Generic;
namespace AddB.Controllers
{
    public class AddBController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(Contact.GetAll());
        }

        [HttpPost("/")]
        public ActionResult RemoveList()
        {
            Contact.DeleteList();
            return View("Index", Contact.GetAll());
        }
    }
}
