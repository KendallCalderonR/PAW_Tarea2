﻿using System.Web;
using System.Web.Mvc;

namespace PAW.Tarea2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
