using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleServer.Models;

namespace SampleServer
{
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
       protected override void Seed(DatabaseContext context)
        {
           var Students = new List<StudentModel>
           {
               new StudentModel{Name ="Nilshan", Age = 21, School = "NSIS", ID = 1},
               new StudentModel{Name = "Steve", Age = 21, School = "NSIS", ID = 2},
               new StudentModel{Name = "Kevin", Age = 21, School = "NSIS", ID = 3}
           };

           Students.ForEach(s => context.StudentModel.Add(s));
           context.SaveChanges();
        }
    }
}