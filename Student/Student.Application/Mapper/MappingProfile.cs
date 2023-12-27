using AutoMapper;
using Student.Domain.DTO;
using Student.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<AddStudentDTO, Students>();
            CreateMap<UpdateStudentDTO, Students>();
        }
    }
}
