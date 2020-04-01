using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Crud
{
    class Pessoa

    {
        private DateTime  nascimento;
        private string nome;
        private string endereco;
        private string telefone;
        private DataGridView dados;
        



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public DateTime Nascimento
        {
            
            get { return nascimento; }
            set { nascimento = value; }
        }  
        public DataGridView Dados
        {
            
            get { return dados; }
            set { dados = value; }
        }

        dbConc conexao = new dbConc();
        MySqlCommand comando;
        public void Cadastrar()
        {

          
            bool cad = false;
            try
            {
               

                string strSql = "INSERT INTO PESSOAS (nome, data_nacimento, endereco, telefone) " +
                    "VALUES ('" + nome + "','" + nascimento.ToString("yyyy-MM-dd") + "','" + endereco + "' , '" + telefone + "')";
                comando = new MySqlCommand(strSql, conexao.AbrirBanco());
                comando.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cad = false;
            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());
                conexao = null;
                comando = null;
            }
            if(cad == true)
            {
                MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());
            }

        }
        public void Alterar()
        {

        }
        public void Excluir()
        {

        }
        public void Listar()
        {
            string strMySql = "SELECT *FROM PESSOAS";
            comando = new MySqlCommand(strMySql, conexao.AbrirBanco());
            
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                DataTable dtLista = new DataTable();

                da.Fill(dtLista);

                dados.DataSource = dtLista;



            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

    }
}
