using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tim2
{
    public class IgraciDal
    {
        public static List<Igraci> Procitaj()
        {
            List<Igraci> listIgraca = new List<Igraci>();

            using (SqlConnection konekcija=new SqlConnection(Konekcija.cnnTimDB))
            {
                using (SqlCommand komanda=new SqlCommand("SELECT * FROM Player",konekcija))
                {
                    try
                    {
                        konekcija.Open();
                        using (SqlDataReader dr=komanda.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Igraci igraci = new Igraci
                                {
                                    Id = dr.GetInt32(0),
                                    FirstName = dr.GetString(1),
                                    LastName = dr.GetString(2),
                                    Position = dr.GetInt32(3),
                                };
                                listIgraca.Add(igraci);
                            }
                        }
                        return listIgraca;
                    }
                    catch (Exception)
                    {

                        return null;
                    }
                }
            }
        }
    }
}
