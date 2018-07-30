using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVC_Application.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            var s = new Ticket() { Location = "deepika", MyProperty = "deepika" };
            return View(s);
        }
        public string Index2()
        {
            return "hello";
        }
    }
}