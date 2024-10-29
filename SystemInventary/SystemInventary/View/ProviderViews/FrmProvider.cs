using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemInventary.Controller.Provider;

namespace SystemInventary.View.ProviderViews
{
    public partial class FrmProvider : Form
    {
        public FrmProvider()
        {
            InitializeComponent();
            ControllerProvider provider = new ControllerProvider(this);
        }
    }
}
