﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace miaPaginaWeb.Controllers
{
    public class StudentiController : Controller
    {
        public IActionResult ListStudenti()
        {
            return View();
        }
    }
}