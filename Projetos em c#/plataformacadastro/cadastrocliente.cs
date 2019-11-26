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

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {
            string sexo;

            if(radioButtonMasculino.Checked==true)
            {
                sexo = radioButtonMasculino.Text;
            }
        }

        private void radioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {
            string sexo;

            if (radioButtonFeminino.Checked == true)
            {
                sexo = radioButtonFeminino.Text;
            }
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf, nome, rg, cep, bairro, cidade, estado, numero, endereco, telefone, senha, confirmarSenha;
                nome = textBoxNomeCliente.Text;
                cpf = maskedTextBoxCpf.Text;
                rg = maskedTextBoxRg.Text;
                endereco = textBoxEndereco.Text;
                numero = maskedTextBoxTelefone.Text;
                bairro = textBoxBairro.Text;
                cep = maskedTextBoxCep.Text;
                cidade = textBoxCidade.Text;
                estado = comboBoxEstado.Text;
                telefone = maskedTextBoxTelefone.Text;
                estado = comboBoxEstado.Text;
                senha = textBoxConfirmarSenha.Text;
                confirmarSenha = textBoxConfirmarSenha.Text;

                if (string.IsNullOrWhiteSpace(nome))
                {
                    throw new Exception("Nome vazio");
                }

                if (string.IsNullOrWhiteSpace(cpf))
                {
                    throw new Exception("CPF vazio");
                }

                try
                {
                    Convert.ToInt64(cpf);
                }

                catch
                {
                    throw new Exception("CPF deve ser número");
                }

                if (cpf.Length != 11)
                {
                    throw new Exception("O CPF deve ter 11 números");
                }

                if (string.IsNullOrWhiteSpace(rg))
                {
                    throw new Exception("Descrição vazio");
                }

                try
                {
                    Convert.ToInt64(rg);
                }

                catch
                {
                    throw new Exception("RG deve ser número");
                }

                if (string.IsNullOrWhiteSpace(endereco))
                {
                    throw new Exception("Endereço vazio");
                }

                if (string.IsNullOrWhiteSpace(numero))
                {
                    throw new Exception("Número vazio");
                }

                try
                {
                    Convert.ToInt64(numero);
                }

                catch
                {
                    throw new Exception("O campo Numero deve conter somente números");
                }

                if (string.IsNullOrWhiteSpace(bairro))
                {
                    throw new Exception("Bairro vazio");
                }

                if (string.IsNullOrWhiteSpace(cep))
                {
                    throw new Exception("CEP vazio");
                }

                try
                {
                    Convert.ToInt32(cep);
                }

                catch
                {
                    throw new Exception("CEP deve ser número");
                }

                if (radioButtonFeminino.Checked == false & radioButtonMasculino.Checked == false)
                {
                    throw new Exception("Você deve selecionar um sexo");
                }

                if (string.IsNullOrWhiteSpace(senha))
                {
                    throw new Exception("Senha vazio");
                }

                if (string.IsNullOrWhiteSpace(confirmarSenha))
                {
                    throw new Exception("Confirmar Senha vazio");
                }

                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxNomeCliente.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxRg.Clear();
            textBoxEndereco.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            maskedTextBoxCep.Clear();
            textBoxCidade.Clear();
            comboBoxEstado.SelectedIndex = -1;
            maskedTextBoxTelefone.Clear();
            textBoxNomeCliente.Focus();
        }

        private void buttonLimparCliente_Click(object sender, EventArgs e)
        {
            textBoxNomeCliente.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxRg.Clear();
            textBoxEndereco.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            maskedTextBoxCep.Clear();
            textBoxCidade.Clear();
            comboBoxEstado.SelectedIndex = -1;
            maskedTextBoxTelefone.Clear();
            textBoxNomeCliente.Focus();
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxSenha.PasswordChar = '*';
        }

        private void textBoxConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxConfirmarSenha.PasswordChar = '*';
        }
    }
}
