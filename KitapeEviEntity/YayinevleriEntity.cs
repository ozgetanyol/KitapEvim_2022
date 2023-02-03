using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviEntity
{
    public class YayinevleriEntity
    {
       
        public int yayineviID{ get; set; }
        public string yayineviAd { get; set; }
        public string yayineviAdres { get;set; }
        public int ulkeID { get; set; }
        public int sehirID { get; set; }
        public int ilceID { get; set; }
        public string yayineviTelefon { get; set; }
        public string  yayineviYetkiliAdSoyad { get; set; }
        public string yayineviEposta { get; set; }
        public bool yayineviAktifMi { get; set; }
        public string yayineviAciklama { get; set; }
        public string yayineviPostaKod { get; set; }

    }
}
