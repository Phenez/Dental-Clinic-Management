using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management.DTO_Dentist_Clinic_Management
{
    public class AppointDTO
    {
        private string _id;
        private DateTime _date;
        private string _id2;
        private string _id3;
        private string _datebook;
        private string _status;

        public string Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Id2 { get => _id2; set => _id2 = value; }
        public string Id3 { get => _id3; set => _id3 = value; }
        public string Datebook { get => _datebook; set => _datebook = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
