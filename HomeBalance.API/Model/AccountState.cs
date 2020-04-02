using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBalance.API.Model
{
    public class AccountState
    {
        public DateTime Fecha { get; set; }
        public double Balance { get; set; }
        public int Id { get; set; }
    }
}
