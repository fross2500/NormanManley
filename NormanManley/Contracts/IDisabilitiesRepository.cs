using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Contracts
{
    public interface IDisabilitiesRepository: IRepositoryBase<Disabilities>
    {
        ICollection<Disabilities> GetStudentByDisabilities(int id);
    }
}
