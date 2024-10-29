using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInventary.Model.DTO.Inventory;

namespace SystemInventary.Model.DAO.Inventory
{
    internal class DAOInventory : DTOInventory
    {

        readonly SqlCommand command = new SqlCommand();

        public DataSet ChargeData()
        {

            try
            {

                command.Connection = getConnection();

                string query = "Select * From tbProducts";

                SqlCommand cmd = new SqlCommand(query, command.Connection);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adp.Fill(ds, "tbProducts");

                return ds;

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
