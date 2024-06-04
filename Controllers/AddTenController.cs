using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{

    // <summary>
    // Adding 10 to the input number Param
    // </summary>
    // <param> name= ID </param>
    // <rerurns>
    // sum and sum= id param +10 or adding 10 to the input number
    // </rerurns>
    // <example>
    // GET : api/AddTen/21
    // http://localhost:57251/api/AddTen/21
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">31</int>
    // GET : api/AddTen/0
    // http://localhost:57251/api/AddTen/0
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</int>
    // GET : api/AddTen/-9
    // http://localhost:57251/api/AddTen/-9
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</int>
    // </example>

    public class AddTenController : ApiController
    {
        public int Get(int id) {

            int sum = id + 10;
            return sum;

        }
    }

}
