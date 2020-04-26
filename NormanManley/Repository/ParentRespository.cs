using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Repository
{

    public class parenttyperepository : IParentRepository
    {
        private readonly ApplicationDbContext _db;

        public parenttyperepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Parent entity)
        {
            _db.Parent.Add(entity);
            return Save();
        }

        public bool Delete(Parent entity)
        {
            _db.Parent.Remove(entity);
            return Save();
        }

        public ICollection<Parent> Findall()
        {
            return _db.Parent.ToList();
        }

        public Parent FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Parent entity)
        {
            _db.Parent.Update(entity);
            return Save();

        }
        
        
    }

}
