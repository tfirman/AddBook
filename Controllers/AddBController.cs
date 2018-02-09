using Microsoft.AspNetCore.Mvc;
using AddBook.Models;
using System;
using System.Collections.Generic;
namespace AddBook.Controllers
{
    public class AddBController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(Contact.GetAll());
        }

    }
}
