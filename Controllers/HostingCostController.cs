using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    // <summary>
    // its like hotel check out so you are paying for 14 days if you didnt check out on day 14 you will go for another fortnight so will pay for 2 fotnight and her you can find the param for which day you are from the fortnight and will calculat it 
    // <summary>
    // <param> param name =id and this is the number which day from the fortnight </param>
    // <returns>
    // how many fortnight and bill details
    // </returns>
    // <example>
    // GET : api/HostingCost/0
    // http://localhost:57251/api/HostingCost/0
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1 fortnights at $5.50/FN = 5.5 $CAD HST 13% =0.715 $CAD Total = 6.215 $CAD</string>
    // GET : api/HostingCost/14
    // http://localhost:57251/api/HostingCost/14
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2 fortnights at $5.50/FN = 11 $CAD HST 13% =1.43 $CAD Total = 12.43 $CAD</string>
    // GET : api/HostingCost/15
    // http://localhost:57251/api/HostingCost/15
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2 fortnights at $5.50/FN = 11 $CAD HST 13% =1.43 $CAD Total = 12.43 $CAD</string>
    // GET : api/HostingCost/21
    // http://localhost:57251/api/HostingCost/21
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2 fortnights at $5.50/FN = 11 $CAD HST 13% =1.43 $CAD Total = 12.43 $CAD</string>
    // GET : api/HostingCost/28
    // http://localhost:57251/api/HostingCost/28
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">3 fortnights at $5.50/FN = 16.5 $CAD HST 13% =2.145 $CAD Total = 18.645 $CAD</string>
    // <example>

    public class HostingCostController : ApiController
    {
        [HttpGet]
        [Route("api/HostingCost/{id}")]

        public string HCost(int id) {
            int FortNight = (id/14)+1;
            double costFN = FortNight * 5.50;
            double HST =costFN* 0.13;
            double TotalCost=costFN + HST;
            string Output = FortNight + " fortnights at $5.50/FN = "+ costFN+" $CAD"+" HST 13% ="+HST+" $CAD"+ " Total = "+TotalCost+ " $CAD";
            return Output;
        }
    }
}
