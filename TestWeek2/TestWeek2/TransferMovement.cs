using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public class TransferMovement : Movimento
    {
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }

        public TransferMovement(double importo, string bancaOrigine, string bancaDestinazione) : base(importo)
        {
            BancaOrigine = bancaOrigine;
            BancaDestinazione = bancaDestinazione;
        }

        public override string ToString()
        {
            return base.ToString() + $", Banca d'Origine: {BancaOrigine}," +
                                     $" Banca Destinazione: {BancaDestinazione}";
        }
    }
}
