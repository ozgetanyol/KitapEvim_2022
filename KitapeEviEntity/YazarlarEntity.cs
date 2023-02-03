using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviEntity
{
    public class YazarlarEntity
    {
       
        public int yazarID { get; set; }
        public string yazarAdSoyad { get; set; }
        public int ulkeID { get; set; }
        public int cinsiyetID { get; set; }
        public bool yazarAktifMi { get; set; }
        public string yazarAciklama { get; set; }

    }
}
