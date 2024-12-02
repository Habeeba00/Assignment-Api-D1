using Assignment_Api_D1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_Api_D1.Controllers
{
    [Route("api/Courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        static List<Courses>courses = new List<Courses>() 
        {
            new Courses(){Id=1,Name="C#",Duration=12},
            new Courses(){Id=2,Name="Java",Duration=22},
            new Courses(){Id=3,Name="CSS",Duration=8},
            new Courses(){Id=4,Name="Html",Duration=16}
        };

        [HttpGet]
        public List<Courses> GetAll()
        {
            return courses;
        }

        [HttpGet("{id}")]
        public Courses GetById(int id) 
        {
            return courses.Find(c=>c.Id==id);
        }

        [HttpPost]
        public List<Courses> Add(Courses c)
        { 
            courses.Add(c);
            return courses;
        }

    }
}
