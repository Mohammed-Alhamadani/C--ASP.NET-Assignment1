using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    // <summary>
    // square the input number as multiply by iteself.
    // <summary>
    // <param> param name =id </param>
    // <returns>
    // the square of the input number.
    // </returns>
    // <example>
    // GET : api/square/2
    // http://localhost:57251/api/square/2
    // <int xmlns = "http://schemas.microsoft.com/2003/10/Serialization/" > 4 </ int >
    // GET : api/square/-2
    // http://localhost:57251/api/square/-2
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</int>
    // GET : api/square/10
    // http://localhost:57251/api/square/10
    // <int xmlns = "http://schemas.microsoft.com/2003/10/Serialization/" > 100 </ int >
    // <example>
    public class SquareController : ApiController
    {

        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
