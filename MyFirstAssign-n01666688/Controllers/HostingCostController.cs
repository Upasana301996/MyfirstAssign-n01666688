using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Schema;

namespace MyFirstAssign_n01666688.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// GET http://localhost/api/HostingCost/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// “1 fortnights at $5.50/FN = $5.50 CAD”
        /// “HST 13% = $0.72 CAD”
        /// “Total = $6.22 CAD”
        /// </returns>
        
        
        /// I faced so many problems in this but ome how i tried to do this i don't know if the code is right or wrong but want to learn the logic behind this
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public string HostingCost(int id)
        {
            const double costperfn = 5.50;
            int fornights = id / 14;
            double hsrate = 0.13;
            int fortnights = fornights + 1;// calculate fortnights 
            double baseCost = fortnights * costperfn;
            double hst = baseCost * hsrate;
            double totalCost = baseCost + hst;

            string result1 = fortnights + "fortnights at $5.40/FN = $" + costperfn + "CAD. ";
            string result2 = "HST 13% = $" + hst + "CAD. ";
            string result3 = "Total = $" + totalCost + "CAD.";
            return result1 + result2 + result3;
        }
    }
}
