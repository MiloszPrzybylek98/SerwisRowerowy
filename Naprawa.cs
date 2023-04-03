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
        public Naprawa()
        {
            InitializeComponent();
        }

        private void Naprawa_Load(object sender, EventArgs e)
        {
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


            string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from uslugi", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                 RadioListaUslug.Items.Add(row["nazwa"].ToString() + "- " + row["cena"].ToString());
            }

        }


    }
}
