﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SystemInventary.Model
{
    internal class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {

                string server = "PC-GERARDO\\SQLEXPRESS";
                string database = "DBSAPI12024";

                SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; Integrated Security = true");
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Código de error: EC-001 \nNo fue posible conectarse a la base de datos, favor verifique las credenciales o que tenga acceso al sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
