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

namespace SerwisRowerowy
{
    public partial class Naprawa : Form
    {
        private int _id_naprawy;
        private int _id_klienta;
        private int _id_roweru;
        DataTable dt1 = new DataTable();
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
            
            //dgvListaUslug.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            




            //    OleDbDataAdapter adapter;
            //    DataTable dt = new DataTable();
            //    OleDbConnection con = new OleDbConnection();


            //     con.ConnectionString = $"Provider=SQLOLEDB;Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";

            //    try
            //    {
            //        adapter = new OleDbDataAdapter("Select * from Uslugi", con);
            //        adapter.Fill(dt);
            //        RadioListaUslug.Items.Add(dt);
            //    }
            //    catch (Exception)
            //    {


            //    }



            //string connectionString = $"Provider=SQLOLEDB;Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
            //OleDbConnection connection = new OleDbConnection(connectionString);

            //string query = "SELECT * FROM Uslugi";
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);

            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);


            //To jest dla testu!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            //string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter adapter = new SqlDataAdapter("Select * from uslugi", connection);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    RadioListaUslug.Items.Add(row["nazwa"].ToString() + "- " + row["cena"].ToString());
            //}

            /// ten kod poniżej był odkomentowany eryku


            //


            SqlConnection connection1 = new SqlConnection(connectionString);
            string selectCommand1 = "SELECT * FROM uslugi";
            SqlDataAdapter adapter1 = new SqlDataAdapter(selectCommand1, connection1);

            
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


        }

        private void txtFiltr_TextChanged(object sender, EventArgs e)
        {
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
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCzesci.DataSource = dt;
                dgvCzesci.CurrentCell = null;
                dgvCzesci.Columns["id_czesci"].Visible = false;

            }
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




            //DataTable selectedUslugiTable = new DataTable();

            //selectedUslugiTable.Columns.Add("naprawaId", typeof(int));
            //selectedUslugiTable.Columns.Add("uslugaId", typeof(int));

            //List<int> selectedTags = new List<int>();

            //foreach (var rb in checkedUslugi.CheckedItems.Cast<DataRowView>())
            //{

            //    int tagvalue = (int)rb.Row["tag"];
            //    selectedTags.Add(tagvalue);

            //DataRow row = selectedUslugiTable.NewRow();

            //row["naprawaId"] = _id_naprawy;
            //row["uslugaId"] = rb.Tag;
            //selectedUslugiTable.Rows.Add(row);

            //DataRowView drv = (DataRowView)rb.Tag;
            //DataRow row = drv.Row;

            //DataRow newRow = selectedUslugiTable.NewRow();
            //newRow["uslugaId"] = row["id_uslugi"];
            //newRow["naprawaId"] = _id_naprawy;
            //selectedUslugiTable.Rows.Add(newRow);

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
    }
}
