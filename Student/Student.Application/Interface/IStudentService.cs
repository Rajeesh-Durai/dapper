using Student.Domain.DTO;
using Student.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Interface
{
    public interface IStudentService
    {
        Task<List<Students>> GetAllStudent();
        Task<string> PostStudents(AddStudentDTO addStudentDTO);
        Task<string> UpdateStudents(UpdateStudentDTO updateStudentDTO);
        Task<string> DeleteStudent(int id);
    }
}
