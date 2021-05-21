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
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WinoStock
{
    public partial class frmLogin : Form
    {
        Conexao con = new Conexao();
        string id, user, password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblDev_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (txtUsuario.Text != "" && txtSenha.Text != "")
                    {

                        con.Open();
                        string query = "SELECT id,user,password FROM users WHERE user ='" + txtUsuario.Text + "' AND password ='" + txtSenha.Text + "'";
                        MySqlDataReader row;
                        row = con.ExecuteReader(query);
                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                id = row["id"].ToString();
                                user = row["user"].ToString();
                                password = row["password"].ToString();
                            }
                            MessageBox.Show("Bem-vindo " + user);
                            this.Hide();
                            var menu = new frmMenu();
                            menu.Show();

                        }
                        else
                        {
                            MessageBox.Show("Dados não encontrados, favor contatar os Desenvolvedores", "Informação");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou Senha invalido", "Informação");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro Catastrofico", "Informação");
                }
            }
        }
    }
}
