using System.Collections.Generic;
using System.Web.Http;
using WebApiexample.Models;

namespace WebApiexample.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            EmployeeDB ob = new EmployeeDB();
            return ob.ExcecuteDbMethodList();
        }
    }
}
