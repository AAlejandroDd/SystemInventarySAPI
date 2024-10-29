using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInventary.Model.DAO.Inventory;
using SystemInventary.View.Inventory;

namespace SystemInventary.Controller.Inventory
{
    internal class ControllerInventory
    {

        FrmInventory objInventory;

        public ControllerInventory(FrmInventory view)
        {
            objInventory = view;

            objInventory.Load += new EventHandler(ChargeData);
        }

        public void ChargeData(object sender, EventArgs e) 
        {
            RefreshData();
        }

        public void RefreshData()
        {
            DAOInventory dAOInventory = new DAOInventory();

            DataSet answer = dAOInventory.ChargeData();

            objInventory.dgvInventory.DataSource = answer.Tables["tbProducts"];
        }
    }
}
