using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MeslekKodlari
    {
        [Key]
        public int MeslekId { get; set; }
        public string MeslekKodu { get; set; }
        public string MeslekAdi { get; set; }

        //public List<KisiselBilgiler> KisiselBilgilers { get; set; }
    }
}
