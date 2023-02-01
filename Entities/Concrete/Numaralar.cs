using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Numaralar
    {
        [Key]
        public int NumaraId { get; set; }
        public string NumaraNo { get; set; }
        public string ozelnumara { get; set; }
        public string tahsisedildi { get; set; }

        //public List<KisiselBilgiler> KisiselBilgilers { get; set; }
    }
}
