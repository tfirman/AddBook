using Microsoft.AspNetCore.Mvc;
using AddBook.Models;
using System;
using System.Collections.Generic;
namespace AddB.Controllers
{
    public class NewController : Controller
    {
        [HttpGet("/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/new")]
        public ActionResult AddContact()
        {
            string name = Request.Form["name"];
            long phoneNumber = Int64.Parse(Request.Form["phone-number"]);
            string streetAddress = Request.Form["street-address"];
            string city = Request.Form["city"];
            string state = Request.Form["state"];
            int zipCode = Int32.Parse(Request.Form["zip-code"]);
            Contact newContact = new Contact(name, phoneNumber, streetAddress, city, state, zipCode);
            return View("~/Views/AddB/Index.cshtml", Contact.GetAll());
        }
    }
}
