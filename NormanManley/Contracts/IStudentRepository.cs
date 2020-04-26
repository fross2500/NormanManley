using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Contracts
{
    public interface IStudentRepository:IRepositoryBase<Students>
    {
      //  ICollection<Students> GetStudentByGrades(int id);
       // object Create(object student);
    }
}
