using CollegeApp.Filters;
using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    [MyActionFilterAttribute ("Student")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        [MyActionFilterAttribute("GetStudents")]
        [MyAsyncActionFilter("GetStudentsAsync")]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(CollegeRepository.Students); //Ok means success -  return type should be ActionResult
        }
        [HttpGet("{Id:int}")]
        public ActionResult<Student> GetStudentById(int Id)
        {
            if (Id < 0)
                return BadRequest(); //bad request 400 error

            var stu = CollegeRepository.Students.FirstOrDefault(s => s.Id == Id);
            if(stu == null)
                return NotFound($"student with Id {Id} not found");  // 404 not found
            else
            return Ok(stu); //200 success
        }
        [HttpGet("{Name:alpha}")]
        public Student GetStudentByName(string Name)
        {
            return CollegeRepository.Students.FirstOrDefault(s => s.Name == Name);
        }
        [HttpDelete("{Id:min(1):max(5)}")]
        public bool DeleteById(int Id)
        {
            var stu = CollegeRepository.Students.FirstOrDefault(s => s.Id == Id);
            CollegeRepository.Students.Remove(stu);
            return true;
        }
    }
}
