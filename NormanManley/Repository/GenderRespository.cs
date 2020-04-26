using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{
    public class genderstyperespository : IGendersRepository
    {
        private readonly ApplicationDbContext _db;

        public genderstyperespository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Grade entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Grade entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Grade> Findall()
        {
            throw new NotImplementedException();
        }

        public Grade FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Grade> GetStudentByGenders(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Grade entity)
        {
            throw new NotImplementedException();
        }
    }

        public bool Delete(Grade entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Grade> Findall()
        {
            throw new NotImplementedException();
        }

        public Grade FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Grade> GetStudentByGenders(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Grade entity)
        {
            throw new NotImplementedException();
        }
    }
}