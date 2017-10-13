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
        DatabaseContext context = new DatabaseContext();
        // GET: api/Student
        public IEnumerable<StudentModel> Get()
        {
            return context.StudentModel.AsEnumerable();
           // return new string[] { "Nilshan", "Steve", "Yeshan" };
        }

        // GET: api/Student/5
        public StudentModel Get(int id)
        {
            return context.StudentModel.Find(id);
           // return new StudentModel { Name = "Nilshan", Age = 21, School = "Esoft" };
        }

        // POST: api/Student
        public void Post([FromBody]StudentModel value)
        {
            context.StudentModel.Add(value);
            context.SaveChanges();
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]StudentModel value)
        {
            StudentModel model = context.StudentModel.Find(id);
            context.Entry(model).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
            context.Entry(context.StudentModel.Find(id)).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
