using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dev11_Net45_Mvc4_WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IQueryable<string> Get()
        {
            return new string[] { "Hello", "World" }.AsQueryable();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Hello World!";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}