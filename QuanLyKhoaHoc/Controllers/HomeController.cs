using QuanLyKhoaHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKhoaHoc.Controllers
{
    public class HomeController : Controller
    {
        VNR_InternShipEntities database = new VNR_InternShipEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FrontEnd()
        {
            return View(database.MonHocs.Where(s=>s.KhoaHocID == 1).ToList());
        }

        public ActionResult BackEnd()
        {
            return View(database.MonHocs.Where(s => s.KhoaHocID == 2).ToList());
        }

        public ActionResult DotnetCore()
        {
            return View(database.MonHocs.Where(s => s.KhoaHocID == 3).ToList());
        }
    }
}