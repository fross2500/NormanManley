using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{
    public class Gradestyperepository : IGradesRespository
    {
        private readonly ApplicationDbContext _db;

        public Gradestyperepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Grades entity)
        {
            _db.Grades.Add(entity);
            return Save();
        }

        public bool Delete(Grades entity)
        {
            _db.Grades.Remove(entity);
            return Save();

        }

        public ICollection<Grades> Findall()
        {
            return _db.Grades.ToList();
        }

        public Grades FindById(int id)
        {
            return _db.Grades.Find(id);
        }

        public ICollection<Grades> GetStudentByGrades(int id)
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
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Grades entity)
        {
            _db.Grades.Update(entity);
            return Save();
        }
    }
}
