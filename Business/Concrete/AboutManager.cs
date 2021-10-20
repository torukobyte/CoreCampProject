using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(About t)
        {
            throw new System.NotImplementedException();
        }

        public void Update(About t)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }

        public About GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}