using AutoMapper;
using Student.Application.Interface;
using Student.Domain.DTO;
using Student.Domain.Interface;
using Student.Domain.Models;

namespace Student.Application.Service
{
    public class StudentService:IStudentService
    {
        #region Constructor
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        #endregion
        #region Service layer for Get all Student details
        public async Task<List<Students>> GetAllStudent()
        {
            return await _studentRepository.GetStudents()?? throw new ArgumentNullException("The table is empty");     
        }
        #endregion
        #region Service layer for Add new Student
        public async Task<string> PostStudents(AddStudentDTO addStudentDTO)
        {
            var post=_mapper.Map<Students>(addStudentDTO);
            return await _studentRepository.AddStudents(post)?? throw new Exception("The Student detail is not posted");
        }
        #endregion
        #region Service layer for updating a student name
        public async Task<string> UpdateStudents(UpdateStudentDTO updateStudentDTO)
        {
            var update = _mapper.Map<Students>(updateStudentDTO);
            return await _studentRepository.UpdateStudent(update) ?? throw new Exception("The student name is not updated");
        }
        #endregion
        #region Service layer for Deleting a student by passing an id
        public async Task<string> DeleteStudent(int id)
        {
            return await _studentRepository.DeleteStudent(id) ?? throw new Exception("Student detail is not deleted");
        }
        #endregion
    }
}
