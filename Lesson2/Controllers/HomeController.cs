using Lesson2.Api;
using Lesson2.Entities;
using Lesson2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World1";
        }

        public IActionResult Persons()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            var person = new ADDPersonViewModel(new Person());
            return View(person);
        }

        [HttpPost]

        public async  Task<IActionResult> AddPerson(ADDPersonViewModel vw)
        {
           if(ModelState.IsValid)
           {
                var result = await JsonWrite.WriteAsync(vw.Person);
                //var z = vw.Person;

                if (result)
                {
                    return  Redirect("/home/PersonList");
                }

           }
            return View();
        }

        public IActionResult PersonList()
        {
            var Data = JsonWrite.ReadAsync();
            var value = new PersonsListViewModel(Data);
            return View(value);
        }

        [HttpPost]

        public ActionResult ButtonClick()
        {
            return Redirect("/home/AddPerson");
        }
    }
}
