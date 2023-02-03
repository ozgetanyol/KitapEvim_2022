using KitapEviEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDAL
{
    public class KitaplarDAL
    {


        #region CRUD Operations

        //ID ye göre Kitap Getir (SELECT with ID)
        public KitaplarEntity getKitaplarwithID(int kitapID) 
        {
            SqlParameter[] kitaplarParametreleri =
            {
                new SqlParameter {
                   ParameterName = "kitapID",
                   Value=kitapID
                    
                },

            };


           SqlDataReader kitaplarRdr= KitapeviHelperSQL.myExecuteReader("kitaplarListesiwithIDsp", kitaplarParametreleri, "sp");

            KitaplarEntity myKitap = null;
            while (kitaplarRdr.Read())
            {
                myKitap.kitapID =Convert.ToInt32( kitaplarRdr["kitapID"]);
                myKitap.kitapAd = kitaplarRdr["kitapAd"].ToString();
                myKitap.kitapBasimYili =kitaplarRdr["kitapBasimYili"].ToString();
                myKitap.yayineviID= Convert.ToInt32(kitaplarRdr["yayineviID"]);
                myKitap.kitapFiyat = Convert.ToDecimal(kitaplarRdr["kitapFiyat"]);
                myKitap.kitapSayfaSayisi = Convert.ToInt32(kitaplarRdr["kitapSayfaSayisi"]);
                myKitap.kitapStokAdet = Convert.ToInt32(kitaplarRdr["kitapSayfaSayisi"]);
                myKitap.dilID = Convert.ToInt32(kitaplarRdr["dilID"]);
                myKitap.kitapAciklama = kitaplarRdr["kitapAciklama"].ToString();
                myKitap.kitapAktifMi = Convert.ToBoolean(kitaplarRdr["kitapAktifMi"]);
                myKitap.kitapKapakResmi = kitaplarRdr["kitapKapakResmi"].ToString();
                myKitap.kitapISBN = kitaplarRdr["kitapISBN"].ToString();

            }

            return myKitap;

        }

        //Tüm Kitapları Getir (SELECT ALL)
        public KitaplarEntity getKitaplarAll()
        {
            SqlDataReader kitaplarRdr = KitapeviHelperSQL.myExecuteReader("kitaplarListesiALLsp", null, "sp");

            KitaplarEntity myKitap = null;
            while (kitaplarRdr.Read())
            {
                myKitap.kitapID = Convert.ToInt32(kitaplarRdr["kitapID"]);
                myKitap.kitapAd = kitaplarRdr["kitapAd"].ToString();
                myKitap.kitapBasimYili = kitaplarRdr["kitapBasimYili"].ToString();
                myKitap.yayineviID = Convert.ToInt32(kitaplarRdr["yayineviID"]);
                myKitap.kitapFiyat = Convert.ToDecimal(kitaplarRdr["kitapFiyat"]);
                myKitap.kitapSayfaSayisi = Convert.ToInt32(kitaplarRdr["kitapSayfaSayisi"]);
                myKitap.kitapStokAdet = Convert.ToInt32(kitaplarRdr["kitapSayfaSayisi"]);
                myKitap.dilID = Convert.ToInt32(kitaplarRdr["dilID"]);
                myKitap.kitapAciklama = kitaplarRdr["kitapAciklama"].ToString();
                myKitap.kitapAktifMi = Convert.ToBoolean(kitaplarRdr["kitapAktifMi"]);
                myKitap.kitapKapakResmi = kitaplarRdr["kitapKapakResmi"].ToString();
                myKitap.kitapISBN = kitaplarRdr["kitapISBN"].ToString();

            }

            return myKitap;

        }
        
        //Yeni Kitap Verisi gir (INSERT)
        public int insertKitaplar(KitaplarEntity eklenecekKitap)
        {
            SqlParameter[] kitaplarParametreleri =
            {
               
              
                new SqlParameter
                {
                    ParameterName="kitapAd",
                    Value = eklenecekKitap.kitapAd
                },
                new SqlParameter
                {
                    ParameterName="kitapAciklama",
                    Value = eklenecekKitap.kitapAciklama
                },
                new SqlParameter
                {
                    ParameterName="kitapSayfaSayisi",
                    Value = eklenecekKitap.kitapSayfaSayisi
                },
                new SqlParameter
                {
                    ParameterName="yayineviID",
                    Value = eklenecekKitap.yayineviID
                },
                new SqlParameter
                {
                    ParameterName="kitapISBN",
                    Value = eklenecekKitap.kitapISBN
                },
                new SqlParameter
                {
                    ParameterName="kitapBasimYili",
                    Value = eklenecekKitap.kitapBasimYili
                },
                new SqlParameter
                {
                    ParameterName="kitapFiyat",
                    Value = eklenecekKitap.kitapFiyat
                },
                new SqlParameter
                {
                    ParameterName="kitapStokAdet",
                    Value = eklenecekKitap.kitapStokAdet
                },
                new SqlParameter
                {
                    ParameterName="dilID",
                    Value = eklenecekKitap.dilID
                },
                new SqlParameter
                {
                    ParameterName="kitapAktifMi",
                    Value = eklenecekKitap.kitapAktifMi
                },
                new SqlParameter
                {
                    ParameterName="kitapKapakResmi",
                    Value = eklenecekKitap.kitapKapakResmi
                }

            };



            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("insertKitapSP", kitaplarParametreleri, "sp");
            
            return etkilenenSatir;

        }

        //Var Olan Kitap Verisini ID sine göre bul DEĞİŞTİR (UPDATE)
        public int updateKitaplar(KitaplarEntity duzenlenecekKitap)
        {
            SqlParameter[] kitaplarParametreleri =
            { 
                new SqlParameter {
                   ParameterName = "kitapID",
                   Value=duzenlenecekKitap.kitapID

                },
                new SqlParameter
                {
                    ParameterName="kitapAd",
                    Value = duzenlenecekKitap.kitapAd
                },
                new SqlParameter
                {
                    ParameterName="kitapAciklama",
                    Value = duzenlenecekKitap.kitapAciklama
                },
                new SqlParameter
                {
                    ParameterName="kitapSayfaSayisi",
                    Value = duzenlenecekKitap.kitapSayfaSayisi
                },
                new SqlParameter
                {
                    ParameterName="yayineviID",
                    Value = duzenlenecekKitap.yayineviID
                },
                new SqlParameter
                {
                    ParameterName="kitapISBN",
                    Value = duzenlenecekKitap.kitapISBN
                },
                new SqlParameter
                {
                    ParameterName="kitapBasimYili",
                    Value = duzenlenecekKitap.kitapBasimYili
                },
                new SqlParameter
                {
                    ParameterName="kitapFiyat",
                    Value = duzenlenecekKitap.kitapFiyat
                },
                new SqlParameter
                {
                    ParameterName="kitapStokAdet",
                    Value = duzenlenecekKitap.kitapStokAdet
                },
                new SqlParameter
                {
                    ParameterName="dilID",
                    Value = duzenlenecekKitap.dilID
                },
                new SqlParameter
                {
                    ParameterName="kitapAktifMi",
                    Value = duzenlenecekKitap.kitapAktifMi
                },
                new SqlParameter
                {
                    ParameterName="kitapKapakResmi",
                    Value = duzenlenecekKitap.kitapKapakResmi
                }


            };



            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("updateKitaplarSP", kitaplarParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var olan Kitap Verisini ID sine göre SİL (DELETE)
        public int deleteKitaplar(KitaplarEntity silinecekKitap)
        {
            SqlParameter[] kitaplarParametreleri =
            {
                new SqlParameter {
                   ParameterName = "kitapID",
                   Value=silinecekKitap.kitapID

                }


            };

            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("deleteKitaplarSP", kitaplarParametreleri, "sp");

            return etkilenenSatir;

        }
        #endregion


    }
}
