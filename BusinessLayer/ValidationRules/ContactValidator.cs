using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactUserName).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.ContactUserName).MinimumLength(3).WithMessage("İsim alanı en az 3 karakter içermelidir.");
            RuleFor(x => x.ContactUserName).MaximumLength(50).WithMessage("İsim alanı en fazla 50 karakter içermelidir.");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez.");
            RuleFor(x => x.ContactSubject).NotEmpty().WithMessage("Konu Alanı Boş Geçilemez.");
            RuleFor(x => x.ContactSubject).MinimumLength(4).WithMessage("Konu Alanı en az 4 karakter içermelidir.");
            RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez.");
            RuleFor(x => x.ContactMail).MinimumLength(10).WithMessage("Mesaj Alanı en az 10 karakter içermelidir.");
        }
    }
}