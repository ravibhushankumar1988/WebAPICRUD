using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() {Id=1, Name="Ravi"},
            new Student() {Id=2, Name="Bhushan"},
            new Student() {Id=2, Name="Kumar"}
        };

        public IEnumerable<Student> Get()
        {
            return students;
        }

        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        [Route("api/students/{id}/courses")]
        public IEnumerable<string> GetStudentCourses(int id)
        {
            List<string> courseList = new List<string>();
            if (id == 1)
                courseList = new List<string>() { "asp.net", "c#.net" };
            else if (id == 2)
                courseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (id == 3)
                courseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                courseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
            return courseList;

        }

    }
}
