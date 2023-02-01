using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cadde
    {
        [Key]
        public int CaddeId { get; set; }
        public int MahalleId { get; set; }
        public string CaddeAdi { get; set; }

        //public List<KisiselBilgiler> KisiselBilgilers { get; set; }
    }
}
