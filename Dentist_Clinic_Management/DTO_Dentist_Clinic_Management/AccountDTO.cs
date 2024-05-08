using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dentist_Clinic_Management.DTO_Dentist_Clinic_Management
{
    public class AccountDTO
    {
        private string _id;
        private string _name;
        private string _role;
        private string _pass;
        private string _lock;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Role { get => _role; set => _role = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Lock { get => _lock; set => _lock = value; }


    }
}
