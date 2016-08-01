using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
*@File Name: HomeController.cs
*@Author: Alex Nicholls
*@Student Number: 200287546
*@Site: Assignment2
*@Date: July 31, 2016
*@Description: This page controls the interactions between the home pages in the database, and views.  
*/

namespace Comp2007_Assignment2_Nicholls.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}