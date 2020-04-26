using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{
    public class disabilitiestyperepository : IDisabilitiesRepository
    {

        private readonly ApplicationDbContext _db;

        public disabilitiestyperepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(Disabilities entity)
        {
            _db.Disabilities.Add(entity);
            return Save();

        }

        public bool Delete(Disabilities entity)
        {
            _db.Disabilities.Remove(entity);
            return Save();

        }

        public ICollection<Disabilities> Findall()
        {
            return _db.Disabilities.ToList();
        }

        public Disabilities FindById(int id)
        {
            return _db.Disabilities.Find(id);
        }

        public ICollection<Disabilities> GetStudentByDisabilities(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Disabilities> GetStudentByDisability(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Disabilities entity)
        {
            _db.Disabilities.Update(entity);
            return Save();
        }
    }
}
