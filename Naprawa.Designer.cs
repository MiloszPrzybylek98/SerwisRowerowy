namespace SerwisRowerowy
{
    partial class Naprawa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.GroupDaneNaprawy = new System.Windows.Forms.GroupBox();
            this.lblKolor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNrSeryjny = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOpisNaprawy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioPrzeglad = new System.Windows.Forms.RadioButton();
            this.radioNaprawa = new System.Windows.Forms.RadioButton();
            this.dgvCzesci = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupCzesci = new System.Windows.Forms.GroupBox();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numIleCzesci = new System.Windows.Forms.NumericUpDown();
            this.btnUsunCzesci = new System.Windows.Forms.Button();
            this.btnDodajCzesci = new System.Windows.Forms.Button();
            this.btnZapiszNaprawe = new System.Windows.Forms.Button();
            this.listUslugi = new System.Windows.Forms.ListBox();
            this.GroupDaneNaprawy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupCzesci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIleCzesci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis: ";
            // 
            // GroupDaneNaprawy
            // 
            this.GroupDaneNaprawy.Controls.Add(this.lblKolor);
            this.GroupDaneNaprawy.Controls.Add(this.label9);
            this.GroupDaneNaprawy.Controls.Add(this.lblNrSeryjny);
            this.GroupDaneNaprawy.Controls.Add(this.label7);
            this.GroupDaneNaprawy.Controls.Add(this.lblModel);
            this.GroupDaneNaprawy.Controls.Add(this.label5);
            this.GroupDaneNaprawy.Controls.Add(this.lblMarka);
            this.GroupDaneNaprawy.Controls.Add(this.label3);
            this.GroupDaneNaprawy.Controls.Add(this.lblOpisNaprawy);
            this.GroupDaneNaprawy.Controls.Add(this.label1);
            this.GroupDaneNaprawy.Location = new System.Drawing.Point(12, 12);
            this.GroupDaneNaprawy.Name = "GroupDaneNaprawy";
            this.GroupDaneNaprawy.Size = new System.Drawing.Size(818, 100);
            this.GroupDaneNaprawy.TabIndex = 1;
            this.GroupDaneNaprawy.TabStop = false;
            this.GroupDaneNaprawy.Text = "Dane naprawy";
            // 
            // lblKolor
            // 
            this.lblKolor.AutoSize = true;
            this.lblKolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKolor.Location = new System.Drawing.Point(629, 54);
            this.lblKolor.Name = "lblKolor";
            this.lblKolor.Size = new System.Drawing.Size(19, 13);
            this.lblKolor.TabIndex = 10;
            this.lblKolor.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kolor:";
            // 
            // lblNrSeryjny
            // 
            this.lblNrSeryjny.AutoSize = true;
            this.lblNrSeryjny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNrSeryjny.Location = new System.Drawing.Point(449, 54);
            this.lblNrSeryjny.Name = "lblNrSeryjny";
            this.lblNrSeryjny.Size = new System.Drawing.Size(19, 13);
            this.lblNrSeryjny.TabIndex = 8;
            this.lblNrSeryjny.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nr seryjny:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModel.Location = new System.Drawing.Point(239, 54);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(19, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Model:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarka.Location = new System.Drawing.Point(58, 54);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(19, 13);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka:";
            // 
            // lblOpisNaprawy
            // 
            this.lblOpisNaprawy.AutoSize = true;
            this.lblOpisNaprawy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpisNaprawy.Location = new System.Drawing.Point(70, 25);
            this.lblOpisNaprawy.Name = "lblOpisNaprawy";
            this.lblOpisNaprawy.Size = new System.Drawing.Size(19, 13);
            this.lblOpisNaprawy.TabIndex = 2;
            this.lblOpisNaprawy.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usługi";
            // 
            // radioPrzeglad
            // 
            this.radioPrzeglad.AutoSize = true;
            this.radioPrzeglad.Location = new System.Drawing.Point(12, 131);
            this.radioPrzeglad.Name = "radioPrzeglad";
            this.radioPrzeglad.Size = new System.Drawing.Size(66, 17);
            this.radioPrzeglad.TabIndex = 12;
            this.radioPrzeglad.TabStop = true;
            this.radioPrzeglad.Text = "Przegląd";
            this.radioPrzeglad.UseVisualStyleBackColor = true;
            // 
            // radioNaprawa
            // 
            this.radioNaprawa.AutoSize = true;
            this.radioNaprawa.Location = new System.Drawing.Point(116, 131);
            this.radioNaprawa.Name = "radioNaprawa";
            this.radioNaprawa.Size = new System.Drawing.Size(68, 17);
            this.radioNaprawa.TabIndex = 13;
            this.radioNaprawa.TabStop = true;
            this.radioNaprawa.Text = "Naprawa";
            this.radioNaprawa.UseVisualStyleBackColor = true;
            // 
            // dgvCzesci
            // 
            this.dgvCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzesci.Location = new System.Drawing.Point(9, 70);
            this.dgvCzesci.MultiSelect = false;
            this.dgvCzesci.Name = "dgvCzesci";
            this.dgvCzesci.ReadOnly = true;
            this.dgvCzesci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCzesci.Size = new System.Drawing.Size(305, 204);
            this.dgvCzesci.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(305, 204);
            this.dataGridView1.TabIndex = 15;
            // 
            // groupCzesci
            // 
            this.groupCzesci.Controls.Add(this.txtFiltr);
            this.groupCzesci.Controls.Add(this.label6);
            this.groupCzesci.Controls.Add(this.label4);
            this.groupCzesci.Controls.Add(this.numIleCzesci);
            this.groupCzesci.Controls.Add(this.btnUsunCzesci);
            this.groupCzesci.Controls.Add(this.btnDodajCzesci);
            this.groupCzesci.Controls.Add(this.dgvCzesci);
            this.groupCzesci.Controls.Add(this.dataGridView1);
            this.groupCzesci.Location = new System.Drawing.Point(12, 307);
            this.groupCzesci.Name = "groupCzesci";
            this.groupCzesci.Size = new System.Drawing.Size(818, 284);
            this.groupCzesci.TabIndex = 16;
            this.groupCzesci.TabStop = false;
            this.groupCzesci.Text = "Cześci do naprawy";
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(9, 44);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(100, 20);
            this.txtFiltr.TabIndex = 22;
            this.txtFiltr.TextChanged += new System.EventHandler(this.txtFiltr_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Wyszukaj część";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ile części";
            // 
            // numIleCzesci
            // 
            this.numIleCzesci.Location = new System.Drawing.Point(348, 82);
            this.numIleCzesci.Name = "numIleCzesci";
            this.numIleCzesci.Size = new System.Drawing.Size(120, 20);
            this.numIleCzesci.TabIndex = 18;
            // 
            // btnUsunCzesci
            // 
            this.btnUsunCzesci.Location = new System.Drawing.Point(390, 159);
            this.btnUsunCzesci.Name = "btnUsunCzesci";
            this.btnUsunCzesci.Size = new System.Drawing.Size(48, 23);
            this.btnUsunCzesci.TabIndex = 17;
            this.btnUsunCzesci.Text = "<<<";
            this.btnUsunCzesci.UseVisualStyleBackColor = true;
            // 
            // btnDodajCzesci
            // 
            this.btnDodajCzesci.Location = new System.Drawing.Point(390, 130);
            this.btnDodajCzesci.Name = "btnDodajCzesci";
            this.btnDodajCzesci.Size = new System.Drawing.Size(48, 23);
            this.btnDodajCzesci.TabIndex = 16;
            this.btnDodajCzesci.Text = ">>>";
            this.btnDodajCzesci.UseVisualStyleBackColor = true;
            this.btnDodajCzesci.Click += new System.EventHandler(this.btnDodajCzesci_Click);
            // 
            // btnZapiszNaprawe
            // 
            this.btnZapiszNaprawe.Location = new System.Drawing.Point(21, 597);
            this.btnZapiszNaprawe.Name = "btnZapiszNaprawe";
            this.btnZapiszNaprawe.Size = new System.Drawing.Size(193, 32);
            this.btnZapiszNaprawe.TabIndex = 17;
            this.btnZapiszNaprawe.Text = "Zapisz naprawę";
            this.btnZapiszNaprawe.UseVisualStyleBackColor = true;
            this.btnZapiszNaprawe.Click += new System.EventHandler(this.btnZapiszNaprawe_Click);
            // 
            // listUslugi
            // 
            this.listUslugi.ColumnWidth = 150;
            this.listUslugi.FormattingEnabled = true;
            this.listUslugi.Location = new System.Drawing.Point(12, 181);
            this.listUslugi.MultiColumn = true;
            this.listUslugi.Name = "listUslugi";
            this.listUslugi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listUslugi.Size = new System.Drawing.Size(809, 108);
            this.listUslugi.TabIndex = 19;
            // 
            // Naprawa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 652);
            this.Controls.Add(this.listUslugi);
            this.Controls.Add(this.btnZapiszNaprawe);
            this.Controls.Add(this.groupCzesci);
            this.Controls.Add(this.radioNaprawa);
            this.Controls.Add(this.radioPrzeglad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupDaneNaprawy);
            this.Name = "Naprawa";
            this.Text = "Naprawa";
            this.Load += new System.EventHandler(this.Naprawa_Load);
            this.GroupDaneNaprawy.ResumeLayout(false);
            this.GroupDaneNaprawy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupCzesci.ResumeLayout(false);
            this.groupCzesci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIleCzesci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupDaneNaprawy;
        private System.Windows.Forms.Label lblKolor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNrSeryjny;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOpisNaprawy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioPrzeglad;
        private System.Windows.Forms.RadioButton radioNaprawa;
        private System.Windows.Forms.DataGridView dgvCzesci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupCzesci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numIleCzesci;
        private System.Windows.Forms.Button btnUsunCzesci;
        private System.Windows.Forms.Button btnDodajCzesci;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapiszNaprawe;
        private System.Windows.Forms.ListBox listUslugi;
    }
}