﻿using System;
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