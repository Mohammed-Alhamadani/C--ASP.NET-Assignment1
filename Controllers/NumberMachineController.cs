using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{

    // <summary>
    // Applying the four mathematical operations.
    // <summary>
    // <param> param name =id and this is the number that will do the operations with it </param>
    // <returns>
    // sum will return adding the same number to itself.
    // sub will return subtraction the same number.
    // multi will return multiplication the same number.
    // divide will return Division the same number.
    // </returns>

    // <example> For Number 10
    // GET : api/NumberMachine/divide/10
    // http://localhost:57251/api/NumberMachine/divide/10
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</int>
    // GET : api/NumberMachine/sum/10
    // http://localhost:57251/api/NumberMachine/sum/10
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">20</int>
    // GET : api/NumberMachine/multi/10
    // http://localhost:57251/api/NumberMachine/multi/10
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">100</int>
    // GET : api/NumberMachine/sub/10
    // http://localhost:57251/api/NumberMachine/sub/10
    // <int xmlns = "http://schemas.microsoft.com/2003/10/Serialization/" > 0 </ int >
    // <example>

    // <example> For Number -5
    // GET : api/NumberMachine/divide/-5
    // http://localhost:57251/api/NumberMachine/divide/-5
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</int>
    // GET : api/NumberMachine/sum/-5
    // http://localhost:57251/api/NumberMachine/sum/-5
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">-10</int>
    // GET : api/NumberMachine/multi/-5
    // http://localhost:57251/api/NumberMachine/multi/-5
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">25</int>
    // GET : api/NumberMachine/sub/-5
    // http://localhost:57251/api/NumberMachine/sub/-5
    // <int xmlns = "http://schemas.microsoft.com/2003/10/Serialization/" > 0 </ int >
    // <example>

    // <example> For Number 30
    // GET : api/NumberMachine/divide/30
    // http://localhost:57251/api/NumberMachine/divide/30
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</int>
    // GET : api/NumberMachine/sum/30
    // http://localhost:57251/api/NumberMachine/sum/30
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">60</int>
    // GET : api/NumberMachine/multi/30
    // http://localhost:57251/api/NumberMachine/multi/30
    // <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">900</int>
    // GET : api/NumberMachine/sub/30
    // http://localhost:57251/api/NumberMachine/sub/30
    // <int xmlns = "http://schemas.microsoft.com/2003/10/Serialization/" > 0 </ int >
    // <example>
    public class NumberMachineController : ApiController
    {
        [HttpGet]
        [Route("api/NumberMachine/Sum/{id}")]

        public int Sum(int id)
        {
            int result = (id+id);

            return result;
            
        }

        [HttpGet]
        [Route("api/NumberMachine/Sub/{id}")]

        public int Sub(int id)
        {
            int result = (id - id);

            return result;

        }

        [HttpGet]
        [Route("api/NumberMachine/Multi/{id}")]

        public int Multi(int id)
        {
            int result = (id * id);

            return result;

        }

        [HttpGet]
        [Route("api/NumberMachine/Divide/{id}")]

        public int Divide(int id)
        {
            int result = (id / id);

            return result;

        }



    }
}
