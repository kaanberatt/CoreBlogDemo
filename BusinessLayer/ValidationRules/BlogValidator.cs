using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("İsim alanı en az 5 karakter içermelidir.");
            RuleFor(x => x.BlogTitle).MaximumLength(70).WithMessage("İsim alanı en fazla 70 karakter içermelidir.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik alanı boş geçilemez.");
            RuleFor(x => x.BlogContent).MinimumLength(20).WithMessage("İçerik alanı en az 20 karakter içermelidir.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog fotoğrafı boş geçilemez");
        }
        
    }
}