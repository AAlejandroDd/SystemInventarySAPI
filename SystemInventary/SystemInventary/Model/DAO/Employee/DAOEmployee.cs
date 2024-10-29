using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInventary.Model.DTO.Employee;

namespace SystemInventary.Model.DAO.Employee
{
    internal class DAOEmployee : DTOEmployee
    {
        readonly SqlCommand command = new SqlCommand();

        public DataSet ChargeData()
        {
            try
            {
                command.Connection = getConnection();

                string query = "Select * From tbEmployee";

                SqlCommand cmd = new SqlCommand(query, command.Connection);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adp.Fill(ds, "tbEmployee");

                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
