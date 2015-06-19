using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Tracing;

namespace IronWebTest.Controllers
{
    public class IronController : ApiController
    {
        public List<string> Get()
        {
            Configuration.Services.GetTraceWriter().Info(Request, "Irons controller", "Asking for irons");
            return Enumerable.Range(0, 3).Select(i => Guid.NewGuid().ToString()).ToList();
        }

        public void Post([FromBody] object obj)
        {
            try
            {
                Configuration.Services.GetTraceWriter().Info(Request, "Irons controller", obj.ToString());
            }
            catch (Exception ex)
            {
                Configuration.Services.GetTraceWriter().Info(Request, "Irons controller", ex);
            }
        }
    }
}
