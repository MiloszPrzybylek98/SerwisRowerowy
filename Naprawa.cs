using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;

namespace SerwisRowerowy
{
    public partial class Naprawa : Form
    {
        private int _id_naprawy;
        private int _id_klienta;
        private int _id_roweru;
        DataTable dt1 = new DataTable();
        DataTable dtUslugi = new DataTable();
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";

        public Naprawa(int id_naprawy, int id_klienta, int id_roweru)
        {
            InitializeComponent();
            _id_naprawy = id_naprawy;
            _id_klienta = id_klienta;
            _id_roweru = id_roweru;
        }
        public Naprawa()
        {
            InitializeComponent();
            
        }

        private void Naprawa_Load(object sender, EventArgs e)
        {

            string uwaga;
            string imieKlienta;
            string nazwiskoKlienta;
           
            string markaRoweru;
            string modelRoweru;
            string kolorRoweru;
            string NrSerRoweru;

            string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
            Connector connector = new Connector();
            connector.PobiezWszystkieDaneZTabeli(dgvCzesci, "czesci");

            dgvCzesci.CurrentCell = null;
            dgvCzesci.Columns["id_czesci"].Visible = false;

            #region Pobranie danych o darmowym przegladzie
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT darmowy_przeglad FROM klienci WHERE id_klienta = @id_klienta";
                SqlDataAdapter adapter2 = new SqlDataAdapter(selectQuery, connection2);
                adapter2.SelectCommand.Parameters.AddWithValue("@id_klienta", _id_klienta);

                DataTable dt1 = new DataTable();
                adapter2.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {
                    DataRow row1 = dt1.Rows[0];


                    string Czy_darmowy = row1["darmowy_przeglad"].ToString();


                    if (Czy_darmowy == "True")
                    {
                        lblDarmowyPrzeglad.Visible = true;
                        radioPrzegladDarmowy.Enabled = true;
                    }
                    else
                    {
                        lblDarmowyPrzeglad.Visible = false;
                        radioPrzegladDarmowy.Enabled = false;
                    }
                }
            }
            #endregion

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = @"SELECT n.uwaga, k.*, r.* FROM naprawy n 
                                    INNER JOIN klienci k ON n.klient_id = k.id_klienta 
                                    INNER JOIN rowery r ON n.rower_id = r.id_roweru WHERE n.id_naprawy = @id_naprawy";

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //dane o naprawie
                uwaga = dt.Rows[0].Field<string>("uwaga");

                // dane o kliencie dla danej naprawy
                imieKlienta = dt.Rows[0].Field<string>("imie");
                nazwiskoKlienta = dt.Rows[0].Field<string>("nazwisko");

                // dane o rowerze dla danej naprawy
                markaRoweru = dt.Rows[0].Field<string>("marka");
                modelRoweru = dt.Rows[0].Field<string>("model");
                kolorRoweru = dt.Rows[0].Field<string>("kolor");
                NrSerRoweru = dt.Rows[0].Field<string>("numer_seryjny");

            }

            lblOpisNaprawy.Text = uwaga;
            lblMarka.Text = markaRoweru;
            lblModel.Text = modelRoweru;
            lblKolor.Text = kolorRoweru;
            lblNrSeryjny.Text= NrSerRoweru;

            
            connector.PobiezWszystkieDaneZTabeli(dgvListaUslug, "uslugi");
            dgvListaUslug.CurrentCell = null;
            dgvListaUslug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaUslug.Columns["id_uslugi"].Visible= false;
            


            SqlConnection connection1 = new SqlConnection(connectionString);
            string selectCommand1 = "SELECT * FROM uslugi";
            SqlDataAdapter adapter1 = new SqlDataAdapter(selectCommand1, connection1);

            #region Jakis zakomentowany kod 
            //adapter1.Fill(dt1);

            //foreach (DataRow row in dt1.Rows)
            //{
            //    string nazwaUslugi = row["nazwa"].ToString();
            //    decimal cenaUslugi = (decimal)row["cena"];
            //    int idUslugi = (int)row["id_uslugi"];

