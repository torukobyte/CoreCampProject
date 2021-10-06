using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        private INewsLetterDal _letterDal;

        public NewsLetterManager(INewsLetterDal letterDal)
        {
            _letterDal = letterDal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _letterDal.Insert(newsLetter);
        }
    }
}