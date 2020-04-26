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
            CreateMap<Students, StudentVM>().ReverseMap();
           
            CreateMap<Parent, ParentVM>().ReverseMap();


        }



    }
}
