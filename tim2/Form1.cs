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
using System.Xml.Linq;

namespace tim2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {

            Dodavanje dodavanje=new Dodavanje();
            dodavanje.KomDodaj();
            dodavanje.ShowDialog();
            Osvezi();   
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow != null)
            {
                int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                DialogResult result = MessageBox.Show("Da li zelite da izmenite?", "Potvrda izmene", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Dodavanje dodavanje = new Dodavanje();

                    dodavanje.SetValues(
                        selectedRow.Cells["FirstName"].Value.ToString(),
                        selectedRow.Cells["LastName"].Value.ToString(),
                        selectedRow.Cells["Position"].Value.ToString()
                    );
                    dodavanje.IgracId = Id;
                    dodavanje.KomIzmeni();
                    dodavanje.ShowDialog();
                }
            }
            Osvezi();
        }
        private void Osvezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = IgraciDal.Procitaj();
            dataGridView1.Refresh();
        }
        private void PrikaziIgrace()
        {
            dataGridView1.DataSource = IgraciDal.Procitaj();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziIgrace();
        }

        private void IzbrisiKorisnika(int Id)
        {
            using (SqlConnection konekcija=new SqlConnection(Konekcija.cnnTimDB))
            {
                konekcija.Open();
                using (SqlCommand komanda = new SqlCommand("DELETE * FROM Player WHERE Id=@Id", konekcija))
                {
                    komanda.Parameters.AddWithValue("Id",Id);
                    komanda.ExecuteNonQuery();

                }
            }        
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow != null)
            {
                int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                DialogResult result = MessageBox.Show("Da li zelite da izbrisete?", "Potvrda brisanja", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    IzbrisiKorisnika(Id);
                }
            }
            Osvezi();
        }
    }
}
