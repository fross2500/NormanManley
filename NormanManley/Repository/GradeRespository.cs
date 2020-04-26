using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{
    public class gradestyperepository : IGradesRespository
    {
        private readonly ApplicationDbContext _db;

        public gradestyperepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Grade entity)
        {
            _db.Grades.Add(entity);
            return Save();
        }

        public bool Delete(Grade entity)
        {
            _db.Grades.Remove(entity);
            return Save();

        }

        public ICollection<Grade> Findall()
        {
            return _db.Grades.ToList();
        }

        public Grade FindById(int id)
        {
            return _db.Grades.Find(id);
        }

        public ICollection<Grade> GetStudentByGrades(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Grade entity)
        {
            _db.Grades.Update(entity);
            return Save();
        }
    }
}
