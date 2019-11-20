using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plataformacadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrocliente cliente = new cadastrocliente();
            cliente.ShowDialog();
            this.Close();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrocliente cliente = new cadastrocliente();
            cliente.ShowDialog();
            this.Close();
        }

        private void pictureBoxProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastroproduto produto = new cadastroproduto();
            produto.ShowDialog();
            this.Close();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastroproduto produto = new cadastroproduto();
            produto.ShowDialog();
            this.Close();
        }
    }
}
