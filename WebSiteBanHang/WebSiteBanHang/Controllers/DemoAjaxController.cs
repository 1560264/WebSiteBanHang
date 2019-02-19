using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteBanHang.Controllers
{
    public class DemoAjaxController : Controller
    {
        //
        // GET: /DemoAjax/
        public ActionResult DemoAjax()
        {
            return View();
        }
        public ActionResult LoadAjaxActionLink()
        {
            return Content("Hello Ajax");
        }
        public ActionResult LoadAjaxBeginForm(FormCollection f)
        {
            string KQ = f["txt1"].ToString();
            return Content(KQ);
        }
	}
}