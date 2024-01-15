using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class ParentRepo : IRepo<Parent, int, bool>
    {
        ChildbirthregisterEntities1 db;
        internal ParentRepo()
        {
            db = new ChildbirthregisterEntities1();
        }
        public bool Add(Parent obj)
        {
            db.Parents.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ext = db.Parents.Find(id);
            db.Parents.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Parent> Get()
        {
            return db.Parents.ToList();
        }

        public Parent Get(int id)
        {
            return db.Parents.Find(id);
        }

        public bool Update(Parent obj)
        {
            var ext = Get(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
