using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI_s.Controllers
{
    using Models;
    using StudentAPI_s.Service;
    using System.Reflection.Metadata.Ecma335;

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(StudentService.Students);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = StudentService.Students.FirstOrDefault(s => s.Id == id);
            return student == null ? NotFound() : Ok(student);
        }

        // POST api/student
        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            // Generate a new ID
            student.Id = StudentService.Students.Count > 0
                ? StudentService.Students.Max(s => s.Id) + 1
                : 1;

            StudentService.Students.Add(student);

            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }


        // PUT api/student/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Student updatedStudent)
        {
            var student = StudentService.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            // Update fields (based on your schema)
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Department = updatedStudent.Department;

            return Ok(student);
        }


        // DELETE api/student/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = StudentService.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            StudentService.Students.Remove(student);

            return NoContent();
        }
    }
}
