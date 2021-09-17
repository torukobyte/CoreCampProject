using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        
        void Delete(T t);
        
        void Update(T t);
        
        List<T> GetListAll();
        
        T GetById(int id);
    }
}