﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

           // first change

            return View();
        }

        public ActionResult  Index1()
        {
            // first change

            return View();
        }


        public ActionResult Clear() {
            return View();
        }
    }
}