            //    listUslugi.Items.Add(idUslugi+". "+ nazwaUslugi +"- "+ cenaUslugi);
            //    listUslugi.Items.
            //}





            //to też było odkomentowane

            //SqlConnection connection = new SqlConnection(connectionString);
            //string selectCommand = $"SELECT zamowienia.*,klienci.* FROM naprawy WHERE id_naprawy = {_id_naprawy}";
            //SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);


            //DataTable dt = new DataTable();
            //adapter.Fill(dt);


            //OleDbDataAdapter adp = new OleDbDataAdapter();
            //OleDbConnection con = new OleDbConnection();

            //DataTable dt = new DataTable();

            //con.ConnectionString = "Provider=SQLOLEDB;Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";

            //adp = new OleDbDataAdapter("SELECT nazwa FROM uslugi", con);
            //adp.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    RadioListaUslug.Items.Add(row["nazwa"]);
            //}

            //OleDbConnection connection = new OleDbConnection();
            //OleDbDataAdapter adapter = new OleDbDataAdapter();

            //string connectionString = "Provider=SQLNCLI10;Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";

            //string query = "SELECT nazwa FROM uslugi";


            //DataTable dataTable = new DataTable();

            //try
            //{
            //    connection = new OleDbConnection(connectionString);
            //    connection.Open();

