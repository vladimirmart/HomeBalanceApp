using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBalance.API.Model
{
    public class Cuenta
    {
        public int Id { get; set; }
        public int RoutingNumber { get; set; }
        public String BankName { get; set; }
        public String AccountType { get; set; }
        public int Balance { get; set; }
        public List<AccountState> Historicos { get; set; }

    }
}
