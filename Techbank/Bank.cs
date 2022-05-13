using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBank.Models
{
    public class Bank
    {

        public string id { get; set; }
        public string name { get; set; }
        public List<Account> accounts { get; set; }
        public List<Currency> currencies { get; set; }
       
        public IMPS imps { get; set; }

        public RTGS rtgs { get; set; }
        public List<BankStaff> staff { get; set; }
    }
}
