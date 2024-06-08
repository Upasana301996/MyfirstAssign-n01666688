using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstAssign_n01666688.Controllers
{
    
    /// <summary>
    /// Receives a number and returns a sum of number with addition of 10 
    /// <param name="id">the number to enter</param>
    /// <returns>
    /// sum wih AddTen/{id}
    /// </returns>
    /// <question>
    /// GET localhost/api/AddTen/{id}
    ///  GET localhost/AddTen/21
    /// GET localhost/AddTen/0
    /// GET localhost/AddTen/-9
    /// </question>
    /// </summary>
    public class AddtenController : ApiController
    {
        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
