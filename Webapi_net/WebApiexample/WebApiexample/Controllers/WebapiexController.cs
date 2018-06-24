using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiexample.Models;

namespace WebApiexample.Controllers
{
    public class WebapiexController : ApiController
    {
        public Cmodel post()
        {
            Cmodeldb obj=new Cmodeldb();
            return obj.ExcecuteDbMethod();
        }

    }
}
