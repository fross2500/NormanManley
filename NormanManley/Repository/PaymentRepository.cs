using NormanManley.Contracts;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NormanManley.Repository
{
    public class paymenttyperepository : IPaymentRespository
    {
        private readonly ApplicationDbContext _db;

        public paymenttyperepository(ApplicationDbContext db)
        {

            _db = db;
        }
        public bool Create(Payment entity)
        {
            _db.Payments.Add(entity);
            return Save();
        }

        public bool Delete(Payment entity)
        {
            _db.Payments.Remove(entity);
            return Save();
        }

        public ICollection<Payment> FindAll()
        {
            return _db.Payments.ToList();
        }

        public ICollection<Payment> Findall()
        {
            throw new NotImplementedException();
        }

        public Payment FindById(int id)
        {
            return _db.Payments.Find(id);
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Payment entity)
        {
            _db.Payments.Update(entity);
            return Save();
        }
    }
}
    