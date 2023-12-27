using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Domain.DTO
{
    public class AddStudentDTO
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
    }
}
