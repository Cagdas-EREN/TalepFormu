using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcUI.Models
{
    public class Bilgiler
    {
        public IEnumerable<SelectListItem> Sehirler { get; set; }
        public IEnumerable<SelectListItem> ilceler { get; set; }
        public IEnumerable<SelectListItem> mahalleler { get; set; }
        public IEnumerable<SelectListItem> sokaklar { get; set; }
        public IEnumerable<SelectListItem> AbonelikTurleri { get; set; }
        public IEnumerable<SelectListItem> Meslek_Kodu { get; set; }
        public IEnumerable<SelectListItem> HaTNumaralari { get; set; }
    }
}
