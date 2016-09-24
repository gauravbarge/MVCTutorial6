using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public actionresult index()
        //{
        //    return view();
        //}

        public ActionResult Index( )
        {
            //string name1 = Request.QueryString["name"];
            //return //"home controller index "+" id:" + identification + " name:" + name + " name1:" +name1;
            //"home controller index " + " id:" + identification + " secondid:" + secondid;
            this.ViewBag.Countries = new List<string>()
            { "India","USA","Canada","UK"};

            this.ViewData["Countries"] = this.ViewBag.Countries;

            return View("Index","_Layout");
        }


    }
}