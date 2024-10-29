using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInventary.Model.DAO.Provider;
using SystemInventary.View.ProviderViews;

namespace SystemInventary.Controller.Provider
{
    internal class ControllerProvider
    {

        FrmProvider objProvider;

        public ControllerProvider(FrmProvider view)
        {
            objProvider = view;

            objProvider.Load += new EventHandler(ChargeData);

        }

        public void ChargeData(object sender, EventArgs e) 
        {
            RefreshData();
        }

        public void RefreshData()
        {
            DAOProvider dAOProvider = new DAOProvider();

            DataSet answer = dAOProvider.ChargeData();

            objProvider.dgvProvider.DataSource = answer.Tables["tbSuppliers"];
            objProvider.dgvProvider.ReadOnly = true;
        }
    }
}
