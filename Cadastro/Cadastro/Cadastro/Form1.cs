using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_Nome.Enabled = true;
            txt_sobrenome.Enabled = true;
            txt_Email.Enabled = true;
            txt_dateTimePicker1.Enabled = true;
            txt_telefone.Enabled = true;
            txt_Endereco.Enabled = true;
        }

        SqlConnection sqlcon = null;
        private string StrCon = ""; //Codigo Conexão
        private string StrSql = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_Nome.Enabled            = true;
            txt_sobrenome.Enabled       = true;
            txt_Email.Enabled           = true;
            txt_dateTimePicker1.Enabled = true;
            txt_telefone.Enabled        = true;
            txt_Endereco.Enabled        = true;

            StrSql = "insert into table (Nome,Sobrenome,Email,DataNascimento,Telefone,Endereco) values (@Nome,@Sobrenome,@Email,@dateTimePicker1,@telefone,@Endereco)";

            sqlcon = new SqlConnection(StrCon);

            SqlCommand comando = new SqlCommand(StrSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_Nome.Text;
            comando.Parameters.Add("@Sobrenome", SqlDbType.VarChar).Value = txt_sobrenome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_Email.Text;
            comando.Parameters.Add("@dateTimePicker1", SqlDbType.Date).Value = txt_dateTimePicker1.DataBindings;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_telefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_Endereco.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }


            txt_Nome.Clear();
            txt_sobrenome.Clear();
            txt_Email.Clear();
            //txt_dateTimePicker1.Clear();
            txt_telefone.Clear();
            txt_Endereco.Clear();

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            StrSql = "SELECT * FROM TABLE WHERE NOME = @NOME AND @dateTimePicker1";

            sqlcon = new SqlConnection(StrCon);

            SqlCommand comando = new SqlCommand(StrSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_Nome.Text;
            comando.Parameters.Add("@Sobrenome", SqlDbType.VarChar).Value = txt_sobrenome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_Email.Text;
            comando.Parameters.Add("@dateTimePicker1", SqlDbType.Date).Value = txt_dateTimePicker1.DataBindings;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_telefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_Endereco.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                //MessageBox.Show("Cadastro Realizado.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            StrSql = "DELETE FROM TABLE WHERE Nome = @Nome and DataNascimento = @dateTimePicker1";

            sqlcon = new SqlConnection(StrCon);

            SqlCommand comando = new SqlCommand(StrSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_Nome.Text;
            comando.Parameters.Add("@Sobrenome", SqlDbType.VarChar).Value = txt_sobrenome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_Email.Text;
            comando.Parameters.Add("@dateTimePicker1", SqlDbType.Date).Value = txt_dateTimePicker1.DataBindings;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_telefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_Endereco.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                //MessageBox.Show("Cadastro Realizado.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            StrSql = "UPDATE TABLE SET Nome = @Nome,Sobrenome = @Sobrenome,Email = @Email,@DataNascimento = @dateTimePicker1,Telefone = @Telefone,Endereco = @Endereco  WHERE Nome = @Nome and DataNascimento = @dateTimePicker1";


            sqlcon = new SqlConnection(StrCon);

            SqlCommand comando = new SqlCommand(StrSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_Nome.Text;
            comando.Parameters.Add("@Sobrenome", SqlDbType.VarChar).Value = txt_sobrenome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_Email.Text;
            comando.Parameters.Add("@dateTimePicker1", SqlDbType.Date).Value = txt_dateTimePicker1.DataBindings;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_telefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_Endereco.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                //MessageBox.Show("Cadastro Realizado.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

