﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class CondominosAdm : Form
    {
        public string Adm { get; set;  }

        public CondominosAdm(string adm)
        {
            InitializeComponent();
            this.Adm = adm; 
        }

        private void BtnMulta_Click(object sender, EventArgs e)
        {
            AdicionarMulta addMulta = new AdicionarMulta(Adm);
            addMulta.ShowDialog(); 
        }
    }
}
