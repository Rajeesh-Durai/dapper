using Student.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Domain.Models;
namespace Student.Domain.Interface
{
    public interface IStudentRepository
    {
        Task<List<Students>> GetStudents();
        Task<string> AddStudents(Students student);
        Task<string> UpdateStudent(Students student);
        Task<string> DeleteStudent(int id);
    }
}
