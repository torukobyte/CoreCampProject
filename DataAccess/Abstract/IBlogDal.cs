using System.Collections.Generic;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListWithCategoryByAuthor(int id);
    }
}