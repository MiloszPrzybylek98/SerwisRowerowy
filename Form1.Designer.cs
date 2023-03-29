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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvObecneNaprawy = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvZakonczoneNaprawy = new System.Windows.Forms.DataGridView();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownik)).BeginInit();
            this.GroupDaneKl.SuspendLayout();
            this.GroupDaneRoweru.SuspendLayout();
            this.GroupDaneNaprawy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneNaprawy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakonczoneNaprawy)).BeginInit();
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
            this.btnDodajPracownika.Size = new System.Drawing.Size(113, 19);
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
            this.GroupDaneNaprawy.Controls.Add(this.label8);
            this.GroupDaneNaprawy.Controls.Add(this.textBox1);
            this.GroupDaneNaprawy.Controls.Add(this.checkedListBox1);
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
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(21, 49);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 5;
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
            this.textBox1.Size = new System.Drawing.Size(207, 94);
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
            this.dgvObecneNaprawy.Size = new System.Drawing.Size(459, 150);
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
            this.btnDodaj.Location = new System.Drawing.Point(19, 208);
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
            this.dgvZakonczoneNaprawy.Size = new System.Drawing.Size(459, 150);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
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
    }
}

