﻿using System.Web;
using System.Web.Mvc;

namespace Jembo_Personal_Page
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}