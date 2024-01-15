using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class CityCorporationRepo : IRepo<City_corporation, int, bool>
    {
        ChildbirthregisterEntities1 db;
        internal CityCorporationRepo()
        {

            db = new ChildbirthregisterEntities1();
        }

        public bool Add(City_corporation obj)
        {
            db.City_corporation.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ext = db.City_corporation.Find(id);
            db.City_corporation.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<City_corporation> Get()
        {
            return db.City_corporation.ToList();
        }

        public City_corporation Get(int id)
        {
            return db.City_corporation.Find(id);
        }

        public bool Update(City_corporation obj)
        {
            var ext = Get(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;

        }
    }
}
