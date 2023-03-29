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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImieKl = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnModyfikujPracownika = new System.Windows.Forms.Button();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
            this.btnUsunPracownika = new System.Windows.Forms.Button();
            this.dgvPracownik = new System.Windows.Forms.DataGridView();
            this.GroupDaneKl = new System.Windows.Forms.GroupBox();
            this.txtNazwiskoKl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumerTelKl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupDaneRoweru = new System.Windows.Forms.GroupBox();
            this.txtNrSeryjny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtKolor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupDaneNaprawy = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvObecneNaprawy = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvZakonczoneNaprawy = new System.Windows.Forms.DataGridView();
            this.radioNaprawa = new System.Windows.Forms.RadioButton();
            this.radioPrzeglad = new System.Windows.Forms.RadioButton();
            this.btnRozliczNaprawe = new System.Windows.Forms.Button();
            this.groupPodusmowanie = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDodajNaprawe = new System.Windows.Forms.Button();
            this.dgvCzesci = new System.Windows.Forms.DataGridView();
            this.btnUsunCzesc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.groupCzesci = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownik)).BeginInit();
            this.GroupDaneKl.SuspendLayout();
            this.GroupDaneRoweru.SuspendLayout();
            this.GroupDaneNaprawy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneNaprawy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakonczoneNaprawy)).BeginInit();
            this.groupPodusmowanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupCzesci.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDodajNaprawe);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.GroupDaneNaprawy);
            this.tabPage3.Controls.Add(this.GroupDaneRoweru);
            this.tabPage3.Controls.Add(this.GroupDaneKl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(875, 536);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zgłoszenie naprawy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // txtImieKl
            // 
            this.txtImieKl.Location = new System.Drawing.Point(8, 49);
            this.txtImieKl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImieKl.Name = "txtImieKl";
            this.txtImieKl.Size = new System.Drawing.Size(113, 20);
            this.txtImieKl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupPodusmowanie);
            this.tabPage1.Controls.Add(this.btnRozliczNaprawe);
            this.tabPage1.Controls.Add(label10);
            this.tabPage1.Controls.Add(this.dgvZakonczoneNaprawy);
            this.tabPage1.Controls.Add(this.btnDodaj);
            this.tabPage1.Controls.Add(label9);
            this.tabPage1.Controls.Add(this.dgvObecneNaprawy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(875, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Naprawy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupCzesci);
            this.tabPage2.Controls.Add(this.dgvCzesci);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(875, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Części";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnModyfikujPracownika);
            this.tabPage4.Controls.Add(this.btnDodajPracownika);
            this.tabPage4.Controls.Add(this.btnUsunPracownika);
            this.tabPage4.Controls.Add(this.dgvPracownik);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(875, 536);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pracownicy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnModyfikujPracownika
            // 
            this.btnModyfikujPracownika.Location = new System.Drawing.Point(714, 191);
            this.btnModyfikujPracownika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModyfikujPracownika.Name = "btnModyfikujPracownika";
            this.btnModyfikujPracownika.Size = new System.Drawing.Size(113, 19);
            this.btnModyfikujPracownika.TabIndex = 3;
            this.btnModyfikujPracownika.Text = "Modyfikuj Pracownika";
            this.btnModyfikujPracownika.UseVisualStyleBackColor = true;
            // 
            // btnDodajPracownika
            // 
            this.btnDodajPracownika.Location = new System.Drawing.Point(714, 119);
            this.btnDodajPracownika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajPracownika.Name = "btnDodajPracownika";
            this.btnDodajPracownika.Size = new System.Drawing.Size(113, 24);
            this.btnDodajPracownika.TabIndex = 2;
            this.btnDodajPracownika.Text = "Dodaj Pracownika";
            this.btnDodajPracownika.UseVisualStyleBackColor = true;
            // 
            // btnUsunPracownika
            // 
            this.btnUsunPracownika.Location = new System.Drawing.Point(714, 49);
            this.btnUsunPracownika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsunPracownika.Name = "btnUsunPracownika";
            this.btnUsunPracownika.Size = new System.Drawing.Size(113, 19);
            this.btnUsunPracownika.TabIndex = 1;
            this.btnUsunPracownika.Text = "Usuń Pracownika";
            this.btnUsunPracownika.UseVisualStyleBackColor = true;
            this.btnUsunPracownika.Click += new System.EventHandler(this.btnUsunPracownika_Click);
            // 
            // dgvPracownik
            // 
            this.dgvPracownik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracownik.Location = new System.Drawing.Point(18, 49);
            this.dgvPracownik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPracownik.Name = "dgvPracownik";
            this.dgvPracownik.RowTemplate.Height = 24;
            this.dgvPracownik.Size = new System.Drawing.Size(646, 161);
            this.dgvPracownik.TabIndex = 0;
            // 
            // GroupDaneKl
            // 
            this.GroupDaneKl.Controls.Add(this.txtNumerTelKl);
            this.GroupDaneKl.Controls.Add(this.label3);
            this.GroupDaneKl.Controls.Add(this.txtNazwiskoKl);
            this.GroupDaneKl.Controls.Add(this.label2);
            this.GroupDaneKl.Controls.Add(this.txtImieKl);
            this.GroupDaneKl.Controls.Add(this.label1);
            this.GroupDaneKl.Location = new System.Drawing.Point(17, 19);
            this.GroupDaneKl.Name = "GroupDaneKl";
            this.GroupDaneKl.Size = new System.Drawing.Size(135, 192);
            this.GroupDaneKl.TabIndex = 2;
            this.GroupDaneKl.TabStop = false;
            this.GroupDaneKl.Text = "Dane Klienta";
            // 
            // txtNazwiskoKl
            // 
            this.txtNazwiskoKl.Location = new System.Drawing.Point(8, 98);
            this.txtNazwiskoKl.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazwiskoKl.Name = "txtNazwiskoKl";
            this.txtNazwiskoKl.Size = new System.Drawing.Size(113, 20);
            this.txtNazwiskoKl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // txtNumerTelKl
            // 
            this.txtNumerTelKl.Location = new System.Drawing.Point(8, 151);
            this.txtNumerTelKl.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumerTelKl.Name = "txtNumerTelKl";
            this.txtNumerTelKl.Size = new System.Drawing.Size(113, 20);
            this.txtNumerTelKl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nr telefonu";
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
            this.GroupDaneRoweru.Location = new System.Drawing.Point(188, 19);
            this.GroupDaneRoweru.Name = "GroupDaneRoweru";
            this.GroupDaneRoweru.Size = new System.Drawing.Size(136, 250);
            this.GroupDaneRoweru.TabIndex = 3;
            this.GroupDaneRoweru.TabStop = false;
            this.GroupDaneRoweru.Text = "Dane Roweru";
            // 
            // txtNrSeryjny
            // 
            this.txtNrSeryjny.Location = new System.Drawing.Point(8, 151);
            this.txtNrSeryjny.Margin = new System.Windows.Forms.Padding(2);
            this.txtNrSeryjny.Name = "txtNrSeryjny";
            this.txtNrSeryjny.Size = new System.Drawing.Size(113, 20);
            this.txtNrSeryjny.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nr seryjny";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(8, 98);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(113, 20);
            this.txtModel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Model";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(8, 49);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(113, 20);
            this.txtMarka.TabIndex = 6;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(5, 34);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Marka";
            // 
            // txtKolor
            // 
            this.txtKolor.Location = new System.Drawing.Point(8, 204);
            this.txtKolor.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolor.Name = "txtKolor";
            this.txtKolor.Size = new System.Drawing.Size(113, 20);
            this.txtKolor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kolor";
            // 
            // GroupDaneNaprawy
            // 
            this.GroupDaneNaprawy.Controls.Add(this.radioPrzeglad);
            this.GroupDaneNaprawy.Controls.Add(this.radioNaprawa);
            this.GroupDaneNaprawy.Controls.Add(this.label8);
            this.GroupDaneNaprawy.Controls.Add(this.textBox1);
            this.GroupDaneNaprawy.Controls.Add(this.label6);
            this.GroupDaneNaprawy.Location = new System.Drawing.Point(25, 295);
            this.GroupDaneNaprawy.Name = "GroupDaneNaprawy";
            this.GroupDaneNaprawy.Size = new System.Drawing.Size(639, 212);
            this.GroupDaneNaprawy.TabIndex = 4;
            this.GroupDaneNaprawy.TabStop = false;
            this.GroupDaneNaprawy.Text = "Parametry naprawy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rodzaj usługi";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "• Przegląd rowerowy: 150 PLN",
            "• Hamulce: 20-80 PLN",
            "• "});
            this.listBox1.Location = new System.Drawing.Point(614, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 225);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 63);
            this.textBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Opis usługi";
            // 
            // dgvObecneNaprawy
            // 
            this.dgvObecneNaprawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObecneNaprawy.Location = new System.Drawing.Point(19, 38);
            this.dgvObecneNaprawy.Name = "dgvObecneNaprawy";
            this.dgvObecneNaprawy.Size = new System.Drawing.Size(597, 150);
            this.dgvObecneNaprawy.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(19, 19);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(88, 13);
            label9.TabIndex = 1;
            label9.Text = "Obecne naprawy";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(19, 217);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(151, 43);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Otwórz wybraną naprawę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dgvZakonczoneNaprawy
            // 
            this.dgvZakonczoneNaprawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakonczoneNaprawy.Location = new System.Drawing.Point(22, 350);
            this.dgvZakonczoneNaprawy.Name = "dgvZakonczoneNaprawy";
            this.dgvZakonczoneNaprawy.Size = new System.Drawing.Size(594, 150);
            this.dgvZakonczoneNaprawy.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(19, 334);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(110, 13);
            label10.TabIndex = 5;
            label10.Text = "Zakończone naprawy";
            // 
            // radioNaprawa
            // 
            this.radioNaprawa.AutoSize = true;
            this.radioNaprawa.Location = new System.Drawing.Point(21, 95);
            this.radioNaprawa.Name = "radioNaprawa";
            this.radioNaprawa.Size = new System.Drawing.Size(68, 17);
            this.radioNaprawa.TabIndex = 9;
            this.radioNaprawa.TabStop = true;
            this.radioNaprawa.Text = "Naprawa";
            this.radioNaprawa.UseVisualStyleBackColor = true;
            // 
            // radioPrzeglad
            // 
            this.radioPrzeglad.AutoSize = true;
            this.radioPrzeglad.Location = new System.Drawing.Point(21, 62);
            this.radioPrzeglad.Name = "radioPrzeglad";
            this.radioPrzeglad.Size = new System.Drawing.Size(66, 17);
            this.radioPrzeglad.TabIndex = 10;
            this.radioPrzeglad.TabStop = true;
            this.radioPrzeglad.Text = "Przegląd";
            this.radioPrzeglad.UseVisualStyleBackColor = true;
            // 
            // btnRozliczNaprawe
            // 
            this.btnRozliczNaprawe.Location = new System.Drawing.Point(641, 217);
            this.btnRozliczNaprawe.Name = "btnRozliczNaprawe";
            this.btnRozliczNaprawe.Size = new System.Drawing.Size(151, 43);
            this.btnRozliczNaprawe.TabIndex = 6;
            this.btnRozliczNaprawe.Text = "Zakończ i rozlicz naprawę";
            this.btnRozliczNaprawe.UseVisualStyleBackColor = true;
            // 
            // groupPodusmowanie
            // 
            this.groupPodusmowanie.Controls.Add(this.label14);
            this.groupPodusmowanie.Controls.Add(this.radioButton1);
            this.groupPodusmowanie.Controls.Add(this.label13);
            this.groupPodusmowanie.Controls.Add(this.label12);
            this.groupPodusmowanie.Controls.Add(this.label11);
            this.groupPodusmowanie.Location = new System.Drawing.Point(641, 19);
            this.groupPodusmowanie.Name = "groupPodusmowanie";
            this.groupPodusmowanie.Size = new System.Drawing.Size(200, 183);
            this.groupPodusmowanie.TabIndex = 7;
            this.groupPodusmowanie.TabStop = false;
            this.groupPodusmowanie.Text = "Podsumowanie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Koszt części:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Koszt robocizny:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Koszt całkowity:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rabat 10%";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Koszt ostateczny:";
            // 
            // btnDodajNaprawe
            // 
            this.btnDodajNaprawe.Location = new System.Drawing.Point(694, 457);
            this.btnDodajNaprawe.Name = "btnDodajNaprawe";
            this.btnDodajNaprawe.Size = new System.Drawing.Size(137, 50);
            this.btnDodajNaprawe.TabIndex = 6;
            this.btnDodajNaprawe.Text = "Utwórz naprawę";
            this.btnDodajNaprawe.UseVisualStyleBackColor = true;
            // 
            // dgvCzesci
            // 
            this.dgvCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzesci.Location = new System.Drawing.Point(18, 19);
            this.dgvCzesci.Name = "dgvCzesci";
            this.dgvCzesci.Size = new System.Drawing.Size(655, 295);
            this.dgvCzesci.TabIndex = 0;
            // 
            // btnUsunCzesc
            // 
            this.btnUsunCzesc.Location = new System.Drawing.Point(134, 87);
            this.btnUsunCzesc.Name = "btnUsunCzesc";
            this.btnUsunCzesc.Size = new System.Drawing.Size(90, 23);
            this.btnUsunCzesc.TabIndex = 1;
            this.btnUsunCzesc.Text = "Usun części";
            this.btnUsunCzesc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj części";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Ilość części";
            // 
            // groupCzesci
            // 
            this.groupCzesci.Controls.Add(this.label15);
            this.groupCzesci.Controls.Add(this.btnUsunCzesc);
            this.groupCzesci.Controls.Add(this.numericUpDown1);
            this.groupCzesci.Controls.Add(this.button1);
            this.groupCzesci.Location = new System.Drawing.Point(18, 331);
            this.groupCzesci.Name = "groupCzesci";
            this.groupCzesci.Size = new System.Drawing.Size(233, 134);
            this.groupCzesci.TabIndex = 5;
            this.groupCzesci.TabStop = false;
            this.groupCzesci.Text = "Edycja stanu magazynowego";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Serwis";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownik)).EndInit();
            this.GroupDaneKl.ResumeLayout(false);
            this.GroupDaneKl.PerformLayout();
            this.GroupDaneRoweru.ResumeLayout(false);
            this.GroupDaneRoweru.PerformLayout();
            this.GroupDaneNaprawy.ResumeLayout(false);
            this.GroupDaneNaprawy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneNaprawy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakonczoneNaprawy)).EndInit();
            this.groupPodusmowanie.ResumeLayout(false);
            this.groupPodusmowanie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupCzesci.ResumeLayout(false);
            this.groupCzesci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnModyfikujPracownika;
        private System.Windows.Forms.Button btnDodajPracownika;
        private System.Windows.Forms.Button btnUsunPracownika;
        private System.Windows.Forms.DataGridView dgvPracownik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImieKl;
        private System.Windows.Forms.GroupBox GroupDaneKl;
        private System.Windows.Forms.TextBox txtNumerTelKl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazwiskoKl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox GroupDaneNaprawy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GroupDaneRoweru;
        private System.Windows.Forms.TextBox txtKolor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNrSeryjny;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvZakonczoneNaprawy;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvObecneNaprawy;
        private System.Windows.Forms.RadioButton radioPrzeglad;
        private System.Windows.Forms.RadioButton radioNaprawa;
        private System.Windows.Forms.GroupBox groupPodusmowanie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRozliczNaprawe;
        private System.Windows.Forms.Button btnDodajNaprawe;
        private System.Windows.Forms.GroupBox groupCzesci;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUsunCzesc;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCzesci;
    }
}

