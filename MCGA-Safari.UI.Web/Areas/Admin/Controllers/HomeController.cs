﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCGA_Safari.UI.Web.Areas.Admin.Controllers
{
    
    public class HomeController : Controller
    {
        //private ILoggingService _loggingService;

        //public HomeController(ILoggingService loggingService)
        //{
        //    _loggingService = loggingService;
        //}


        // GET: Admin/Home
        public ActionResult Index()
        {
            //_loggingService.Log("message");
            return View();
        }
    }
}