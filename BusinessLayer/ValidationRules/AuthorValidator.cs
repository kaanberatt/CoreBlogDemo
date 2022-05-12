using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            //validations
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.AuthorName).MinimumLength(2).WithMessage("İsim alanı en az 2 karakter içermelidir.");
            RuleFor(x => x.AuthorName).MaximumLength(50).WithMessage("İsim alanı en fazla 50 karakter içermelidir.");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.AuthorPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az 1 tane büyük harf içermelidir.");
            RuleFor(x => x.AuthorPassword).Matches(@"[a-z]+").WithMessage("Şifre en az 1 tane küçük harf içermelidir.");
            RuleFor(x => x.AuthorPassword).Matches(@"[0-9]+").WithMessage("Şifre en az 1 tane numara içermelidir.(0-9)");
            RuleFor(x => x.AuthorPassword).Matches(@"[\!\?\*\.]+").WithMessage("Şifre en az 1 tane özel karakter içermelidir (!,?, *.).");
        }
    }
}