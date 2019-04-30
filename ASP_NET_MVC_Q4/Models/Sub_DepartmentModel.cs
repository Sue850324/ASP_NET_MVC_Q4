using System;
using System.Web;

namespace ASP_NET_MVC_Q4.Models
{
    public class Sub_DepartmentModel
    {
        public int ParentId { set; get; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
