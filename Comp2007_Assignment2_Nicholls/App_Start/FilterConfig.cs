﻿using System.Web;
using System.Web.Mvc;

namespace Comp2007_Assignment2_Nicholls
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
