using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetList();

        T GetById(int id);
    }
}