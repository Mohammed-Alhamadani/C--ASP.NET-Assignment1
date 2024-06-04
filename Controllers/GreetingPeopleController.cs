using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    // <summary>
    // set the number of the people to be greeting
    // <summary>
    // <param> param name =id and this is the number of the people to be greeting </param>
    // <returns>
    // the greeting and the people number
    // </returns>
    // <example>
    // GET : api/GreetingPeople/3
    // http://localhost:57251/api/GreetingPeople/3
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Greeting to 3 people!</string>
    // GET : api/GreetingPeople/6
    // http://localhost:57251/api/GreetingPeople/6
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Greeting to 6 people!</string>
    // GET : api/GreetingPeople/0
    // http://localhost:57251/api/GreetingPeople/0
    // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Greeting to 0 people!</string>
    // <example>
    public class GreetingPeopleController : ApiController
    {
        public string Get(int id)
        {
            string message = "Greeting to " + id + " people!";
            return message;
        }
    }
}
