using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tim2
{
    public partial class Dodavanje : Form
    {
        private int Id;
        public Dodavanje()
        {
            InitializeComponent();
        }
        public int IgracId
        {
            get { return Id; }
            set { Id = value; }
        }
        public void SetValues(string firstName,string lastName,string position)
        {
            txbIme.Text = firstName;
            txbPrezime.Text = lastName;
            txbPozicija.Text = position;
        }

        public string kom;
        public void KomDodaj()
        {
             kom = "INSERT INTO Player (FirstName, LastName, Position) VALUES (@FirstName, @LastName, @Position); SELECT @Id=SCOPE_IDENTITY();";
        }
        public void KomIzmeni()
        {
            kom = "UPDATE Player SET FirstName = @FirstName, LastName = @LastName, Position = @Position WHERE Id = @Id";
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            using (SqlConnection konekcija=new SqlConnection(Konekcija.cnnTimDB))
            {
                using (SqlCommand komanda=new SqlCommand(kom,konekcija))
                {
                    komanda.Parameters.AddWithValue("Id",Id);
                    komanda.Parameters.AddWithValue("FirstName", txbIme.Text);
                    komanda.Parameters.AddWithValue("LastName",txbPrezime.Text);
                    komanda.Parameters.AddWithValue("Position", txbPozicija.Text);

                    try
                    {
                        konekcija.Open();
                        komanda.ExecuteNonQuery();
                        MessageBox.Show("Podaci su ucitani");
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Podaci nisu ucitani"+ex.Message);
                    }

                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
