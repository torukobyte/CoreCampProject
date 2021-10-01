using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş bırakılamaz!")
                .MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz!")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz!");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz!")
                .EmailAddress().WithMessage("Lütfen e-posta formatına uygun bir adres giriniz!");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz!")
                .Matches(@"[A-Z]+").WithMessage("Şifreniz en az 1 büyük harf içermelidir!")
                .Matches(@"[a-z]+").WithMessage("Şifreniz en az 1 küçük harf içermelidir!")
                .Matches(@"[0-9]+").WithMessage("Şifreniz en az 1 sayı içermelidir!")
                .Equal(x => x.AuthorConfirmPassword).WithMessage("test");
            RuleFor(x => x.AuthorConfirmPassword).NotEmpty().WithMessage("Şifre onay boş bırakılamaz!");
        }
    }
}