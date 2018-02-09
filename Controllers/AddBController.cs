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
            string address = Request.Form["address"];
            Contact newContact = new Contact(name, phoneNumber, address);
            return View("Index", Contact.GetAll());
        }

        [HttpGet("/contact/{id}")]
        public ActionResult Details(int id)
        {
            Contact contact = Contact.GetById(id);
            if(contact != null)
            {
                return View(contact);
            } else
            {
                return View("Error, that Contact doesn't exist");
            }
        }

    }
}
