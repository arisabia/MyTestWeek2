using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
   public class CashMovement : Movimento
    {      
        public string Esecutore { get; set; }

        public CashMovement(double importo, string esecutore) : base(importo)
        {
            Esecutore = esecutore;
        }

        public override string ToString()
        {
            return base.ToString() + $", Esecutore : {Esecutore}";
        }
    }
}
