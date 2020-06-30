using System.Collections.Generic;

namespace MovieDBFirst_BLL.BaseRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);

        void Update(T item);

        void Delete(int id);

        List<T> SelectAll();

        T SelectById(int id);
    }
}