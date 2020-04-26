using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{
    public class studenttyperepository : IStudentRepository
    {
        private readonly ApplicationDbContext _db;

        public studenttyperepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(Student entity)
        {
            _db.Students.Add(entity);
            return Save();


        }

        public bool Delete(Student entity)
        {
            _db.Students.Remove(entity);
            return Save();

        }

        public ICollection<Student> FindAll()
        {
            return _db.Students.ToList();
        }

        public ICollection<Student> Findall()
        {
            throw new NotImplementedException();
        }

        public Student FindById(int id)
        {
            return _db.Students.Find(id);
        }

        public ICollection<Student> GetStudentByGrades(int id)
   
       
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Student entity)


        {
            _db.Students.Update(entity);
            return Save();
        }
    }
}
