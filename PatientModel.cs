using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class PatientModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string phone { get; set; }
        public int ID { get; set; }
        public bool gender { get; set; }
        public string address { get; set; }
    }
    public class PatientModelList
    {
        public string searchKey { get; set; }
        public List<PatientModel> resultList { get; set; }
    }
}
