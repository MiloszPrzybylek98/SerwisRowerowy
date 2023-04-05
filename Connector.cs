using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
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

        //public void UpdatePojedynczyRow(string tabela, string poleDoUpdate)
        //{
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    string selectCommand = $"UPDATE {tabela} SET {poleDoUpdate} WHERE {zmWarunkowa} = {warunek}";
        //    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);

        //}

        //public void DodanieNowejNaprawy()
        //{
            
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    string insertQuery = "INSERT INTO Customers (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
        //    SqlCommand command = new SqlCommand(insertQuery, connection);
        //    command.Parameters.AddWithValue("@FirstName", "John");
        //    command.Parameters.AddWithValue("@LastName", "Doe");
        //    command.Parameters.AddWithValue("@Email", "john.doe@example.com");
        //    connection.Open();
        //    int rowsAffected = command.ExecuteNonQuery();
        //    connection.Close();

        //}

        public void DodanieNowejNaprawy()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO naprawy (kolumna1, kolumna2, kolumna3) VALUES (@val1, @val2, @val3)";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(insertQuery, connection);

                adapter.InsertCommand.Parameters.AddWithValue("@val1", "wartosc1");
                adapter.InsertCommand.Parameters.AddWithValue("@val2", "wartosc2");
                adapter.InsertCommand.Parameters.AddWithValue("@val3", "wartosc3");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow newRow = dt.NewRow();
                newRow["kolumna1"] = "wartosc1";
                newRow["kolumna2"] = "wartosc2";
                newRow["kolumna3"] = "wartosc3";

                dt.Rows.Add(newRow);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
            }

        }



    }
}
