using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Mahalle
    {
        [Key]
        public int MahalleId { get; set; }
        public int IlceId { get; set; }
        public string MahalleAdi { get; set; }

        //public List<KisiselBilgiler> KisiselBilgilers { get; set; }
    }
}
