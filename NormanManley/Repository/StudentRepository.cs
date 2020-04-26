using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{
    public class Studenttyperepository : IStudentRepository
    {
        private readonly ApplicationDbContext _db;

        public Studenttyperepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(Students entity)
        {
            _db.Students.Add(entity);
            return Save();


        }

        public bool Delete(Students entity)
        {
            _db.Students.Remove(entity);
            return Save();

        }

        
        public ICollection<Students> Findall()
        {
            return _db.Students.ToList();
        }

        public Students FindById(int id)
        {
            return _db.Students.Find(id);
        }

        public ICollection<Students> GetStudentByGrades(int id)
   
       
        {
            throw new NotImplementedException();
        }

        public bool IsExists(int id)
        {
            var exists = _db.Students.Any(q => q.Id ==id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Students entity)


        {
            _db.Students.Update(entity);
            return Save();
        }
    }
}
