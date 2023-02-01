using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Il
    {
        [Key]
        public int IlId { get; set; }
        public string plaka_kodu { get; set; }
        public string aciklama { get; set; }

        //public List<KisiselBilgiler> KisiselBilgilers { get; set; }

    }
}
