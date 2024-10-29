using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemInventary.Controller.Login;
using SystemInventary.CustomControls;

namespace SystemInventary.View.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            ControllerLogin login = new ControllerLogin(this);
        }


    }
}
