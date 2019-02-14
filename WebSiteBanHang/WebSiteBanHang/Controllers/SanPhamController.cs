using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        public ActionResult SanPham1()
        {
            return View();
        }
        public ActionResult SanPham2()
        {
            return View();
        }
        public ActionResult SanPhamPartial()
        {
            return PartialView();
        }
	}
}