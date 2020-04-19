using MvcTestTaskBars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MvcTestTaskBars.Controllers
{
    public class ReadJsonController : Controller
    {
        
        public ActionResult GetData()
        {
            string file = Server.MapPath("~/DataDb/users.json");
            
            string json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var userslist = ser.Deserialize<List<Users>>(json);
            

            
            return Json(userslist, JsonRequestBehavior.AllowGet);
        }
    }
}