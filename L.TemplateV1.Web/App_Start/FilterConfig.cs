﻿using System.Web;
using System.Web.Mvc;

namespace L.TemplateV1.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}