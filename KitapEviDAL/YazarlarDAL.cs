using KitapEviEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDAL
{
    public class YazarlarDAL
    {
        #region CRUD Operations

        //ID ye göre Yazar Getir (SELECT with ID)
        public YazarlarEntity getYazarlarwithID(int yazarID)
        {
            SqlParameter[] yazarlarParametreleri =
            {
                new SqlParameter {
                   ParameterName = "yazarID",
                   Value=yazarID

                },

            };


            SqlDataReader YazarlarRdr = KitapeviHelperSQL.myExecuteReader("yazarlarListesiwithIDsp", yazarlarParametreleri, "sp");

            YazarlarEntity myYazar = null;
            while (YazarlarRdr.Read())
            { 
                myYazar.yazarID = Convert.ToInt32(YazarlarRdr["yazarID"]);
                myYazar.yazarAdSoyad = YazarlarRdr["yazarAdSoyad"].ToString();
                myYazar.yazarAciklama = YazarlarRdr["yazarAciklama"].ToString();
                myYazar.ulkeID = Convert.ToInt32(YazarlarRdr["ulkeID"]);
                myYazar.cinsiyetID = Convert.ToInt32(YazarlarRdr["cinsiyetIID"]);
                myYazar.yazarAktifMi = Convert.ToBoolean(YazarlarRdr["yazarAktifMi"]);
            }

            return myYazar;

        }

        //Tüm Yazarlar Getir (SELECT ALL)
        public YazarlarEntity getYazarlarAll()
        {
            SqlDataReader YazarlarRdr = KitapeviHelperSQL.myExecuteReader("YazarlarListesiALLsp", null, "sp");

            YazarlarEntity myYazar = null;
            while (YazarlarRdr.Read())
            {
                myYazar.yazarID = Convert.ToInt32(YazarlarRdr["yazarID"]);
                myYazar.yazarAdSoyad = YazarlarRdr["yazarAdSoyad"].ToString();
                myYazar.yazarAciklama = YazarlarRdr["yazarAciklama"].ToString();
                myYazar.ulkeID = Convert.ToInt32(YazarlarRdr["ulkeID"]);
                myYazar.cinsiyetID = Convert.ToInt32(YazarlarRdr["cinsiyetIID"]);
                myYazar.yazarAktifMi = Convert.ToBoolean(YazarlarRdr["yazarAktifMi"]);
            }

            return myYazar;

        }

        //Yeni Yazar Verisi gir (INSERT)
        public int insertYazarlar(YazarlarEntity eklenecekYazar)
        {
            SqlParameter[] YazarlarParametreleri =
            {


                new SqlParameter
                {
                    ParameterName="yazarAdSoyad",
                    Value = eklenecekYazar.yazarAdSoyad
                },
                new SqlParameter
                {
                    ParameterName="yazarAciklama",
                    Value = eklenecekYazar.yazarAciklama
                },
                new SqlParameter
                {
                    ParameterName="ulkeID",
                    Value = eklenecekYazar.ulkeID
                },
                new SqlParameter
                {
                    ParameterName="cinsiyetIID",
                    Value = eklenecekYazar.cinsiyetID
                },
           
                new SqlParameter
                {
                    ParameterName="yazarAktifMi",
                    Value = eklenecekYazar.yazarAktifMi
                }

            };



            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("insertYazarSP", YazarlarParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var Olan Yazar Verisini ID sine göre bul DEĞİŞTİR (UPDATE)
        public int updateYazarlar(YazarlarEntity duzenlenecekYazar)
        {
            SqlParameter[] YazarlarParametreleri =
            {
                new SqlParameter {
                   ParameterName = "yazarID",
                   Value=duzenlenecekYazar.yazarID

                },
                new SqlParameter
                {
                    ParameterName="yazarAdSoyad",
                    Value = duzenlenecekYazar.yazarAdSoyad
                },
                new SqlParameter
                {
                    ParameterName="yazarAciklama",
                    Value = duzenlenecekYazar.yazarAciklama
                },
                new SqlParameter
                {
                    ParameterName="ulkeID",
                    Value = duzenlenecekYazar.ulkeID
                },
                new SqlParameter
                {
                    ParameterName="cinsiyetIID",
                    Value = duzenlenecekYazar.cinsiyetID
                },

                new SqlParameter
                {
                    ParameterName="yazarAktifMi",
                    Value = duzenlenecekYazar.yazarAktifMi
                }


            };



            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("updateYazarlarSP", YazarlarParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var olan Yazar Verisini ID sine göre SİL (DELETE)
        public int deleteYazarlar(YazarlarEntity silinecekYazar)
        {
            SqlParameter[] YazarlarParametreleri =
            {
                new SqlParameter {
                   ParameterName = "yazarID",
                   Value=silinecekYazar.yazarID

                }


            };

            int etkilenenSatir = KitapeviHelperSQL.myExecuteNonQuery("deleteYazarlarSP", YazarlarParametreleri, "sp");

            return etkilenenSatir;

        }
        #endregion

    }
}
