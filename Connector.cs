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
        public DataTable PobiezWszystkieDaneZTabeliDoDt(string tabela)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string selectCommand = $"SELECT * FROM {tabela}";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;


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


        public DataTable UzupelnijDgvZNaprawami(int CzyAktywna)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand($"SELECT n.*, k.imie, k.nazwisko, r.marka, r.kolor FROM naprawy n JOIN klienci k ON n.klient_id = k.id_klienta JOIN rowery r ON n.rower_id = r.id_roweru WHERE czy_aktywna = @czy_aktywna", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@czy_aktywna", CzyAktywna);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;



            }
        }

        public DataTable PobierzCzesciPowyzejZera()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                #region Ładny SELECT adapter
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand($"SELECT * FROM czesci WHERE ilosc > 0", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
                #endregion

            }
        }
        public DataTable PobierzCzesci()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                #region Ładny SELECT adapter
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand($"SELECT * FROM czesci", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
                #endregion

               
            }
        }


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
