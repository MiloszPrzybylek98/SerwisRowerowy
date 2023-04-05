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
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
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

            //proba inserta

            SqlConnection conn;
            SqlDataAdapter adapter;
            DataSet ds;
            DataTable dt;
            conn= new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM naprawy", conn);
            adapter = new SqlDataAdapter(cmd);
            ds= new DataSet();
            adapter.Fill(ds);
            dt = ds.Tables[0];
            //dt.PrimaryKey = new


            if (dgvKlienci.SelectedRows.Count > 0)
            {
                DataRow selectedrow = ((DataRowView)dgvKlienci.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int idKlienta = int.Parse(strID);

            }


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
                txtImieKl.Text = row.Cells[1].Value.ToString();
                txtNazwiskoKl.Text = row.Cells[2].Value.ToString();
                txtNumerTelKl.Text = row.Cells[3].Value.ToString();


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
            dgvObecneNaprawy.CurrentCell = null;
            dgvObecneNaprawy.Columns["id_naprawy"].Visible = false;
            dgvObecneNaprawy.Columns["klient_id"].Visible = false;
            dgvObecneNaprawy.Columns["rower_id"].Visible = false;
            dgvObecneNaprawy.Columns["uwaga"].Visible = false;
            dgvZakonczoneNaprawy.Columns["id_naprawy"].Visible = false;
            dgvZakonczoneNaprawy.Columns["klient_id"].Visible = false;
            dgvZakonczoneNaprawy.Columns["rower_id"].Visible = false;
            dgvZakonczoneNaprawy.Columns["uwaga"].Visible = false;
            dgvObecneNaprawy.ClearSelection();
            








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
                object[] values = selectedrow.ItemArray;
                var koszt_calkowity = values[5].ToString();
                double koszt_finalny = 0;
                int nieaktywna = 0;

                

                DialogResult result = MessageBox.Show("Czy na pewno chcesz rozliczyć naprawę?", "Potwierdź aby rozliczyć", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (radioRabat10.Checked)
                    {
                        koszt_finalny = Double.Parse(koszt_calkowity) * 0.9;
                        MessageBox.Show($"Po uwzględnieniu rabatu 10% klient musi zapłacić: {koszt_finalny.ToString()} PLN");
                    }
                    else
                    {
                        koszt_finalny = Double.Parse(koszt_calkowity);
                        MessageBox.Show($"Klient musi zapłacić: {koszt_finalny.ToString()} PLN");
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string selectQuery = $"SELECT * FROM naprawy where id_naprawy = {idNaprawy} ";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataRow rowToUpdate = dt.Rows[0];
                        rowToUpdate["czy_aktywna"] = nieaktywna;

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dt);
                    }

                    Connector connector = new Connector();
                    connector.PobierzDoDgvZWarunkiem(dgvObecneNaprawy, "*", "naprawy", "czy_aktywna", "1");
                    connector.PobierzDoDgvZWarunkiem(dgvZakonczoneNaprawy, "*", "naprawy", "czy_aktywna", "0");





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


            if (dgvObecneNaprawy.SelectedRows.Count > 0)
            {
                radioRabat10.Checked = false;
                DataRow selectedrow = ((DataRowView)dgvObecneNaprawy.SelectedRows[0].DataBoundItem).Row;
                object[] values = selectedrow.ItemArray;
                var koszt_czesci = values[3].ToString();
                var koszt_uslugi = values[4].ToString();
                var koszt_calkowity = values[5].ToString();
                string strID = selectedrow[0].ToString();
                int id_naprawy = int.Parse(strID);
                lblKosztCzesci.Text = "Koszt częsci: "+ koszt_czesci;
                lblKosztRobocizny.Text = "Koszt robocizny: "+ koszt_uslugi;
                lblKosztCalkowity.Text ="Koszt całkowity: "+ koszt_calkowity;


            }
        }



        

        private void btnOtworzNaprawe_Click(object sender, EventArgs e)
        {
            if (dgvObecneNaprawy.SelectedRows.Count > 0)
            {



                DataRow selectedrow = ((DataRowView)dgvObecneNaprawy.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int id_naprawy = int.Parse(strID);
       
                Naprawa naprawa = new Naprawa(id_naprawy);
                naprawa.Show();




            }
            
        }

        private void radioRabat10_Click(object sender, EventArgs e)
        {
            radioRabat10.Checked = !radioRabat10.Checked;
        }
    }
}
