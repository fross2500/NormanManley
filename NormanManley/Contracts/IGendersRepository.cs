using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Contracts
{
    public interface IGendersRepository:IRepositoryBase<Grade>
    {
        ICollection<Grade> GetStudentByGenders(int id);
    }
}
