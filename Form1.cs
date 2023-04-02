﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwisRowerowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsunPracownika_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć Pracownika?", "Potwierdź usunięcie Pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {  
                
            }
            else
            {

            }
        }

        private void btnDodajNaprawe_Click(object sender, EventArgs e)
        {
            
            btnDodajNowyRower.Visible = true;
            GroupDaneRoweru.Visible = false;
        }

        private void btnDodajNowyRower_Click(object sender, EventArgs e)
        {
            GroupDaneRoweru.Visible = true;
            btnDodajNowyRower.Visible = false;
        }

        private void btnNowaNaprawa_Click(object sender, EventArgs e)
        {
            Naprawa naprawa= new Naprawa();
            naprawa.Show();
        }
    }
}
