using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstAssign_n01666688.Controllers
{
    /// <summary>
    /// <param name="id">the input</param>
    /// <returns>
    /// GET localhost/api/NumberMachine/{id} for mathematical operations
    /// Addition:20, Multiply:100, Divide:1, Subtract:0
    /// </returns>
    /// <example>
    /// GET localhost/api/NumberMachine/{id}
    /// </example>
    /// </summary>


    public class NumberMachineController : ApiController
    {
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public string NumberMachine(int id)
        {
            int response1 = id + 10;
            int response2 = id * 10;
            int response3 = id / 10;
            int response4 = id - 10;
            
            string result = "Addition:"+ response1 + ", Multiply:" + response2 + ", Divide:" + response3 + ", Subtract:" + response4;
            return result;
            
         
        }
    }
}
