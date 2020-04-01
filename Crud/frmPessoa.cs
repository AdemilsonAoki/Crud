using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }
        Pessoa pessoa = new Pessoa();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            pessoa.Nome = txtNome.Text;
            pessoa.Nascimento = DateTime.Parse(mskNascimento.Text);
            pessoa.Endereco = txtEndereco.Text;
            pessoa.Telefone = mskTxtBoxTelefone.Text;
            
            if (txtNome.Text == "")
            {
                MessageBox.Show("O CAMPO NOME DEVE ESTAR PREENCHIDO", "NOME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Select();
                return;
            }

            if (mskNascimento.Text == "")
            {
                MessageBox.Show("O CAMPO E-MAIL DEVE ESTAR PREENCHIDO", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNascimento.Select();
                return;
            }

            //VA
           if(txtNome.Text != " " &&  mskNascimento.Text != " ")

            pessoa.Cadastrar();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmLogin logi = new frmLogin();
            this.Hide();
            logi.Show();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            pessoa.Dados = dgvPessoas;

            pessoa.Listar();
        }
    }
}
