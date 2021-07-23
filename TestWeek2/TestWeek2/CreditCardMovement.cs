using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public enum Tipo
    {
        AMEX,
        VISA,
        MASTERCARD,
        OTHER
    }
    public class CreditCardMovement : Movimento
    {
        public Tipo Tipo { get; set; }
        public string NumeroCarta { get; set; }

        public CreditCardMovement(double importo, Tipo tipo, string numeroCarta) : base(importo)
        {
            Tipo = tipo;
            NumeroCarta = numeroCarta;

        }

        public override string ToString()
        {
            return base.ToString() + $", Tipo : {Tipo}, " +
                                    $" Numero Carta: {NumeroCarta}";
        }
    }
}
