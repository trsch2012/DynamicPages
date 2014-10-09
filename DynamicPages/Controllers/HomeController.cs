using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DynamicPages.Code;
using DynamicPages.Code.PageSections;

namespace DynamicPages.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            Page page;
            if (Session["Page"] == null)
            {
                page = new Page();
                for (int i = 0; i < 10000; i++)
                {
                    page.PageSections.Add(
                            new KeyValuePair<string, IPageSection>(
                                    "FullWidthSection",
                                    PageSectionsFactory.GetPageSection("FullWidthSection")));
                }
                Session["Page"] = page;
            }
            else
            {
                page = (Page)Session["Page"];
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

