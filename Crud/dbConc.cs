﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Crud
{
    class dbConc
    {
        string conexao = "Server=localhost;Database=pessoa;Uid=root;Pwd=Brasileiro55@";
        public MySqlConnection AbrirBanco()
        {
            MySqlConnection cn = new MySqlConnection(conexao);
            cn.Open();
            return cn;
        }
        public void FecharBanco(MySqlConnection cn)
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();

        }
     
    }
}

