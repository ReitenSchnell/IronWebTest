using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Http;

namespace IronWebTest.Controllers
{
    public class IronController : ApiController
    {
        public List<string> Get()
        {
            Trace.TraceInformation("Asking for irons");
            return Enumerable.Range(0, 3).Select(i => Guid.NewGuid().ToString()).ToList();
        }
    }
}
