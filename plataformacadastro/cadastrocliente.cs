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
    public partial class cadastrocliente : Form
    {
        public cadastrocliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("deseja voltar?", "retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            /*DialogResult Yes = default;
            if (DialogResult == Yes)*/
            if (escolha == DialogResult.Yes)
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
        }

       
    }
}
