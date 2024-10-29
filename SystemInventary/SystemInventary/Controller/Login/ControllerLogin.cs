using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInventary.Model.DAO.Provider;
using SystemInventary.View.Login;
using SystemInventary.Model;
using SystemInventary.View.StartMenu;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SystemInventary.Controller.Login
{
    internal class ControllerLogin : dbContext
    {
        FrmLogin objLogin;

        readonly SqlCommand command = new SqlCommand();

        public ControllerLogin(FrmLogin view)
        {
            objLogin = view;

            objLogin.btnLogin.Click += new EventHandler(Login);
            objLogin.btnConnection.Click += new EventHandler(tryConnection);
            objLogin.btnClose.Click += new EventHandler(Close);

        }

        public void Close(object sender, EventArgs e)
        {
            objLogin.Close();
        }

        public void tryConnection(object sender, EventArgs e)
        {

            command.Connection = getConnection();

            if(command.Connection != null)
            {
                MessageBox.Show("Conexión exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public void Login(object sender, EventArgs e)
        {
            objLogin.Close();
            StartMenu objStartMenu = new StartMenu();
            objStartMenu.ShowDialog();

        }
    }
}
