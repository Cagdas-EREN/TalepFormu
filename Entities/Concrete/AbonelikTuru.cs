using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AbonelikTuru
    {
        [Key]
        public int AboneTurId { get; set; }
        public string AboneTuru { get; set; }

        //public List<KisiselBilgiler> KisiselBilgilers { get; set; } 
    }
}
