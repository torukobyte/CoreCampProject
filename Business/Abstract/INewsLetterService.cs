using Entity.Concrete;

namespace Business.Abstract
{
    public interface INewsLetterService
    {
        void AddNewsLetter(NewsLetter newsLetter);
    }
}