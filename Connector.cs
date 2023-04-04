using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwisRowerowy
{
    public class Connector
    {
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=serwis_rowerowy;Integrated Security=True";


        public void PobiezWszystkieDaneZTabeli(DataGridView dgv, string tabela)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string selectCommand = $"SELECT * FROM {tabela}";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;

            
        }


        public void PobierzDoDgvZWarunkiem(DataGridView dgv,string daneDoPobrania, string tabela, string zmWarunkowa, string warunek)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string selectCommand = $"SELECT {daneDoPobrania} FROM {tabela} WHERE {zmWarunkowa} = {warunek}";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);


            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }


    }
}
