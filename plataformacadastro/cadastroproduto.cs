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
    public partial class cadastroproduto : Form
    {
        public cadastroproduto()
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

            if (escolha.ToString().ToLower() == "yes") ;

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo, nome, descricao, preco, estoque, unidade, tipo;
                codigo = textBoxCodigo.Text;
                nome = textBoxNomeProduto.Text;
                descricao = richTextBoxDescricao.Text;
                estoque = textBoxEstoque.Text;
                preco = textBoxPreco.Text;
                unidade = textBoxUnidade.Text;
                tipo = comboBoxTipo.Text;

                if(string.IsNullOrWhiteSpace(codigo) || textBoxCodigo.Text == "Digite o Código de barras")
                {
                    throw new Exception("Código de barras vazio");
                }

                try
                {
                    Convert.ToInt64(codigo);
                }

                catch
                {
                    throw new Exception("Código de barras deve ser número");
                }

                if(codigo.Length != 13)
                {
                     throw new Exception("Código de barras deve ter 13 números");
                }

                if (string.IsNullOrWhiteSpace(nome))
                {
                    throw new Exception("Nome vazio");
                }

                if (string.IsNullOrWhiteSpace(descricao))
                {
                    throw new Exception("Descrição vazio");
                }

                if (string.IsNullOrWhiteSpace(preco))
                {
                    throw new Exception("Preço vazio");
                }

                try
                {
                    Convert.ToDouble(preco);
                }

                catch
                {
                    throw new Exception("Preço deve ser número");
                }

                if (string.IsNullOrWhiteSpace(estoque))
                {
                    throw new Exception("Estoque vazio");
                }


                try
                {
                    Convert.ToInt16(estoque);
                }

                catch
                {
                    throw new Exception("Estoque deve ser número");
                }

                if (string.IsNullOrWhiteSpace(unidade))
                {
                    throw new Exception("Unidade vazio");
                }


                try
                {
                    Convert.ToInt16(unidade);
                }

                catch
                {
                    throw new Exception("Unidade deve ser número");
                }

                if (string.IsNullOrWhiteSpace(tipo))
                {
                    throw new Exception("Tipo vazio");
                }

                MessageBox.Show("Cadastro efetuado com sucesso","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //textBoxCodigo = "";
            textBoxCodigo.Clear();
            textBoxNomeProduto.Clear();
            richTextBoxDescricao.Clear();
            textBoxEstoque.Clear();
            textBoxPreco.Clear();
            textBoxUnidade.Clear();
            comboBoxTipo.SelectedIndex = -1;
            textBoxCodigo.Focus();//VOLTA O CURSOR PARA ESTE TEXTBOX.
        }

        private void buttonLimparCliente_Click(object sender, EventArgs e)
        {
            //textBoxCodigo = "";
            textBoxCodigo.Clear();
            textBoxNomeProduto.Clear();
            richTextBoxDescricao.Clear();
            textBoxEstoque.Clear();
            textBoxPreco.Clear();
            textBoxUnidade.Clear();
            comboBoxTipo.SelectedIndex = -1;
            textBoxCodigo.Focus();//VOLTA O CURSOR PARA ESTE TEXTBOX.
        }
    }
}
