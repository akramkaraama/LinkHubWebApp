using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubUI.Areas.User.Controllers
{
    public class URLController : Controller
    {
        private UrlBs objBs;
        private CategoryBs objCatBs;
        private UserBs objUserBs;

        public URLController()
        {
            objBs = new UrlBs();
            objCatBs = new CategoryBs();
            objUserBs = new UserBs();
        }

        // GET: User/URL
        public ActionResult Index()
        {
            ViewBag.CategoryId = new SelectList(objCatBs.GetAll().ToList(), "CategoryId", "CategoryName");
            ViewBag.UserId = new SelectList(objUserBs.GetAll().ToList(), "UserId", "UserEmail");
            //LinkHubDbEntities db = new LinkHubDbEntities();
            //ViewBag.CategoryId = new SelectList(db.tbl_Category, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Url objUrl)
        {
            //LinkHubDbEntities db = new LinkHubDbEntities();
            //ViewBag.CategoryId = new SelectList(db.tbl_Category, "CategoryId", "CategoryName");
            return View();
        }
    }
}