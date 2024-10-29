using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemInventary.Controller.Employee;

namespace SystemInventary.View.Employee
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
            ControllerEmployees Employee = new ControllerEmployees(this);
        }

    }
}
