using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInventary.Model.DAO.Employee;
using SystemInventary.View.Employee;

namespace SystemInventary.Controller.Employee
{
    internal class ControllerEmployees
    {
        FrmEmployees objEmployees;

        public ControllerEmployees(FrmEmployees view)
        {
            objEmployees = view;

            objEmployees.Load += new EventHandler(ChargeData);

        }

        public void ChargeData(object sender, EventArgs e) 
        {
            RefreshData();
        }

        public void RefreshData()
        {
            DAOEmployee dAOEmployee = new DAOEmployee();

            DataSet answer = dAOEmployee.ChargeData();

            objEmployees.dgvEmployees.DataSource = answer.Tables["tbEmployee"];
        }
    }
}
