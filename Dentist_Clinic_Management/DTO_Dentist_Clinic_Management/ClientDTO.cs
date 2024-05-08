using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management.DTO_Dentist_Clinic_Management
{
    internal class ClientDTO
    {
        private string _id;
        private string _birth;
        private string _addr;
        private string _phone;

        public string Id { get => _id; set => _id = value; }
        public string Birth { get => _birth; set => _birth = value; }
        public string Addr { get => _addr; set => _addr = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
