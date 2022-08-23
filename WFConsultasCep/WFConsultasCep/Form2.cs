using System;
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
    public partial class Form2 : Form
    {
        public string Endereco
        {
            get { return txtEndereco.Text; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var webService = new WSCorreios.AtendeClienteClient();
                var res = webService.consultaCEP(txtCep.Text);
                txtEndereco.Text = res.end;
                txtBairro.Text = res.bairro;
                txtComplemento.Text = res.complemento2;
                txtCidade.Text = res.cidade;
                txtEstado.Text = res.uf;
            }
            
                catch (Exception ex)
            { 
                    MessageBox.Show(ex.Message);
            }
        
        }
    }
}
