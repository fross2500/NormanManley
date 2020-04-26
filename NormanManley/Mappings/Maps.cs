using AutoMapper;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Mappings
{
    public class Maps : Profile 
    {
        public Maps()
        {
            CreateMap<Student, DetailStudentVM>().ReverseMap();
            CreateMap<Student, CreateStudentVM>().ReverseMap();
            CreateMap<Payment, PaymentVM>().ReverseMap();
            CreateMap<Parent, ParentVM>().ReverseMap();


        }



    }
}
