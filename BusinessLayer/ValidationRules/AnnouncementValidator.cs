using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement> //fluent validation için
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(" Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title Alanı Boş Geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Maximum 50 karakter olabilir.");
            RuleFor(x => x.Description).MinimumLength(4).WithMessage("Minimum 4 karakter olabilir.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Alan maximum 50 karakter olabilir.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Alan minimum 5 karakter olabilir.");
        }
    }
}
