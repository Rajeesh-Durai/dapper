using Microsoft.AspNetCore.Mvc;
using Student.Application.Interface;
using Student.Domain.DTO;

namespace Student.API.Controllers
{
    [Route("Student")]
    [ApiController]
    public class StudentController:ControllerBase
    {
        #region Constructor
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion
        #region Get all student details
        [HttpGet("GetAllStudentDetails")]
        public async Task<ActionResult<AddStudentDTO>> GetAllStudent()
        {
            try
            {
                var student = await _studentService.GetAllStudent();
                return Ok(student);
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine($"Error in getting the list of student details: {ex.Message}");
                return NotFound(ex.Message);
            }
        }
        #endregion
        #region Add new Student
        [HttpPost("AddNewStudent")]
        public async Task<IActionResult> AddStudent([FromBody] AddStudentDTO addStudentDTO)
        {
            try
            {
                var result = await _studentService.PostStudents(addStudentDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddStudent: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region Update existing student name
        [HttpPut("UpdateExistingStudentName")]
        public async Task<IActionResult> UpdateExistingStudentName([FromBody] UpdateStudentDTO updateStudentDTO)
        {
            try
            {
                var result = await _studentService.UpdateStudents(updateStudentDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateExistingStudentName: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
        #endregion
        #region Delete a student by passing an id
        [HttpDelete("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            try
            {
                var result = await _studentService.DeleteStudent(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteStudent: {ex.Message}");
                return NotFound();
            }
        }
        #endregion
    }
}
