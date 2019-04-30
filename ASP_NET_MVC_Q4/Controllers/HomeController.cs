using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q4.Models;
using System.Data;


namespace ASP_NET_MVC_Q4.Controllers
{
    public class HomeController : Controller
    {
        public object departments()
        {
            string filepath = Server.MapPath("~/App_Data/department.json");
            string json = System.IO.File.ReadAllText(filepath);
            List<DepartmentModel> list = JsonConvert.DeserializeObject<List<DepartmentModel>>(json);
            List<SelectListItem> departmentlist = new List<SelectListItem>();
            foreach (var item in list)
            {
                departmentlist.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            return ViewData["department"] = departmentlist;
        }
        public List<Sub_DepartmentModel> subdepartment()
        {
            string filepath2 = Server.MapPath("~/App_Data/sub_department.json");
            string json2 = System.IO.File.ReadAllText(filepath2);
            List<Sub_DepartmentModel> list2 = JsonConvert.DeserializeObject<List<Sub_DepartmentModel>>(json2);

            return list2;
        }

        public ActionResult Index()
        {
            departments();
            return View();
        }

        public ActionResult GetEmployee(int id)
        {

            return Json(subdepartment().Where(x => x.ParentId == id), JsonRequestBehavior.AllowGet); ;
        }
    }
}