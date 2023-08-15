using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team> //fluent validation için
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonelName).NotEmpty().WithMessage("Takım Arkadaşı İsmini Boş Geçemezsiniz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Alanını Boş Geçilemez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Alanı Boş Geçilemez.");
            RuleFor(x => x.PersonelName).MaximumLength(50).WithMessage("İsim alanı maximum 50 karakter olabilir.");
            RuleFor(x => x.PersonelName).MinimumLength(4).WithMessage("İsim alanı minimum 4 karakter olabilir.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Alan maximum 50 karakter olabilir.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Alan minimum 5 karakter olabilir.");
        }
    }
}
