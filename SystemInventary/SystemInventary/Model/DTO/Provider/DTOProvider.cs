using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInventary.Model.DTO.Provider
{
    internal class DTOProvider : dbContext
    {
        private int id;
        private string company;
        private string name;
        private string phone;
        private string email;
        private string address;
        private string nIT;
        private bool status;
        private string notes;

        public int Id { get => id; set => id = value; }
        public string Company { get => company; set => company = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string NIT { get => nIT; set => nIT = value; }
        public bool Status { get => status; set => status = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
