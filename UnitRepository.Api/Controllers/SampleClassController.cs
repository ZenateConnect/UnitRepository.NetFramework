using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitRepository.Core.Abstract;
using UnitRepository.Domain.Concrete;
using UnitRepository.Model.Core;

namespace UnitRepository.Api.Controllers
{
    [Route("api/[controller]")]
    public class SampleClassController : ApiController
    {
        private readonly IUnitOfWork<AppDbContext> Work;

        public SampleClassController(IUnitOfWork<AppDbContext> work)
        {
            this.Work = work;
        }

        [HttpGet]
        public IEnumerable<SampleClass> GetAll()
        {
            List<SampleClass> listAll = new List<SampleClass>();
            try
            {
                listAll = Work.GetRepository<SampleClass>().GetAll.ToList();
            }
            catch (Exception)
            {
                // Write log here.
            }
            return listAll;
        }

        [HttpGet]
        public IEnumerable<SampleClass> Get(int id)
        {
            List<SampleClass> obj = new List<SampleClass>();
            try
            {
                obj = Work.GetRepository<SampleClass>().Get(a => a.Id == id).ToList();
            }
            catch (Exception)
            {
                // Write log here.
            }
            return obj;
        }

        [HttpPost]
        public SampleClass Insert([FromBody]SampleClass model)
        {
            try
            {
                SampleClass obj = new SampleClass
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    ModifiedBy = "System",
                    ModifiedDate = DateTime.Now
                };
                Work.GetRepository<SampleClass>().Insert(obj);
                Work.SaveChanges();

                model.Id = obj.Id;
            }
            catch (Exception)
            {
                // Write log here.
            }
            return model;
        }
    }
}
