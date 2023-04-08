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
        DataTable dtCzesci = new DataTable();
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


            Connector connector = new Connector();
            dgvCzesci.DataSource= connector.PobierzCzesci();


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
                        checkDarmowyPrzeglad.Enabled = true;
                        checkDarmowyPrzeglad.Checked = false;
                    }
                    else
                    {
                        lblDarmowyPrzeglad.Visible = false;
                        checkDarmowyPrzeglad.Enabled = false;
                        checkDarmowyPrzeglad.Checked = false;
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
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {

                #region Ładny SELECT adapter
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand($"SELECT worek_na_czesci.czescId, worek_na_czesci.naprawaId, czesci.nazwa, czesci.cena, czesci.producent, worek_na_czesci.ilosc, worek_na_czesci.cena_calkowita FROM czesci INNER JOIN worek_na_czesci ON czesci.id_czesci = worek_na_czesci.czescId WHERE worek_na_czesci.naprawaId = @id_naprawy", connection2);
                adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvCzesciWorek.DataSource = dataTable;
                #endregion

            }

        }

        private void txtFiltr_TextChanged(object sender, EventArgs e)
        {
            #region Filtorwanie czesci
            string tekst = txtFiltr.Text;

            if (tekst.Length > 0)
            {

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

                SqlConnection connection = new SqlConnection(connectionString);
                string selectCommand = "SELECT * FROM czesci";
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                
                adapter.Fill(dtCzesci);
                dgvCzesci.DataSource = dtCzesci;

                dgvCzesci.CurrentCell = null;
                dgvCzesci.Columns["id_czesci"].Visible = false;

            }
            #endregion
        }

        private void btnDodajCzesci_Click(object sender, EventArgs e)
        {
            if (dgvCzesci.SelectedRows.Count > 0) // dodac tu, że jeśli już mamy dodana ta czesc to update i jeśli już brak jej w magazynie to nie pokazujemy w częściach
            {
                DataRow selectedrow = ((DataRowView)dgvCzesci.SelectedRows[0].DataBoundItem).Row;
                string strID = selectedrow[0].ToString();
                string cena = selectedrow[4].ToString();
                string ilosc = selectedrow[5].ToString();
                int idCzesci = int.Parse(strID);
                int cena1Czesci = int.Parse(cena);
                int iloscCzesci = int.Parse(ilosc);
                int ileCzesciChcemy = (int)numIleCzesci.Value;

                if(iloscCzesci < ileCzesciChcemy)
                {
                    MessageBox.Show("Brak wymaganej ilości części w magazynie");
                    numIleCzesci.Value = 0m;
                    return;
                }

                if (ileCzesciChcemy > 0) 
                {
                    int CenaCzesciRazem = cena1Czesci * ileCzesciChcemy;
                    int ileDoPrzerzucenia = iloscCzesci - ileCzesciChcemy;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {


                        #region Prawidłowy INSERT używając adaptera

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("Select * from worek_na_czesci", connection);
                        adapter.InsertCommand = new SqlCommand("INSERT INTO worek_na_czesci(naprawaId, czescId, ilosc, cena_calkowita) VALUES(@naprawaId, @czescId, @ilosc, @cena)", connection);
                        adapter.InsertCommand.Parameters.AddWithValue("@naprawaId", _id_naprawy);
                        adapter.InsertCommand.Parameters.AddWithValue("@czescId", idCzesci);
                        adapter.InsertCommand.Parameters.AddWithValue("@ilosc", ileCzesciChcemy);
                        adapter.InsertCommand.Parameters.AddWithValue("@cena", CenaCzesciRazem);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["naprawaId"] = _id_naprawy;
                        dr["czescId"] = idCzesci;
                        dr["ilosc"] = ileCzesciChcemy;
                        dr["cena_calkowita"] = CenaCzesciRazem;
                        dt.Rows.Add(dr);
                        adapter.Update(dt);
                        #endregion


                    }
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {


                        #region Prawidłowy UPDATE używając adaptera

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("Select * from czesci", connection);
                        adapter.UpdateCommand = new SqlCommand("UPDATE czesci set ilosc =  @ilosc WHERE id_czesci = @id_czesci", connection);
                        adapter.UpdateCommand.Parameters.AddWithValue("@id_czesci", idCzesci);
                        adapter.UpdateCommand.Parameters.AddWithValue("@ilosc", ileDoPrzerzucenia);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            if ((int)row["id_czesci"] == idCzesci)
                            {
                                row["ilosc"] = ileDoPrzerzucenia;
                                break;

                            }
                        }     
                        adapter.Update(dt);
                        #endregion


                    }

                    using (SqlConnection connection2 = new SqlConnection(connectionString))
                    {

                        #region Ładny SELECT adapter
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand($"SELECT worek_na_czesci.czescId, worek_na_czesci.naprawaId, czesci.nazwa, czesci.cena, czesci.producent, worek_na_czesci.ilosc, worek_na_czesci.cena_calkowita FROM czesci INNER JOIN worek_na_czesci ON czesci.id_czesci = worek_na_czesci.czescId WHERE worek_na_czesci.naprawaId = @id_naprawy", connection2);
                        adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvCzesciWorek.DataSource = dataTable;
                        #endregion

                    }
                    Connector connector = new Connector();
                    dgvCzesci.DataSource = connector.PobierzCzesci();

                    dgvCzesci.CurrentCell = null;
                    dgvCzesci.Columns["id_czesci"].Visible = false;
                    dgvCzesciWorek.Columns["czescId"].Visible = false;
                    dgvCzesciWorek.Columns["naprawaId"].Visible = false;

                }
                else
                {
                    MessageBox.Show("Podaj liczbę części");
                }
                



            }
        }

        private void btnZapiszNaprawe_Click(object sender, EventArgs e)
        {   
            DataTable dtCenaCzesci = new DataTable();
            DataTable dtCenaUslug = new DataTable();
            int CenaZaUslugi = 0;
            int CenaZaCzesci = 0;
            int CenaCalkowita = 0;
            int CzyDarmowySerwis = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                #region SELECT CENA CZESCI
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand($"SELECT cena_calkowita FROM worek_na_czesci where naprawaId = @id_naprawy", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);
                adapter.Fill(dtCenaCzesci);

                #endregion
            }
            foreach (DataRow row in dtCenaCzesci.Rows)
            {
                CenaZaCzesci += (int)row["cena_calkowita"];
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                #region SELECT CENA USLUG
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand($"SELECT uslugi.cena FROM uslugi JOIN Worek_na_uslugi ON Worek_na_uslugi.uslugaId = uslugi.id_uslugi WHERE Worek_na_uslugi.naprawaId = @id_naprawy", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);
                adapter.Fill(dtCenaUslug);

                #endregion
            }
            foreach (DataRow row in dtCenaUslug.Rows)
            {
                CenaZaUslugi += (int)row["cena"];
            }
            CenaCalkowita = CenaZaUslugi + CenaZaCzesci;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                #region Prawidłowy UPDATE używając adaptera

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from naprawy", connection);
                adapter.UpdateCommand = new SqlCommand("UPDATE naprawy SET koszt_czesci = @koszt_czesci, koszt_uslugi = @koszt_uslugi, koszt_calkowity = @koszt_calkowity, czy_darmowy_serwis = @czy_darmowy_serwis WHERE Id_naprawy = @id_naprawy", connection);
                adapter.UpdateCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);


                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if ((int)row["id_naprawy"] == _id_naprawy)
                    {
                        row["koszt_czesci"] = CenaZaCzesci;
                        row["koszt_uslugi"] = CenaZaUslugi;
                        row["koszt_calkowity"] = CenaCalkowita;
                        if (checkDarmowyPrzeglad.Checked)
                        {
                            CzyDarmowySerwis = 1;
                            row["czy_darmowy_serwis"] = CzyDarmowySerwis;

                        }
                        else
                        {
                            CzyDarmowySerwis = 0;
                            row["czy_darmowy_serwis"] = CzyDarmowySerwis;
                        }
                        adapter.UpdateCommand.Parameters.AddWithValue("@koszt_czesci", CenaZaCzesci);
                        adapter.UpdateCommand.Parameters.AddWithValue("@koszt_uslugi", CenaZaUslugi);
                        adapter.UpdateCommand.Parameters.AddWithValue("@koszt_calkowity", CenaCalkowita);
                        adapter.UpdateCommand.Parameters.AddWithValue("@czy_darmowy_serwis", CzyDarmowySerwis);
                        break;

                    }
                }


                adapter.Update(dt);
                #endregion


            }
            if (checkDarmowyPrzeglad.Checked)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    #region Prawidłowy UPDATE używając adaptera

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("Select * from klienci", connection);
                    adapter.UpdateCommand = new SqlCommand("UPDATE klienci SET darmowy_przeglad = @darmowy_przeglad WHERE id_klienta = @id_klienta", connection);
                    adapter.UpdateCommand.Parameters.AddWithValue("@id_klienta", _id_klienta);


                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        if ((int)row["id_klienta"] == _id_klienta)
                        {
                            row["darmowy_przeglad"] = 0;
                            
                            adapter.UpdateCommand.Parameters.AddWithValue("@darmowy_przeglad", 0);
                            break;

                        }
                    }


                    adapter.Update(dt);
                    #endregion


                }
            }
            

            this.Close();







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
                    DataRow selectedrow = ((DataRowView)dgvListaUslug.SelectedRows[0].DataBoundItem).Row; // tu tez bedzie jakis blad z id
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

        private void btnUsunCzesci_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtWorekNaCzesci = new DataTable();
                int iloscZWorka = 0;
                int IleDoUsuniecia = (int)numIleCzesci.Value;
                

                if (dgvCzesciWorek.SelectedRows.Count > 0)
                {
                    if (IleDoUsuniecia < 1)
                    {
                        MessageBox.Show("Podaj liczbę części do usunięcia ");
                        return;
                    }
                    

                    DataRow selectedrow = ((DataRowView)dgvCzesciWorek.SelectedRows[0].DataBoundItem).Row;
                    string strCzescId = selectedrow[0].ToString();

                    int idCzesci = int.Parse(strCzescId);
                    

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        #region SELECT pobierający cześć do usunięcia z worka

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("Select * from worek_na_czesci ", connection);


                        adapter.Fill(dtWorekNaCzesci);


                        #endregion
                    }

                    foreach (DataRow row in dtWorekNaCzesci.Rows)
                    {
                        if((int)row["czescId"] == idCzesci  && (int)row["naprawaId"] == _id_naprawy)
                        {
                            iloscZWorka = (int)row["ilosc"];
                        }
                    }

                    if (IleDoUsuniecia > iloscZWorka)
                    {
                        MessageBox.Show("Podaj mniejsza ilość części do usunięcia");
                        return;
                    }
                    if (IleDoUsuniecia == iloscZWorka) //tu dajemy delete i update
                    {
                        
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {

                            #region Prawidłowy DELETE używając adaptera

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = new SqlCommand("Select * from worek_na_czesci ", connection);
                            adapter.DeleteCommand = new SqlCommand("DELETE FROM worek_na_czesci WHERE naprawaId = @naprawaId AND czescId = @czescId", connection);
                            adapter.DeleteCommand.Parameters.AddWithValue("@naprawaId", _id_naprawy);
                            adapter.DeleteCommand.Parameters.AddWithValue("@czescId", idCzesci);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                if ((int)row["czescId"] == idCzesci && (int)row["naprawaId"] == _id_naprawy)
                                {
                                    row.Delete();
                                    break;
                                }
                            }

                            
                            adapter.Update(dt);
                            #endregion

                        }
                        using (SqlConnection connection = new SqlConnection(connectionString)) 
                        {
                            int ileMaByc;

                            #region Prawidłowy UPDATE używając adaptera

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = new SqlCommand("Select * from czesci", connection);
                            adapter.UpdateCommand = new SqlCommand("UPDATE czesci set ilosc =  @ilosc WHERE id_czesci = @id_czesci", connection);
                            adapter.UpdateCommand.Parameters.AddWithValue("@id_czesci", idCzesci);
                            

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                if ((int)row["id_czesci"] == idCzesci)
                                {
                                    ileMaByc = (int)row["ilosc"] + IleDoUsuniecia;
                                    row["ilosc"] = ileMaByc;
                                    adapter.UpdateCommand.Parameters.AddWithValue("@ilosc", ileMaByc);

                                    break;

                                }
                            }
                            

                            adapter.Update(dt);
                            #endregion


                        }
                        Connector connector = new Connector();
                        dgvCzesci.DataSource = connector.PobierzCzesci();


                    }
                    if(IleDoUsuniecia <iloscZWorka) // tu dajemy update i update
                    {
                        int ileMaZostacWWorku = iloscZWorka - IleDoUsuniecia;

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            

                            #region Prawidłowy UPDATE używając adaptera

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = new SqlCommand("Select * from worek_na_czesci ", connection);
                            adapter.UpdateCommand = new SqlCommand("UPDATE worek_na_czesci set ilosc = @ilosc WHERE naprawaId = @naprawaId AND czescId = @czescId", connection);
                            adapter.UpdateCommand.Parameters.AddWithValue("@naprawaId", _id_naprawy);
                            adapter.UpdateCommand.Parameters.AddWithValue("@czescId", idCzesci);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                if ((int)row["czescId"] == idCzesci && (int)row["naprawaId"] == _id_naprawy)
                                {
                                    row["ilosc"] = ileMaZostacWWorku;
                                    adapter.UpdateCommand.Parameters.AddWithValue("@ilosc", ileMaZostacWWorku);
                                    break;
                                }
                            }


                            adapter.Update(dt);
                            #endregion

                        }
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            int ileMaByc;

                            #region Prawidłowy UPDATE używając adaptera

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = new SqlCommand("Select * from czesci", connection);
                            adapter.UpdateCommand = new SqlCommand("UPDATE czesci set ilosc =  @ilosc WHERE id_czesci = @id_czesci", connection);
                            adapter.UpdateCommand.Parameters.AddWithValue("@id_czesci", idCzesci);


                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                if ((int)row["id_czesci"] == idCzesci)
                                {
                                    ileMaByc = (int)row["ilosc"] + IleDoUsuniecia;
                                    row["ilosc"] = ileMaByc;
                                    adapter.UpdateCommand.Parameters.AddWithValue("@ilosc", ileMaByc);

                                    break;

                                }
                            }


                            adapter.Update(dt);
                            #endregion


                        }
                        Connector connector = new Connector();
                        dgvCzesci.DataSource = connector.PobierzCzesci();

                    }
                    using (SqlConnection connection2 = new SqlConnection(connectionString))
                    {

                        #region Ładny SELECT adapter
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand($"SELECT worek_na_czesci.czescId, worek_na_czesci.naprawaId, czesci.nazwa, czesci.cena, czesci.producent, worek_na_czesci.ilosc, worek_na_czesci.cena_calkowita FROM czesci INNER JOIN worek_na_czesci ON czesci.id_czesci = worek_na_czesci.czescId WHERE worek_na_czesci.naprawaId = @id_naprawy", connection2);
                        adapter.SelectCommand.Parameters.AddWithValue("@id_naprawy", _id_naprawy);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvCzesciWorek.DataSource = dataTable;
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
