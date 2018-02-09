using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System;
using System.Collections.Generic;
namespace AddressBook.Controllers
{
    public class AddressBookController : Controller
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
            int phoneNumber = int.Parse(Request.Form["phone-number"]);
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