            //    adapter = new OleDbDataAdapter(query, connection);
            //    adapter.Fill(dataTable);

            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        RadioListaUslug.Items.Add(row["nazwa"]);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Błąd pobierania danych: " + ex.Message);
            //}
            //finally
            //{
            //    if (adapter != null) adapter.Dispose();
            //    if (connection != null) connection.Close();
            //}
            #endregion

        }

        private void txtFiltr_TextChanged(object sender, EventArgs e)
        {
            #region Filtorwanie czesci
            string tekst = txtFiltr.Text;

            if (tekst.Length > 0)
            {
                string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                string selectCommand = "SELECT * FROM czesci WHERE (nazwa LIKE @nazwa) OR (numer_katalogowy LIKE @numer_katalogowy) OR (producent LIKE @producent)";
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@nazwa", string.Format("{0}%", tekst));
                adapter.SelectCommand.Parameters.AddWithValue("@numer_katalogowy", string.Format("{0}%", tekst));
                adapter.SelectCommand.Parameters.AddWithValue("@producent", string.Format("{0}%", tekst));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCzesci.DataSource = dt;
                dgvCzesci.CurrentCell = null;
                dgvCzesci.Columns["id_czesci"].Visible = false;

            }
            else
            {
                string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                string selectCommand = "SELECT * FROM czesci";
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                
                adapter.Fill(dtUslugi);
                dgvCzesci.DataSource = dtUslugi;

                dgvCzesci.CurrentCell = null;
                dgvCzesci.Columns["id_czesci"].Visible = false;

            }
            #endregion
        }

        private void btnDodajCzesci_Click(object sender, EventArgs e)
        {

        }

        private void btnZapiszNaprawe_Click(object sender, EventArgs e)
        {
            // Tworzenie nowej tabeli o nazwie "wybrane_uslugi" z kolumnami "nazwa_uslugi" i "cena"
            //DataTable dt = new DataTable();
            //dt.Columns.Add("naprawaId", typeof(int));
            //dt.Columns.Add("uslugaId", typeof(int));

            //foreach (var item in listUslugi.SelectedItems)
            //{

            //    DataRow row = dt.NewRow();

            //    row["naprawaId"] = _id_naprawy;
            //    row["uslugaId"] = item.ToString();
            //}




 


            // Aktualizacja bazy danych za pomocą adaptera SqlDataAdapter
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    string insertQuery = "INSERT INTO Worek_na_uslugi (naprawaId, uslugaId) VALUES (@id_naprawy, @id_uslugi)";
            //    SqlDataAdapter adapter = new SqlDataAdapter(insertQuery, connection);

            //    // Dodanie parametrów do adaptera
            //    adapter.InsertCommand.Parameters.Add("@nazwa_uslugi", SqlDbType.NVarChar, 50, "nazwa_uslugi");
            //    adapter.InsertCommand.Parameters.Add("@cena", SqlDbType.Decimal, 0, "cena");

            //    // Ustawienie właściwości SqlCommandBuilder dla adaptera
            //    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            //    // Aktualizacja danych w bazie danych
            //    adapter.Update(dt);
            //}

        }

        private void btnDodajUslugi_Click(object sender, EventArgs e)
        {
            if(dgvListaUslug.SelectedRows.Count > 0)
            {
                DataRow selectedrow = ((DataRowView)dgvListaUslug.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                int idUslugi = int.Parse(strID);


                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    #region Prawidłowy INSERT używając adaptera

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("Select * from Worek_na_uslugi", connection);
                    adapter.InsertCommand = new SqlCommand("INSERT INTO Worek_na_uslugi(naprawaId, uslugaId) VALUES(@naprawaId, @uslugaId)", connection);
                    adapter.InsertCommand.Parameters.AddWithValue("@naprawaId", _id_naprawy);
                    adapter.InsertCommand.Parameters.AddWithValue("@uslugaId", idUslugi);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dr["naprawaId"] = _id_naprawy;
                    dr["uslugaId"] = idUslugi;
                    dt.Rows.Add(dr);
                    adapter.Update(dt);
                    #endregion


                }

                using (SqlConnection connection2 = new SqlConnection(connectionString))
                {

                    #region Ładny SELECT adapter
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand($"SELECT uslugi.nazwa, uslugi.cena FROM uslugi INNER JOIN Worek_na_uslugi ON uslugi.id_uslugi = Worek_na_uslugi.uslugaId WHERE Worek_na_uslugi.naprawaId = @id_naprawy",connection2);
                    adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvUslugiWorek.DataSource = dataTable;
                    #endregion

                }



            }

        }

        private void btnOdejmijUslugi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUslugiWorek.SelectedRows.Count > 0)
                {
                    DataRow selectedrow = ((DataRowView)dgvListaUslug.SelectedRows[0].DataBoundItem).Row;
                    string strID = selectedrow[0].ToString();
                    int idUslugi = int.Parse(strID);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {


                        #region Prawidłowy DELETE używając adaptera

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("Select * from Worek_na_uslugi", connection);
                        adapter.DeleteCommand = new SqlCommand("DELETE FROM Worek_na_uslugi WHERE naprawaId = @naprawaId AND uslugaId = @uslugaId", connection);
                        adapter.DeleteCommand.Parameters.AddWithValue("@naprawaId", _id_naprawy);
                        adapter.DeleteCommand.Parameters.AddWithValue("@uslugaId", idUslugi);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            if ((int)row["naprawaId"] == _id_naprawy && (int)row["uslugaId"] == idUslugi)
                            {
                                row.Delete();
                                break;
                            }
                        }
                        
                        adapter.Update(dt);
                        #endregion


                    }


                }

            }
            catch (Exception)
            {
                
            }
            
            if (dgvUslugiWorek.Rows.Count < 2)
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    #region Prawidłowy DELETE używając adaptera

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("Select * from Worek_na_uslugi", connection);
                    adapter.DeleteCommand = new SqlCommand("DELETE FROM Worek_na_uslugi WHERE naprawaId = @naprawaId", connection);
                    adapter.DeleteCommand.Parameters.AddWithValue("@naprawaId", _id_naprawy);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        if ((int)row["naprawaId"] == _id_naprawy)
                        {
                            row.Delete();
                            break;
                        }
                    }

                    adapter.Update(dt);
                    #endregion

                }
            }
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {

                #region Ładny SELECT adapter
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand($"SELECT uslugi.nazwa, uslugi.cena FROM uslugi INNER JOIN Worek_na_uslugi ON uslugi.id_uslugi = Worek_na_uslugi.uslugaId WHERE Worek_na_uslugi.naprawaId = @id_naprawy", connection2);
                adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvUslugiWorek.DataSource = dataTable;
                #endregion

            }
            dgvListaUslug.CurrentCell = null;
        }
    }
}
