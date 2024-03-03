﻿using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Admin()
        {
            return View("~/Views/User/Admin.cshtml");
        }

        public IActionResult Technician()
        {
            return View("~/Views/User/Technician.cshtml");
        }
    }
}