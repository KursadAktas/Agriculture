using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdressValidator : AbstractValidator<Adress>
    {
        public AdressValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez.");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama Boş Geçilemez.");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama Boş Geçilemez.");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama Boş Geçilemez.");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita Boş Geçilemez.");
            RuleFor(x => x.Description).MaximumLength(35).WithMessage("Lütfen Açıklamayı Kısaltın.");
            RuleFor(x => x.Description2).MaximumLength(35).WithMessage("Lütfen Açıklamayı Kısaltın.");
            RuleFor(x => x.Description3).MaximumLength(35).WithMessage("Lütfen Açıklamayı Kısaltın.");
            RuleFor(x => x.Description4).MaximumLength(35).WithMessage("Lütfen Açıklamayı Kısaltın.");
        }
    }
}
