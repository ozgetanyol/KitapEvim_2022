using KitapEviEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDAL
{
    public class KategorilerDAL
    {
        #region CRUD Operations

        //ID ye göre Kategori Getir (SELECT with ID)
        public KategorilerEntity getKategorilerwithID(int kategoriID)
        {
            SqlParameter[] kategorilerParametreleri =
            {
                new SqlParameter {
                   ParameterName = "kategoriID",
                   Value=kategoriID

                },

            };


            SqlDataReader kategorilerRdr = KitapeviHelperSQL.myExecuteReader("kategorilerListesiwithIDsp", kategorilerParametreleri, "sp");
           
            KategorilerEntity myKategori  = null;
            while (kategorilerRdr.Read())
            {
                myKategori.KategoriID = Convert.ToInt32(kategorilerRdr["kategoriID"]);
                myKategori.kategoriAd = kategorilerRdr["kategoriAd"].ToString();
                myKategori.kategoriAciklama = kategorilerRdr["kategoriAciklama"].ToString();
                myKategori.kategoriAktifMi = Convert.ToBoolean(kategorilerRdr["kategoriAktifMi"]);
            }

            return myKategori;

        }

        //Tüm Kategorileri Getir (SELECT ALL)
        public KategorilerEntity getKategorilerAll()
        {
           

            SqlDataReader kategorilerRdr = KitapeviHelperSQL.myExecuteReader("kategorilerListesiAllsp", null, "sp");

            KategorilerEntity myKategori = null;
            while (kategorilerRdr.Read())
            {
                myKategori.KategoriID = Convert.ToInt32(kategorilerRdr["kategoriID"]);
                myKategori.kategoriAd = kategorilerRdr["kategoriAd"].ToString();
                myKategori.kategoriAciklama = kategorilerRdr["kategoriAciklama"].ToString();
                myKategori.kategoriAktifMi = Convert.ToBoolean(kategorilerRdr["kategoriAktifMi"]);

            }

            return myKategori;

        }

        //Yeni Kategori Verisi gir (INSERT)
        public int insertKategoriler(KategorilerEntity eklenecekKategori)
        {
            SqlParameter[] kategorilerParametreleri =
            {


                new SqlParameter
                {
                    ParameterName="kategoriAd",
                    Value = eklenecekKategori.kategoriAd
                },
                new SqlParameter
                {
                    ParameterName="kategoriAciklama",
                    Value = eklenecekKategori.kategoriAciklama
                },
                new SqlParameter
                {
                    ParameterName="kategoriAktifMi",
                    Value = eklenecekKategori.kategoriAktifMi
                }
            };



            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("insertKategoriSP", kategorilerParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var Olan Kategori Verisini ID sine göre bul DEĞİŞTİR (UPDATE)
        public int updateKategoriler(KategorilerEntity duzenlenecekKategori)
        {
            SqlParameter[] kategorilerParametreleri =
            {
                 new SqlParameter {
                   ParameterName = "kategoriID",
                   Value=duzenlenecekKategori.KategoriID

                },

                new SqlParameter
                {
                    ParameterName="kategoriAd",
                    Value = duzenlenecekKategori.kategoriAd
                },
                new SqlParameter
                {
                    ParameterName="kategoriAciklama",
                    Value = duzenlenecekKategori.kategoriAciklama
                },
                new SqlParameter
                {
                    ParameterName="kategoriAktifMi",
                    Value = duzenlenecekKategori.kategoriAktifMi
                }
            };



            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("updateKategorilerSP", kategorilerParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var olan Kategori Verisini ID sine göre SİL (DELETE)
        public int deleteKitaplar(KategorilerEntity silinecekKategori)
        {
            SqlParameter[] kategorilerParametreleri =
            {
                new SqlParameter {
                   ParameterName = "KategoriID",
                   Value=silinecekKategori.KategoriID

                }


            };

            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("deleteKategorilerSP", kategorilerParametreleri, "sp");

            return etkilenenSatir;

        }
        #endregion

    }
}
