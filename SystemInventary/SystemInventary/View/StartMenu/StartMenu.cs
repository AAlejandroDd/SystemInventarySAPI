﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemInventary.Controller.Start;

namespace SystemInventary.View.StartMenu
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            ControllerStartMenu start = new ControllerStartMenu(this);
        }
    }
}
