using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IronWebTest.Controllers
{
    public class IronController : ApiController
    {
        public List<string> Get()
        {
            return Enumerable.Range(0, 3).Select(i => Guid.NewGuid().ToString()).ToList();
        }
    }
}
