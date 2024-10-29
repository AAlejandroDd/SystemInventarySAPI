using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemInventary.Controller.Inventory;

namespace SystemInventary.View.Inventory
{
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
            ControllerInventory inventory = new ControllerInventory(this);
        }
    }
}
