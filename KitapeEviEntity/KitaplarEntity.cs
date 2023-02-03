using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviEntity
{
    public class KitaplarEntity
    {
       
        public int kitapID { get; set; }
        public string kitapAd { get; set; }
        public string kitapBasimYili { get; set; }
        public int yayineviID { get; set; }
        public decimal kitapFiyat { get; set; }
        public int kitapSayfaSayisi { get; set; }
        public int kitapStokAdet { get; set; }
        public int dilID { get; set; }
        public string kitapAciklama { get; set; }
        public bool kitapAktifMi { get; set; }
        public string kitapKapakResmi { get; set; }
        public string kitapISBN { get; set; }

    }
}
