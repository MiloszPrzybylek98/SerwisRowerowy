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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;

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
            int idKlienta;
            int idNaprawy;
            int idRoweru;
            string opis = txtOpisNaprawy.Text;



            if (dgvKlienci.SelectedRows.Count > 0)
            {
                DataRow selectedrow = ((DataRowView)dgvKlienci.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                idKlienta = int.Parse(strID);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    #region SELECT klientów

                    string selectQuery = "SELECT * FROM klienci; SELECT SCOPE_IDENTITY();";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow newRow = dt.NewRow();
                    newRow["imie"] = txtImieKl.Text;
                    newRow["nazwisko"] = txtNazwiskoKl.Text;
                    newRow["telefon"] = txtNumerTelKl.Text;
                    newRow["darmowy_przeglad"] = 0;

                    dt.Rows.Add(newRow);

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dt);
                    #endregion

                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    #region Wyciągnięcie dodanego klienta
                    string query = "SELECT TOP 1 id_klienta FROM klienci ORDER BY id_klienta DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    idKlienta = dt.Rows[0].Field<int>(0);
                    #endregion

                }

            }

            if (dgvRowery.SelectedRows.Count > 0)
            {
                DataRow selectedrow = ((DataRowView)dgvRowery.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                idRoweru = int.Parse(strID);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string selectQuery = "SELECT * FROM rowery; SELECT SCOPE_IDENTITY();";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow newRow = dt.NewRow();
                    newRow["marka"] = marka;
                    newRow["model"] = model;
                    newRow["kolor"] = kolor;
                    newRow["numer_seryjny"] = nSeryjny;
                    newRow["klient_id"] = idKlienta;

                    dt.Rows.Add(newRow);

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dt);


                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 id_roweru FROM rowery ORDER BY id_roweru DESC";


                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    idRoweru = dt.Rows[0].Field<int>(0);

                }

            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM naprawy";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow newRow = dt.NewRow();
                newRow["data_serwisu"] = DateTime.Now;
                newRow["rodzaj_serwisu"] = "przeglad";
                newRow["klient_id"] = idKlienta;
                newRow["rower_id"] = idRoweru;
                newRow["uwaga"] = opis;
                newRow["czy_aktywna"] = 1;
                dt.Rows.Add(newRow);
                

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "SELECT TOP 1 id_naprawy FROM naprawy ORDER BY id_naprawy DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                idNaprawy = dt.Rows[0].Field<int>(0);


            }






            Naprawa naprawa = new Naprawa(idNaprawy, idKlienta, idRoweru);
            naprawa.Show();
            btnDodajNaprawe.Enabled = false;
            
        }

        private void btnDodajNowyRower_Click(object sender, EventArgs e)
        {
            
            

            GroupDaneRoweru.Visible = true;
            btnDodajNowyRower.Visible = false;

        }

        private void btnNowaNaprawa_Click(object sender, EventArgs e)
        {
            GroupDaneKl.Enabled = true;

            groupWyszukiwanieKlienta.Enabled = true;
            GroupDaneRoweru.Enabled = true;
            btnDodajNowyRower.Visible = true;
            btnDodajKlienta.Visible= true;
            GroupDaneRoweru.Visible = false;

            Connector connector = new Connector();
            connector.PobiezWszystkieDaneZTabeli(dgvKlienci, "klienci");

            dgvKlienci.CurrentCell = null;
            dgvKlienci.Columns["id_klienta"].Visible = false;
            btnDodajNaprawe.Enabled = true;

            

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

                btnDodajKlienta.Enabled = false;
                GroupDaneKl.Visible= false;
                btnDodajKlienta.Visible = true;
                DataTable dt = (DataTable)dgvKlienci.DataSource;

                DataRow selectedrow = ((DataRowView)dgvKlienci.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int idKlienta = int.Parse(strID);

                DataGridViewRow row = dgvKlienci.SelectedRows[0];



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

            groupWyszukiwanieKlienta.Enabled = false;
            GroupDaneRoweru.Enabled = false;
            groupDodajNowegoPrac.Enabled = false;
            

            


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

            dgvPracownik.DataSource= connector.PobiezWszystkieDaneZTabeliDoDt("pracownicy");

            dgvPracownik.CurrentCell = null;
            dgvPracownik.Columns["id_pracownika"].Visible = false;


            connector.PobiezWszystkieDaneZTabeli(dgvCzesci, "czesci");

            dgvCzesci.CurrentCell = null;
            dgvCzesci.Columns["id_czesci"].Visible = false;






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
            btnDodajKlienta.Enabled = true;
            btnDodajNowyRower.Enabled = true;
            GroupDaneRoweru.Visible = false;
            btnDodajNowyRower.Visible = true;
            
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


                //int klientID = '1';//(int)dgvObecneNaprawy.SelectedRows[0].Cells["klient_id"].Value;


                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{

                //    SqlCommand command = new SqlCommand("SELECT koszt_calkowity FROM naprawy WHERE klient_id = @KlientID", connection);
                //    command.Parameters.AddWithValue("@KlientID", klientID);


                //    if (koszt_finalny > 1000)
                //    {
                //        // zmień wartość pola "darmowy_przeglad" na 1 dla danego klienta
                //        SqlCommand updateCommand = new SqlCommand("UPDATE klienci SET darmowy_przeglad = 1 WHERE klient_id = @KlientID", connection);
                //        updateCommand.Parameters.AddWithValue("@KlientID", klientID);
                //        updateCommand.ExecuteNonQuery();

                //        MessageBox.Show($"Następny przegląd darmowy ");
                //    }
                //}
                //string connectionString = "Data Source=(local);Initial Catalog=MojaBazaDanych;Integrated Security=True";
                int klientID = (int)dgvObecneNaprawy.SelectedRows[0].Cells["klient_id"].Value; // pobierz ID klienta z wybranej przez użytkownika listy lub innej kontrolki

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // pobierz koszt całkowity naprawy dla danego klienta
                    SqlCommand command = new SqlCommand("SELECT koszt_calkowity FROM naprawy WHERE klient_id = @KlientID", connection);
                    command.Parameters.AddWithValue("@KlientID", klientID);
                    object result1 = command.ExecuteScalar();

                    if (result1 != null && result1 != DBNull.Value)
                    {
                        int kosztCalkowity = (int)result1;
                        if (kosztCalkowity > 1000)
                        {
                            // zmień wartość pola "darmowy_przeglad" na 1 dla danego klienta
                            SqlCommand updateCommand = new SqlCommand("UPDATE klienci SET darmowy_przeglad = 1 WHERE id_klienta = @KlientID", connection);
                            updateCommand.Parameters.AddWithValue("@KlientID", klientID);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // obsłuż błąd - koszt całkowity nie został znaleziony dla danego klienta
                        MessageBox.Show("Nie można pobrać kosztu całkowitego dla wybranego klienta.");
                    }
                }



            }
            
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
                object id_klienta;
                object id_roweru;


                DataRow selectedrow = ((DataRowView)dgvObecneNaprawy.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int id_naprawy = int.Parse(strID);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string selectQuery = $"SELECT * FROM naprawy where id_naprawy = {id_naprawy} ";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    id_klienta = dt.Rows[0]["klient_id"];
                    id_roweru = dt.Rows[0]["rower_id"];

                    
                }


                Naprawa naprawa = new Naprawa(id_naprawy, (int)id_klienta, (int)id_roweru);
                naprawa.Show();




            }
            
        }

        private void ClearTextBoxesInGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void radioRabat10_Click(object sender, EventArgs e)
        {
            radioRabat10.Checked = !radioRabat10.Checked;
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            groupDodajNowegoPrac.Enabled = true;

        }

        private void btnAnulujDodawaniePrac_Click(object sender, EventArgs e)
        {
            groupDodajNowegoPrac.Enabled = false;
            ClearTextBoxesInGroupBox(groupDodajNowegoPrac);
        }

        private void dgvRowery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRowery.SelectedRows.Count >0)
            {
                GroupDaneRoweru.Visible = false;
                btnDodajNowyRower.Visible = true;
                btnDodajNowyRower.Enabled = false;
                
            }
        }

        private void btnDodajKlienta_Click(object sender, EventArgs e)
        {
            GroupDaneKl.Visible = true;
            btnDodajKlienta.Visible = false;
            GroupDaneRoweru.Visible= false;
            
        }

        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            

            // 1. Sprawdź, czy wartość w kontrolce NumericUpDown jest większa od 0
            if (numUpDownCzesciIlosc.Value == 0)
            {
                MessageBox.Show("Wartość w polu 'Ilość' musi być większa od 0.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Utwórz połączenie z bazą danych
            SqlConnection conn = new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True");
            conn.Open();

            // 3. Sprawdź, czy w tabeli czesci istnieje już rekord o takich samych wartościach w kolumnach nazwa, numer_katalogowy i producent
            string queryCheckIfExists = "SELECT COUNT(*) FROM czesci WHERE nazwa = @nazwa AND numer_katalogowy = @numer_katalogowy AND producent = @producent";
            SqlCommand cmdCheckIfExists = new SqlCommand(queryCheckIfExists, conn);
            cmdCheckIfExists.Parameters.AddWithValue("@nazwa", txtCzesciNazwa.Text);
            cmdCheckIfExists.Parameters.AddWithValue("@numer_katalogowy", txtCzesciNrKatalogowy.Text);
            cmdCheckIfExists.Parameters.AddWithValue("@producent", txtCzesciProducent.Text);
            int count = (int)cmdCheckIfExists.ExecuteScalar();

            if (count == 0)
            {
                // 4a. Utwórz zapytanie SQL do wstawiania nowego rekordu
                string queryInsert = "INSERT INTO czesci (nazwa, numer_katalogowy, producent, ilosc, cena) VALUES (@nazwa, @numer_katalogowy, @producent, @ilosc, @cena)";

                // 5a. Utwórz obiekt SqlCommand i ustaw wartości parametrów z TextBoxów i kontrolki NumericUpDown
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@nazwa", txtCzesciNazwa.Text);
                cmdInsert.Parameters.AddWithValue("@numer_katalogowy", txtCzesciNrKatalogowy.Text);
                cmdInsert.Parameters.AddWithValue("@producent", txtCzesciProducent.Text);
                cmdInsert.Parameters.AddWithValue("@ilosc", numUpDownCzesciIlosc.Value);
                cmdInsert.Parameters.AddWithValue("@cena", txtCzesciCena.Text);

                // 6a. Wykonaj zapytanie SQL i zamknij połączenie
                cmdInsert.ExecuteNonQuery();
                conn.Close();

                // 7a. Wyświetl komunikat o dodaniu rekordu
                MessageBox.Show("Dodano nową część do bazy danych.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 4b. Utwórz zapytanie SQL do aktualizacji ilości dla istniejącego rekordu
                string queryUpdate = "UPDATE czesci SET ilosc = ilosc + @ilosc WHERE nazwa = @nazwa AND numer_katalogowy = @numer_katalogowy AND producent = @producent";

                // 5b. Utwórz obiekt SqlCommand i ustaw wartości parametrów z TextBoxów i kontrolki NumericUpDown
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@nazwa", txtCzesciNazwa.Text);
                cmdUpdate.Parameters.AddWithValue("@numer_katalogowy", txtCzesciNrKatalogowy.Text);
                cmdUpdate.Parameters.AddWithValue("@producent", txtCzesciProducent.Text);
                cmdUpdate.Parameters.AddWithValue("@ilosc", numUpDownCzesciIlosc.Value);

                // 6b. Wykonaj zapytanie SQL i zamknij połączenie
                cmdUpdate.ExecuteNonQuery();
                conn.Close();

                // 7b. Wyświetl komunikat o zaktualizowaniu ilości dla istniejącej części
                MessageBox.Show("Zaktualizowano ilość części w bazie danych.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
