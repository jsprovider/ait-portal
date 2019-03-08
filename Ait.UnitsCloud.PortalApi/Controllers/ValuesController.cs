using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ait.UnitsCloud.PortalApi.Data.Models;
using Ait.UnitsCloud.PortalApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ait.UnitsCloud.PortalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //PortalContext _ctx = null;
        IPortalUnitOfWork _portalUnitOfWork = null;
        public ValuesController(IPortalUnitOfWork  poralUnitOfWork)
        {
            _portalUnitOfWork = poralUnitOfWork;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<object>> Get()
        {
            //CompanyRepository rep = new CompanyRepository( ()=>  new PortalContext());

            return _portalUnitOfWork.CompanyRepository.GetAll().Select(r=> new{
                CompanyName = r.Name1,
                Code = r.Code 
            }).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
