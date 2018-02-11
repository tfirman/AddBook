using Microsoft.AspNetCore.Mvc;
using AddBook.Models;
using System;
using System.Collections.Generic;
namespace AddB.Controllers
{
    public class DetailsController : Controller
    {
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

        [HttpPost("/contact/{id}")]
        public ActionResult Delete(int id)
        {
            Contact contact = Contact.GetById(id);
            if(contact != null)
            {
                Contact.RemoveById(id);
            }
            return View("~/Views/AddB/Index.cshtml", Contact.GetAll());
        }
    }
}
