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

            if (mskNascimento.Text == "00-00-0000")
            {
                MessageBox.Show("O CAMPO NASCIMENTO DEVE ESTAR PREENCHIDO", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvPessoas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvPessoas.CurrentRow.Selected = true;
                //txtId.Text = dgvPessoas.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtNome.Text = dgvPessoas.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                txtEndereco.Text = dgvPessoas.Rows[e.RowIndex].Cells["endereco"].FormattedValue.ToString();
                mskNascimento.Text = dgvPessoas.Rows[e.RowIndex].Cells["data_nacimento"].FormattedValue.ToString();
                mskTxtBoxTelefone.Text = dgvPessoas.Rows[e.RowIndex].Cells["telefone"].FormattedValue.ToString();
                
            }
            

            
        }
    }
}
