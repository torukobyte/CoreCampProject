using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {

        List<Blog> GetBlogListWithCategory();

        List<Blog> GetBlogByAuthor(int id);
    }
}