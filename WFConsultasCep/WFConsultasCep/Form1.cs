﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFConsultasCep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
            txtendereco.Text = form2.Endereco;
        }
    }
}
