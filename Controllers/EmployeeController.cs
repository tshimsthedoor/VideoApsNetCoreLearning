using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoAsp.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
       
        
        public string Index()
        {
            return "Hello from Employee";
        }

        
        public ContentResult Name()
        {
            return Content("Jonas");
        }

       
        public string Country()
        {
            return "Sweden";
        }
        
    }
}
