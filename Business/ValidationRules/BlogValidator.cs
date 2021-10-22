using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş bırakılamaz!")
                .MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapınız!")
                .MinimumLength(4).WithMessage("Lütfen 4 karakterden daha fazla veri girişi yapınız!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş bırakılamaz!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görseli boş bırakılamaz!");
        }
    }
}