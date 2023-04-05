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

namespace SerwisRowerowy
{
    public partial class Naprawa : Form
    {
        private int _id_naprawy;
        public Naprawa(int id_naprawy)
        {
            InitializeComponent();
            _id_naprawy = id_naprawy;
        }
        public Naprawa()
        {
            InitializeComponent();
            
        }

        private void Naprawa_Load(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            connector.PobiezWszystkieDaneZTabeli(dgvCzesci, "czesci");

            dgvCzesci.CurrentCell = null;
            dgvCzesci.Columns["id_czesci"].Visible = false;

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


            string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
            string query = "SELECT * FROM uslugi";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RadioListaUslug.Items.Add(reader["nazwa"].ToString() + "- " + reader["cena"].ToString());
                }

                reader.Close();
            }

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
    }
}
