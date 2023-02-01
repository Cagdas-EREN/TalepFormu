using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ilce
    {
        [Key]
        public int IlceId { get; set; }
        public string IlceAdi { get; set; }

        public int IlId { get; set; }

        //public List<KisiselBilgiler> KisiselBilgilers { get; set; }
    }
}
