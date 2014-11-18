using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DynamicPages.Code;
using DynamicPages.Code.Pages;
using DynamicPages.Code.Widgets;

namespace DynamicPages.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            HomePage page;
            if (Session["Page"] == null)
            {
                page = new HomePage();
                for (int i = 0; i < 100; i++)
                {
                    page.PageWidgets.Add(
                            new KeyValuePair<string, IWidget>(
                                    "FullWidth",
                                    PageSectionsFactory.GetPageSection(WidgetType.FullWidthWidget)));
                }
                Session["Page"] = page;
            }
            else
            {
                page = (HomePage)Session["Page"];
            }

            return View(page.View, page);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

