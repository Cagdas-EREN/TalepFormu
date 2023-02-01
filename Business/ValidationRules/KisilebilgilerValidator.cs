using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class KisilebilgilerValidator : AbstractValidator<KisiselBilgiler>
    {
        public KisilebilgilerValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Kişi Adı Boşbırakılamaz");
            RuleFor(x => x.Ad).MinimumLength(3).WithMessage("En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Kişi Soyadı Boşbırakılamaz");
            RuleFor(x => x.Soyad).MinimumLength(3).WithMessage("En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.AnneAdi).NotEmpty().WithMessage("Anne Adı Boşbırakılamaz");
            RuleFor(x => x.AnneAdi).MinimumLength(3).WithMessage("En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.BabaAdi).NotEmpty().WithMessage("Baba Adı Boşbırakılamaz");
            RuleFor(x => x.BabaAdi).MinimumLength(3).WithMessage("En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.DogumTarihi).NotEmpty().WithMessage("Doğum Tarihi Boş Bırakılamaz");
            RuleFor(x => x.TCNO).NotEmpty().WithMessage("TC Kimlik Numarası Boş Bırakılamaz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Adresi Boş Bırakılamaz");
            RuleFor(x => x.GüvenlikKelimesi).NotEmpty().WithMessage("Güvenlik Kelimesi Boş Bırakılamaz");
            RuleFor(x => x.VergiDairesi).NotEmpty().WithMessage("Vergi Dairesi Boş Bırakılamaz");
            RuleFor(x => x.VergiNo).NotEmpty().WithMessage("Vergi Numarası Boş Bırakılamaz");
        }
    }
}
