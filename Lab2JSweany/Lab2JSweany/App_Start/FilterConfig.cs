﻿using System.Web;
using System.Web.Mvc;

namespace Lab2JSweany
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
