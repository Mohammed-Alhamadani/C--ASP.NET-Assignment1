using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers

// <summary>
// Returning a string with "Hello World!" as a POST Request
// </summary>
// <rerurns>
// a string with "Hello World!"
// </rerurns>
// <example>
// POST : api/greeting
// curl -d "" http://localhost:57251/api/Greeting
// </example>
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            
            return "Hello World!";
        }
    }
}
