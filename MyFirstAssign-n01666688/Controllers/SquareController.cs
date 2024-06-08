using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstAssign_n01666688.Controllers
{
    public class SquareController : ApiController
    {
        // GET localhost/api/Square/{id}

        // GET localhost/Square/2
        // GET localhost/Square/-2
        // GET localhost/Square/10

        public int Get (int id) 
        {
            int result = id * id;
            return result;

        }
    }
}
