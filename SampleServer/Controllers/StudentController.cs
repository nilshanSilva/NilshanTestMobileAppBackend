using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleServer.Models;

namespace SampleServer.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<string> Get()
        {
            
            return new string[] { "Nilshan", "Steve", "Yeshan" };
        }

        // GET: api/Student/5
        public StudentModel Get(int id)
        {
            DatabaseContext context = new DatabaseContext();
            return context.StudentModel.Find(id);
           // return new StudentModel { Name = "Nilshan", Age = 21, School = "Esoft" };
        }

        // POST: api/Student
        public void Post([FromBody]StudentModel value)
        {
            DatabaseContext context = new DatabaseContext();
            context.StudentModel.Add(value);
            context.SaveChanges();
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }//
    }
}
