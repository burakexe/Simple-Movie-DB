using MovieDBFirst_DAL;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MovieDBFirst_BLL.BaseRepository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private MovieDB db = new MovieDB();

        public void Add(T item)
        {
            db.Set(typeof(T)).Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = db.Set(typeof(T)).Find(id);
            db.Set(typeof(T)).Remove(delete);
            db.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public T SelectById(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }

        public void Update(T item)
        {
            db.Set<T>().AddOrUpdate(item);
            db.SaveChanges();
        }
    }
}