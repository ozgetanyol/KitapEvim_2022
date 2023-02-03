using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviEntity
{
    public class KategorilerEntity
    {
        public int KategoriID { get; set; }
        public string kategoriAd { get; set; }
        public string kategoriAciklama { get; set; }
        public bool kategoriAktifMi { get; set; }

    }

}
