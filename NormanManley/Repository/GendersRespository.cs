using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{
    public class Genderstyperespository : IGendersRepository
    {

        private readonly ApplicationDbContext _db;


        public Genderstyperespository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Genders entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Genders entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Genders> Findall()
        {
            throw new NotImplementedException();
        }

        public Genders FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsExists(int id)
        {
            var exists = _db.Students.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public ICollection<Genders> StudentByGenders(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Genders entity)
        {
            throw new NotImplementedException();
        }
    }
}