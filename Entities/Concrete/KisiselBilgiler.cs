using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class KisiselBilgiler
    {
        [Key]
        public int BilgilerId { get; set; }
        public int NumaraId { get; set; }
        public int AboneTurId { get; set; }
        public int CaddeId { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int MahalleId { get; set; }
        public int MeslekId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public string TCNO { get; set; }
        public string KimlikSeriNo { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string GüvenlikKelimesi { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DogumTarihi { get; set; }
        public string FirmaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string IcKapiNo { get; set; }
        public string DisKapiNo { get; set; }

        
    }
}
