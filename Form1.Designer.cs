namespace SerwisRowerowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCzesci = new System.Windows.Forms.DataGridView();
            this.groupCzesci = new System.Windows.Forms.GroupBox();
            this.btnDodajCzesc = new System.Windows.Forms.Button();
            this.numUpDownCzesciIlosc = new System.Windows.Forms.NumericUpDown();
            this.btnUsunCzesc = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupNowaCzesc = new System.Windows.Forms.GroupBox();
            this.txtCzesciNazwa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCzesciNrKatalogowy = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCzesciProducent = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCzesciCena = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvObecneNaprawy = new System.Windows.Forms.DataGridView();
            this.btnOtworzNaprawe = new System.Windows.Forms.Button();
            this.dgvZakonczoneNaprawy = new System.Windows.Forms.DataGridView();
            this.btnRozliczNaprawe = new System.Windows.Forms.Button();
            this.groupPodusmowanie = new System.Windows.Forms.GroupBox();
            this.lblKosztCzesci = new System.Windows.Forms.Label();
            this.lblKosztRobocizny = new System.Windows.Forms.Label();
            this.lblKosztCalkowity = new System.Windows.Forms.Label();
            this.radioRabat10 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GroupDaneKl = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImieKl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwiskoKl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumerTelKl = new System.Windows.Forms.TextBox();
            this.GroupDaneRoweru = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtNrSeryjny = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKolor = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDodajNaprawe = new System.Windows.Forms.Button();
            this.btnDodajNowyRower = new System.Windows.Forms.Button();
            this.btnNowaNaprawa = new System.Windows.Forms.Button();
            this.groupWyszukiwanieKlienta = new System.Windows.Forms.GroupBox();
            this.txtFiltrKlienta = new System.Windows.Forms.TextBox();
            this.dgvKlienci = new System.Windows.Forms.DataGridView();
            this.dgvRowery = new System.Windows.Forms.DataGridView();
            this.btnCzyszczenieOkienek = new System.Windows.Forms.Button();
            this.btnDodajKlienta = new System.Windows.Forms.Button();
            this.txtOpisNaprawy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).BeginInit();
            this.groupCzesci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCzesciIlosc)).BeginInit();
            this.groupNowaCzesc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneNaprawy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakonczoneNaprawy)).BeginInit();
            this.groupPodusmowanie.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.GroupDaneKl.SuspendLayout();
            this.GroupDaneRoweru.SuspendLayout();
            this.groupWyszukiwanieKlienta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowery)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupNowaCzesc);
            this.tabPage2.Controls.Add(this.groupCzesci);
            this.tabPage2.Controls.Add(this.dgvCzesci);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1169, 745);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Części";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCzesci
            // 
            this.dgvCzesci.AllowUserToAddRows = false;
            this.dgvCzesci.AllowUserToDeleteRows = false;
            this.dgvCzesci.AllowUserToResizeColumns = false;
            this.dgvCzesci.AllowUserToResizeRows = false;
            this.dgvCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzesci.Location = new System.Drawing.Point(24, 23);
            this.dgvCzesci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCzesci.MultiSelect = false;
            this.dgvCzesci.Name = "dgvCzesci";
            this.dgvCzesci.ReadOnly = true;
            this.dgvCzesci.RowHeadersVisible = false;
            this.dgvCzesci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCzesci.Size = new System.Drawing.Size(873, 363);
            this.dgvCzesci.TabIndex = 0;
            // 
            // groupCzesci
            // 
            this.groupCzesci.Controls.Add(this.label15);
            this.groupCzesci.Controls.Add(this.btnUsunCzesc);
            this.groupCzesci.Controls.Add(this.numUpDownCzesciIlosc);
            this.groupCzesci.Controls.Add(this.btnDodajCzesc);
            this.groupCzesci.Location = new System.Drawing.Point(24, 416);
            this.groupCzesci.Margin = new System.Windows.Forms.Padding(4);
            this.groupCzesci.Name = "groupCzesci";
            this.groupCzesci.Padding = new System.Windows.Forms.Padding(4);
            this.groupCzesci.Size = new System.Drawing.Size(311, 165);
            this.groupCzesci.TabIndex = 5;
            this.groupCzesci.TabStop = false;
            this.groupCzesci.Text = "Edycja stanu magazynowego";
            // 
            // btnDodajCzesc
            // 
            this.btnDodajCzesc.Location = new System.Drawing.Point(8, 107);
            this.btnDodajCzesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajCzesc.Name = "btnDodajCzesc";
            this.btnDodajCzesc.Size = new System.Drawing.Size(120, 28);
            this.btnDodajCzesc.TabIndex = 2;
            this.btnDodajCzesc.Text = "Dodaj części";
            this.btnDodajCzesc.UseVisualStyleBackColor = true;
            this.btnDodajCzesc.Click += new System.EventHandler(this.btnDodajCzesc_Click);
            // 
            // numUpDownCzesciIlosc
            // 
            this.numUpDownCzesciIlosc.Location = new System.Drawing.Point(8, 58);
            this.numUpDownCzesciIlosc.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownCzesciIlosc.Name = "numUpDownCzesciIlosc";
            this.numUpDownCzesciIlosc.Size = new System.Drawing.Size(160, 22);
            this.numUpDownCzesciIlosc.TabIndex = 3;
            // 
            // btnUsunCzesc
            // 
            this.btnUsunCzesc.Location = new System.Drawing.Point(179, 107);
            this.btnUsunCzesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsunCzesc.Name = "btnUsunCzesc";
            this.btnUsunCzesc.Size = new System.Drawing.Size(120, 28);
            this.btnUsunCzesc.TabIndex = 1;
            this.btnUsunCzesc.Text = "Usun części";
            this.btnUsunCzesc.UseVisualStyleBackColor = true;
            this.btnUsunCzesc.Click += new System.EventHandler(this.btnUsunCzesc_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Ilość części";
            // 
            // groupNowaCzesc
            // 
            this.groupNowaCzesc.Controls.Add(this.label19);
            this.groupNowaCzesc.Controls.Add(this.txtCzesciCena);
            this.groupNowaCzesc.Controls.Add(this.label18);
            this.groupNowaCzesc.Controls.Add(this.txtCzesciProducent);
            this.groupNowaCzesc.Controls.Add(this.label17);
            this.groupNowaCzesc.Controls.Add(this.txtCzesciNrKatalogowy);
            this.groupNowaCzesc.Controls.Add(this.label16);
            this.groupNowaCzesc.Controls.Add(this.txtCzesciNazwa);
            this.groupNowaCzesc.Location = new System.Drawing.Point(384, 416);
            this.groupNowaCzesc.Margin = new System.Windows.Forms.Padding(4);
            this.groupNowaCzesc.Name = "groupNowaCzesc";
            this.groupNowaCzesc.Padding = new System.Windows.Forms.Padding(4);
            this.groupNowaCzesc.Size = new System.Drawing.Size(513, 165);
            this.groupNowaCzesc.TabIndex = 6;
            this.groupNowaCzesc.TabStop = false;
            this.groupNowaCzesc.Text = "Dodawanie nowej części";
            // 
            // txtCzesciNazwa
            // 
            this.txtCzesciNazwa.Location = new System.Drawing.Point(7, 44);
            this.txtCzesciNazwa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCzesciNazwa.Name = "txtCzesciNazwa";
            this.txtCzesciNazwa.Size = new System.Drawing.Size(100, 22);
            this.txtCzesciNazwa.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Nazwa";
            // 
            // txtCzesciNrKatalogowy
            // 
            this.txtCzesciNrKatalogowy.Location = new System.Drawing.Point(7, 92);
            this.txtCzesciNrKatalogowy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCzesciNrKatalogowy.Name = "txtCzesciNrKatalogowy";
            this.txtCzesciNrKatalogowy.Size = new System.Drawing.Size(100, 22);
            this.txtCzesciNrKatalogowy.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Nr katalogowy";
            // 
            // txtCzesciProducent
            // 
            this.txtCzesciProducent.Location = new System.Drawing.Point(203, 44);
            this.txtCzesciProducent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCzesciProducent.Name = "txtCzesciProducent";
            this.txtCzesciProducent.Size = new System.Drawing.Size(100, 22);
            this.txtCzesciProducent.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(203, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "Producent";
            // 
            // txtCzesciCena
            // 
            this.txtCzesciCena.Location = new System.Drawing.Point(203, 92);
            this.txtCzesciCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCzesciCena.Name = "txtCzesciCena";
            this.txtCzesciCena.Size = new System.Drawing.Size(100, 22);
            this.txtCzesciCena.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(203, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 7;
            this.label19.Text = "Cena";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupPodusmowanie);
            this.tabPage1.Controls.Add(this.btnRozliczNaprawe);
            this.tabPage1.Controls.Add(label10);
            this.tabPage1.Controls.Add(this.dgvZakonczoneNaprawy);
            this.tabPage1.Controls.Add(this.btnOtworzNaprawe);
            this.tabPage1.Controls.Add(label9);
            this.tabPage1.Controls.Add(this.dgvObecneNaprawy);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1169, 745);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Naprawy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvObecneNaprawy
            // 
            this.dgvObecneNaprawy.AllowUserToAddRows = false;
            this.dgvObecneNaprawy.AllowUserToDeleteRows = false;
            this.dgvObecneNaprawy.AllowUserToResizeColumns = false;
            this.dgvObecneNaprawy.AllowUserToResizeRows = false;
            this.dgvObecneNaprawy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObecneNaprawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObecneNaprawy.Location = new System.Drawing.Point(25, 47);
            this.dgvObecneNaprawy.Margin = new System.Windows.Forms.Padding(4);
            this.dgvObecneNaprawy.MultiSelect = false;
            this.dgvObecneNaprawy.Name = "dgvObecneNaprawy";
            this.dgvObecneNaprawy.ReadOnly = true;
            this.dgvObecneNaprawy.RowHeadersVisible = false;
            this.dgvObecneNaprawy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObecneNaprawy.Size = new System.Drawing.Size(796, 185);
            this.dgvObecneNaprawy.TabIndex = 0;
            this.dgvObecneNaprawy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObecneNaprawy_CellClick);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(25, 23);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(109, 16);
            label9.TabIndex = 1;
            label9.Text = "Obecne naprawy";
            // 
            // btnOtworzNaprawe
            // 
            this.btnOtworzNaprawe.Location = new System.Drawing.Point(29, 267);
            this.btnOtworzNaprawe.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtworzNaprawe.Name = "btnOtworzNaprawe";
            this.btnOtworzNaprawe.Size = new System.Drawing.Size(165, 44);
            this.btnOtworzNaprawe.TabIndex = 8;
            this.btnOtworzNaprawe.Text = "Otwórz wybraną naprawę";
            this.btnOtworzNaprawe.Click += new System.EventHandler(this.btnOtworzNaprawe_Click);
            // 
            // dgvZakonczoneNaprawy
            // 
            this.dgvZakonczoneNaprawy.AllowUserToAddRows = false;
            this.dgvZakonczoneNaprawy.AllowUserToDeleteRows = false;
            this.dgvZakonczoneNaprawy.AllowUserToResizeColumns = false;
            this.dgvZakonczoneNaprawy.AllowUserToResizeRows = false;
            this.dgvZakonczoneNaprawy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZakonczoneNaprawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakonczoneNaprawy.Location = new System.Drawing.Point(29, 431);
            this.dgvZakonczoneNaprawy.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZakonczoneNaprawy.MultiSelect = false;
            this.dgvZakonczoneNaprawy.Name = "dgvZakonczoneNaprawy";
            this.dgvZakonczoneNaprawy.ReadOnly = true;
            this.dgvZakonczoneNaprawy.RowHeadersVisible = false;
            this.dgvZakonczoneNaprawy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZakonczoneNaprawy.Size = new System.Drawing.Size(792, 185);
            this.dgvZakonczoneNaprawy.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(25, 411);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(135, 16);
            label10.TabIndex = 5;
            label10.Text = "Zakończone naprawy";
            // 
            // btnRozliczNaprawe
            // 
            this.btnRozliczNaprawe.Location = new System.Drawing.Point(855, 267);
            this.btnRozliczNaprawe.Margin = new System.Windows.Forms.Padding(4);
            this.btnRozliczNaprawe.Name = "btnRozliczNaprawe";
            this.btnRozliczNaprawe.Size = new System.Drawing.Size(201, 53);
            this.btnRozliczNaprawe.TabIndex = 6;
            this.btnRozliczNaprawe.Text = "Zakończ i rozlicz naprawę";
            this.btnRozliczNaprawe.UseVisualStyleBackColor = true;
            this.btnRozliczNaprawe.Click += new System.EventHandler(this.btnRozliczNaprawe_Click);
            // 
            // groupPodusmowanie
            // 
            this.groupPodusmowanie.Controls.Add(this.radioRabat10);
            this.groupPodusmowanie.Controls.Add(this.lblKosztCalkowity);
            this.groupPodusmowanie.Controls.Add(this.lblKosztRobocizny);
            this.groupPodusmowanie.Controls.Add(this.lblKosztCzesci);
            this.groupPodusmowanie.Location = new System.Drawing.Point(855, 23);
            this.groupPodusmowanie.Margin = new System.Windows.Forms.Padding(4);
            this.groupPodusmowanie.Name = "groupPodusmowanie";
            this.groupPodusmowanie.Padding = new System.Windows.Forms.Padding(4);
            this.groupPodusmowanie.Size = new System.Drawing.Size(267, 225);
            this.groupPodusmowanie.TabIndex = 7;
            this.groupPodusmowanie.TabStop = false;
            this.groupPodusmowanie.Text = "Podsumowanie";
            // 
            // lblKosztCzesci
            // 
            this.lblKosztCzesci.AutoSize = true;
            this.lblKosztCzesci.Location = new System.Drawing.Point(9, 25);
            this.lblKosztCzesci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKosztCzesci.Name = "lblKosztCzesci";
            this.lblKosztCzesci.Size = new System.Drawing.Size(83, 16);
            this.lblKosztCzesci.TabIndex = 0;
            this.lblKosztCzesci.Text = "Koszt części:";
            // 
            // lblKosztRobocizny
            // 
            this.lblKosztRobocizny.AutoSize = true;
            this.lblKosztRobocizny.Location = new System.Drawing.Point(9, 54);
            this.lblKosztRobocizny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKosztRobocizny.Name = "lblKosztRobocizny";
            this.lblKosztRobocizny.Size = new System.Drawing.Size(103, 16);
            this.lblKosztRobocizny.TabIndex = 1;
            this.lblKosztRobocizny.Text = "Koszt robocizny:";
            // 
            // lblKosztCalkowity
            // 
            this.lblKosztCalkowity.AutoSize = true;
            this.lblKosztCalkowity.Location = new System.Drawing.Point(8, 84);
            this.lblKosztCalkowity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKosztCalkowity.Name = "lblKosztCalkowity";
            this.lblKosztCalkowity.Size = new System.Drawing.Size(103, 16);
            this.lblKosztCalkowity.TabIndex = 2;
            this.lblKosztCalkowity.Text = "Koszt całkowity:";
            // 
            // radioRabat10
            // 
            this.radioRabat10.AutoCheck = false;
            this.radioRabat10.AutoSize = true;
            this.radioRabat10.Location = new System.Drawing.Point(8, 116);
            this.radioRabat10.Margin = new System.Windows.Forms.Padding(4);
            this.radioRabat10.Name = "radioRabat10";
            this.radioRabat10.Size = new System.Drawing.Size(91, 20);
            this.radioRabat10.TabIndex = 3;
            this.radioRabat10.TabStop = true;
            this.radioRabat10.Text = "Rabat 10%";
            this.radioRabat10.UseVisualStyleBackColor = true;
            this.radioRabat10.Click += new System.EventHandler(this.radioRabat10_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtOpisNaprawy);
            this.tabPage3.Controls.Add(this.btnDodajKlienta);
            this.tabPage3.Controls.Add(this.groupWyszukiwanieKlienta);
            this.tabPage3.Controls.Add(this.btnNowaNaprawa);
            this.tabPage3.Controls.Add(this.btnDodajNowyRower);
            this.tabPage3.Controls.Add(this.btnDodajNaprawe);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.GroupDaneRoweru);
            this.tabPage3.Controls.Add(this.GroupDaneKl);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1169, 745);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zgłoszenie naprawy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GroupDaneKl
            // 
            this.GroupDaneKl.Controls.Add(this.txtNumerTelKl);
            this.GroupDaneKl.Controls.Add(this.label3);
            this.GroupDaneKl.Controls.Add(this.txtNazwiskoKl);
            this.GroupDaneKl.Controls.Add(this.label2);
            this.GroupDaneKl.Controls.Add(this.txtImieKl);
            this.GroupDaneKl.Controls.Add(this.label1);
            this.GroupDaneKl.Location = new System.Drawing.Point(36, 21);
            this.GroupDaneKl.Margin = new System.Windows.Forms.Padding(4);
            this.GroupDaneKl.Name = "GroupDaneKl";
            this.GroupDaneKl.Padding = new System.Windows.Forms.Padding(4);
            this.GroupDaneKl.Size = new System.Drawing.Size(180, 308);
            this.GroupDaneKl.TabIndex = 2;
            this.GroupDaneKl.TabStop = false;
            this.GroupDaneKl.Text = "Dane Klienta";
            this.GroupDaneKl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // txtImieKl
            // 
            this.txtImieKl.Location = new System.Drawing.Point(11, 60);
            this.txtImieKl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImieKl.Name = "txtImieKl";
            this.txtImieKl.Size = new System.Drawing.Size(149, 22);
            this.txtImieKl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // txtNazwiskoKl
            // 
            this.txtNazwiskoKl.Location = new System.Drawing.Point(11, 121);
            this.txtNazwiskoKl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazwiskoKl.Name = "txtNazwiskoKl";
            this.txtNazwiskoKl.Size = new System.Drawing.Size(149, 22);
            this.txtNazwiskoKl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nr telefonu";
            // 
            // txtNumerTelKl
            // 
            this.txtNumerTelKl.Location = new System.Drawing.Point(11, 186);
            this.txtNumerTelKl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumerTelKl.Name = "txtNumerTelKl";
            this.txtNumerTelKl.Size = new System.Drawing.Size(149, 22);
            this.txtNumerTelKl.TabIndex = 4;
            // 
            // GroupDaneRoweru
            // 
            this.GroupDaneRoweru.Controls.Add(this.txtKolor);
            this.GroupDaneRoweru.Controls.Add(this.label7);
            this.GroupDaneRoweru.Controls.Add(this.txtNrSeryjny);
            this.GroupDaneRoweru.Controls.Add(this.lblMarka);
            this.GroupDaneRoweru.Controls.Add(this.label4);
            this.GroupDaneRoweru.Controls.Add(this.txtMarka);
            this.GroupDaneRoweru.Controls.Add(this.txtModel);
            this.GroupDaneRoweru.Controls.Add(this.label5);
            this.GroupDaneRoweru.Location = new System.Drawing.Point(251, 23);
            this.GroupDaneRoweru.Margin = new System.Windows.Forms.Padding(4);
            this.GroupDaneRoweru.Name = "GroupDaneRoweru";
            this.GroupDaneRoweru.Padding = new System.Windows.Forms.Padding(4);
            this.GroupDaneRoweru.Size = new System.Drawing.Size(181, 308);
            this.GroupDaneRoweru.TabIndex = 3;
            this.GroupDaneRoweru.TabStop = false;
            this.GroupDaneRoweru.Text = "Dane Roweru";
            this.GroupDaneRoweru.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(11, 121);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(149, 22);
            this.txtModel.TabIndex = 8;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(11, 60);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(149, 22);
            this.txtMarka.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nr seryjny";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(7, 42);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(45, 16);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Marka";
            // 
            // txtNrSeryjny
            // 
            this.txtNrSeryjny.Location = new System.Drawing.Point(11, 186);
            this.txtNrSeryjny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrSeryjny.Name = "txtNrSeryjny";
            this.txtNrSeryjny.Size = new System.Drawing.Size(149, 22);
            this.txtNrSeryjny.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kolor";
            // 
            // txtKolor
            // 
            this.txtKolor.Location = new System.Drawing.Point(11, 251);
            this.txtKolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKolor.Name = "txtKolor";
            this.txtKolor.Size = new System.Drawing.Size(149, 22);
            this.txtKolor.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "• Przegląd rowerowy: 150 PLN",
            "• Hamulce: 20-200 PLN",
            "• Koła: 10-300 PLN",
            "• Ogumienie 15-100 PLN",
            "• Amortyzatory: 10-300 PLN",
            "• Czyszczenie: 10-80 PLN",
            "• Napęd: 10-80 PLN"});
            this.listBox1.Location = new System.Drawing.Point(911, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 276);
            this.listBox1.TabIndex = 5;
            // 
            // btnDodajNaprawe
            // 
            this.btnDodajNaprawe.Enabled = false;
            this.btnDodajNaprawe.Location = new System.Drawing.Point(953, 514);
            this.btnDodajNaprawe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajNaprawe.Name = "btnDodajNaprawe";
            this.btnDodajNaprawe.Size = new System.Drawing.Size(183, 62);
            this.btnDodajNaprawe.TabIndex = 6;
            this.btnDodajNaprawe.Text = "Utwórz naprawę";
            this.btnDodajNaprawe.UseVisualStyleBackColor = true;
            this.btnDodajNaprawe.Click += new System.EventHandler(this.btnDodajNaprawe_Click);
            // 
            // btnDodajNowyRower
            // 
            this.btnDodajNowyRower.Location = new System.Drawing.Point(251, 178);
            this.btnDodajNowyRower.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajNowyRower.Name = "btnDodajNowyRower";
            this.btnDodajNowyRower.Size = new System.Drawing.Size(181, 28);
            this.btnDodajNowyRower.TabIndex = 14;
            this.btnDodajNowyRower.Text = "Dodaj nowy rower";
            this.btnDodajNowyRower.UseVisualStyleBackColor = true;
            this.btnDodajNowyRower.Visible = false;
            this.btnDodajNowyRower.Click += new System.EventHandler(this.btnDodajNowyRower_Click);
            // 
            // btnNowaNaprawa
            // 
            this.btnNowaNaprawa.Location = new System.Drawing.Point(953, 379);
            this.btnNowaNaprawa.Margin = new System.Windows.Forms.Padding(4);
            this.btnNowaNaprawa.Name = "btnNowaNaprawa";
            this.btnNowaNaprawa.Size = new System.Drawing.Size(183, 62);
            this.btnNowaNaprawa.TabIndex = 15;
            this.btnNowaNaprawa.Text = "Nowa naprawa";
            this.btnNowaNaprawa.UseVisualStyleBackColor = true;
            this.btnNowaNaprawa.Click += new System.EventHandler(this.btnNowaNaprawa_Click);
            // 
            // groupWyszukiwanieKlienta
            // 
            this.groupWyszukiwanieKlienta.Controls.Add(this.btnCzyszczenieOkienek);
            this.groupWyszukiwanieKlienta.Controls.Add(this.dgvRowery);
            this.groupWyszukiwanieKlienta.Controls.Add(this.dgvKlienci);
            this.groupWyszukiwanieKlienta.Controls.Add(this.txtFiltrKlienta);
            this.groupWyszukiwanieKlienta.Location = new System.Drawing.Point(460, 23);
            this.groupWyszukiwanieKlienta.Margin = new System.Windows.Forms.Padding(4);
            this.groupWyszukiwanieKlienta.Name = "groupWyszukiwanieKlienta";
            this.groupWyszukiwanieKlienta.Padding = new System.Windows.Forms.Padding(4);
            this.groupWyszukiwanieKlienta.Size = new System.Drawing.Size(425, 601);
            this.groupWyszukiwanieKlienta.TabIndex = 16;
            this.groupWyszukiwanieKlienta.TabStop = false;
            this.groupWyszukiwanieKlienta.Text = "Wyszukaj klienta";
            // 
            // txtFiltrKlienta
            // 
            this.txtFiltrKlienta.Location = new System.Drawing.Point(21, 38);
            this.txtFiltrKlienta.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrKlienta.Name = "txtFiltrKlienta";
            this.txtFiltrKlienta.Size = new System.Drawing.Size(132, 22);
            this.txtFiltrKlienta.TabIndex = 10;
            this.txtFiltrKlienta.TextChanged += new System.EventHandler(this.txtFiltrKlienta_TextChanged);
            // 
            // dgvKlienci
            // 
            this.dgvKlienci.AllowUserToAddRows = false;
            this.dgvKlienci.AllowUserToDeleteRows = false;
            this.dgvKlienci.AllowUserToResizeColumns = false;
            this.dgvKlienci.AllowUserToResizeRows = false;
            this.dgvKlienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlienci.Location = new System.Drawing.Point(8, 71);
            this.dgvKlienci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKlienci.MultiSelect = false;
            this.dgvKlienci.Name = "dgvKlienci";
            this.dgvKlienci.ReadOnly = true;
            this.dgvKlienci.RowHeadersVisible = false;
            this.dgvKlienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlienci.Size = new System.Drawing.Size(409, 234);
            this.dgvKlienci.TabIndex = 7;
            this.dgvKlienci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellClick);
            // 
            // dgvRowery
            // 
            this.dgvRowery.AllowUserToAddRows = false;
            this.dgvRowery.AllowUserToDeleteRows = false;
            this.dgvRowery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRowery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRowery.Location = new System.Drawing.Point(8, 336);
            this.dgvRowery.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRowery.MultiSelect = false;
            this.dgvRowery.Name = "dgvRowery";
            this.dgvRowery.ReadOnly = true;
            this.dgvRowery.RowHeadersVisible = false;
            this.dgvRowery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRowery.Size = new System.Drawing.Size(409, 245);
            this.dgvRowery.TabIndex = 8;
            this.dgvRowery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRowery_CellClick);
            // 
            // btnCzyszczenieOkienek
            // 
            this.btnCzyszczenieOkienek.Location = new System.Drawing.Point(205, 36);
            this.btnCzyszczenieOkienek.Margin = new System.Windows.Forms.Padding(4);
            this.btnCzyszczenieOkienek.Name = "btnCzyszczenieOkienek";
            this.btnCzyszczenieOkienek.Size = new System.Drawing.Size(181, 28);
            this.btnCzyszczenieOkienek.TabIndex = 17;
            this.btnCzyszczenieOkienek.Text = "Wyczyść zaznaczenie";
            this.btnCzyszczenieOkienek.UseVisualStyleBackColor = true;
            this.btnCzyszczenieOkienek.Click += new System.EventHandler(this.btnCzyszczenieOkienek_Click);
            // 
            // btnDodajKlienta
            // 
            this.btnDodajKlienta.Location = new System.Drawing.Point(35, 178);
            this.btnDodajKlienta.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajKlienta.Name = "btnDodajKlienta";
            this.btnDodajKlienta.Size = new System.Drawing.Size(181, 28);
            this.btnDodajKlienta.TabIndex = 17;
            this.btnDodajKlienta.Text = "Dodaj nowego klienta";
            this.btnDodajKlienta.UseVisualStyleBackColor = true;
            this.btnDodajKlienta.Visible = false;
            this.btnDodajKlienta.Click += new System.EventHandler(this.btnDodajKlienta_Click);
            // 
            // txtOpisNaprawy
            // 
            this.txtOpisNaprawy.Location = new System.Drawing.Point(45, 379);
            this.txtOpisNaprawy.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpisNaprawy.Multiline = true;
            this.txtOpisNaprawy.Name = "txtOpisNaprawy";
            this.txtOpisNaprawy.Size = new System.Drawing.Size(385, 82);
            this.txtOpisNaprawy.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Opis usługi";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 774);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 836);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Serwis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).EndInit();
            this.groupCzesci.ResumeLayout(false);
            this.groupCzesci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCzesciIlosc)).EndInit();
            this.groupNowaCzesc.ResumeLayout(false);
            this.groupNowaCzesc.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneNaprawy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakonczoneNaprawy)).EndInit();
            this.groupPodusmowanie.ResumeLayout(false);
            this.groupPodusmowanie.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.GroupDaneKl.ResumeLayout(false);
            this.GroupDaneKl.PerformLayout();
            this.GroupDaneRoweru.ResumeLayout(false);
            this.GroupDaneRoweru.PerformLayout();
            this.groupWyszukiwanieKlienta.ResumeLayout(false);
            this.groupWyszukiwanieKlienta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowery)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupNowaCzesc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCzesciCena;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCzesciProducent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCzesciNrKatalogowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCzesciNazwa;
        private System.Windows.Forms.GroupBox groupCzesci;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUsunCzesc;
        private System.Windows.Forms.NumericUpDown numUpDownCzesciIlosc;
        private System.Windows.Forms.Button btnDodajCzesc;
        private System.Windows.Forms.DataGridView dgvCzesci;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupPodusmowanie;
        private System.Windows.Forms.RadioButton radioRabat10;
        private System.Windows.Forms.Label lblKosztCalkowity;
        private System.Windows.Forms.Label lblKosztRobocizny;
        private System.Windows.Forms.Label lblKosztCzesci;
        private System.Windows.Forms.Button btnRozliczNaprawe;
        private System.Windows.Forms.DataGridView dgvZakonczoneNaprawy;
        private System.Windows.Forms.Button btnOtworzNaprawe;
        private System.Windows.Forms.DataGridView dgvObecneNaprawy;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpisNaprawy;
        private System.Windows.Forms.Button btnDodajKlienta;
        private System.Windows.Forms.GroupBox groupWyszukiwanieKlienta;
        private System.Windows.Forms.Button btnCzyszczenieOkienek;
        private System.Windows.Forms.DataGridView dgvRowery;
        private System.Windows.Forms.DataGridView dgvKlienci;
        private System.Windows.Forms.TextBox txtFiltrKlienta;
        private System.Windows.Forms.Button btnNowaNaprawa;
        private System.Windows.Forms.Button btnDodajNowyRower;
        private System.Windows.Forms.Button btnDodajNaprawe;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox GroupDaneRoweru;
        private System.Windows.Forms.TextBox txtKolor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNrSeryjny;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupDaneKl;
        private System.Windows.Forms.TextBox txtNumerTelKl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazwiskoKl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImieKl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

