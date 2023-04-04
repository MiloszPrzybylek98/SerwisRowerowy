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
using static System.Net.Mime.MediaTypeNames;

namespace SerwisRowerowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsunPracownika_Click(object sender, EventArgs e)
        {

            
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć Pracownika?", "Potwierdź usunięcie Pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {  
                
            }
            else
            {

            }
        }

        private void btnDodajNaprawe_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string nSeryjny = txtNrSeryjny.Text;
            string kolor = txtKolor.Text;

            Naprawa naprawa = new Naprawa();
            naprawa.Show();
            
        }

        private void btnDodajNowyRower_Click(object sender, EventArgs e)
        {
            
            

            GroupDaneRoweru.Visible = true;
            btnDodajNowyRower.Visible = false;

        }

        private void btnNowaNaprawa_Click(object sender, EventArgs e)
        {
            GroupDaneKl.Enabled = true;
            GroupDaneNaprawy.Enabled = true;
            groupWyszukiwanieKlienta.Enabled = true;
            GroupDaneRoweru.Enabled = true;
            btnDodajNowyRower.Visible = true;
            GroupDaneRoweru.Visible = false;

            Connector connector = new Connector();
            connector.PobiezWszystkieDaneZTabeli(dgvKlienci, "klienci");

            dgvKlienci.CurrentCell = null;
            dgvKlienci.Columns["id_klienta"].Visible = false;

        }

        private void txtFiltrKlienta_TextChanged(object sender, EventArgs e)
        {
            string tekst = txtFiltrKlienta.Text;

            if (tekst.Length >0)
            {
                string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                string selectCommand = "SELECT * FROM klienci WHERE (imie LIKE @Imie) OR (nazwisko LIKE @Nazwisko) OR (telefon LIKE @telefon)";
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Imie", string.Format("{0}%", tekst));
                adapter.SelectCommand.Parameters.AddWithValue("@Nazwisko", string.Format("{0}%", tekst));
                adapter.SelectCommand.Parameters.AddWithValue("@telefon", string.Format("{0}%", tekst));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKlienci.DataSource = dt;
                dgvKlienci.CurrentCell = null;
                dgvKlienci.Columns["id_klienta"].Visible = false;

            }
            else
            {
                string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                string selectCommand = "SELECT * FROM klienci";
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKlienci.DataSource = dt;
                dgvKlienci.CurrentCell = null;
                dgvKlienci.Columns["id_klienta"].Visible = false;

            }

            




        }

        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKlienci.SelectedRows.Count > 0)
            {

                DataTable dt = (DataTable)dgvKlienci.DataSource;

                DataRow selectedrow = ((DataRowView)dgvKlienci.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int idKlienta = int.Parse(strID);

                DataGridViewRow row = dgvKlienci.SelectedRows[0];
                txtImieKl.Text = row.Cells[0].Value.ToString();
                txtNazwiskoKl.Text = row.Cells[1].Value.ToString();
                txtNumerTelKl.Text = row.Cells[2].Value.ToString();


                string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                string selectCommand = "SELECT * FROM rowery WHERE klient_id = @klient_id";
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@klient_id",idKlienta );

                DataTable DtRowery = new DataTable();
                adapter.Fill(DtRowery);
                dgvRowery.DataSource = DtRowery;
                dgvRowery.CurrentCell = null;
                dgvRowery.Columns["klient_id"].Visible = false;
                dgvRowery.Columns["id_roweru"].Visible = false;



            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GroupDaneKl.Enabled = false;
            GroupDaneNaprawy.Enabled = false;
            groupWyszukiwanieKlienta.Enabled = false;
            GroupDaneRoweru.Enabled = false;

            Connector connector = new Connector();
            connector.PobierzDoDgvZWarunkiem(dgvObecneNaprawy, "*", "naprawy", "czy_aktywna", "1");
            connector.PobierzDoDgvZWarunkiem(dgvZakonczoneNaprawy, "*", "naprawy", "czy_aktywna", "0");




        }

        private void btnCzyszczenieOkienek_Click(object sender, EventArgs e)
        {
            txtImieKl.Text = null;
            txtNazwiskoKl.Text = null;
            txtNumerTelKl.Text = null;
            dgvKlienci.CurrentCell = null;
            txtFiltrKlienta.Text = null;
            dgvRowery.DataSource = null;
            dgvRowery.CurrentCell = null;
        }

        private void btnUsunCzesc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć Część?", "Potwierdź usunięcie Części", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void btnRozliczNaprawe_Click(object sender, EventArgs e)
        {
            if (dgvObecneNaprawy.SelectedRows.Count > 0)
            {



                DataRow selectedrow = ((DataRowView)dgvObecneNaprawy.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int idNaprawy = int.Parse(strID);

                DialogResult result = MessageBox.Show("Czy na pewno chcesz rozliczyć naprawę?", "Potwierdź aby rozliczyć", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                }
                else
                {

                }




            }
            
        }

        private void radioPrzeglad_Click(object sender, EventArgs e)
        {
            radioPrzeglad.Checked = !radioPrzeglad.Checked;
        }

        private void radioNaprawa_Click(object sender, EventArgs e)
        {
            radioNaprawa.Checked = !radioNaprawa.Checked;
        }

        private void radioDarmowyPrzeglad_Click(object sender, EventArgs e)
        {
            radioDarmowyPrzeglad.Checked = !radioDarmowyPrzeglad.Checked;


        }

        private void dgvObecneNaprawy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvObecneNaprawy.SelectedRows.Count > 0)
            {



                DataRow selectedrow = ((DataRowView)dgvObecneNaprawy.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int idNaprawy = int.Parse(strID);




            }
        }

        

        private void btnOtworzNaprawe_Click(object sender, EventArgs e)
        {
            int id_naprawy = 0;
            Naprawa naprawa = new Naprawa(id_naprawy);
            naprawa.Show();
        }
    }
}
