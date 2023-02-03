using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviEntity
{
   public class CalisanlarEntity
    {

        public int calisanID { get; set; }
        public string calisanAd { get; set; }
        public string calisanSoyad { get; set; }
        public string calisanTelefon { get; set; }
        public string calisanTCKimlikNo { get; set; }
        public string calisanSgkNo { get; set; }
        public DateTime calisanIseBaslamaTarihi { get; set; }
        public DateTime calisanIstenAyrilmaTarihi { get; set; }
        public decimal calisanMaas { get; set; }
        public int unvanID { get; set; }
        public string calisanAdres { get; set; }
        public int ulkeID { get; set; }
        public int sehirID { get; set; }
        public int ilceID { get; set; }
        public bool calisanAktifMi { get; set; }
        public DateTime calisanDogumTarihi { get; set; }
        public string calisanIrtıbatNo { get; set; }
        public int cinsiyetID { get; set; }
        public string calisanAciklama { get; set; }
        public string calisanEposta { get; set; }
        public int calisanRaporCalisanID { get; set; }
    }
}
