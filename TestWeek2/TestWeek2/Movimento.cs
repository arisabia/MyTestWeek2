using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public abstract class Movimento
    {
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        public Movimento(double importo)
        {
            Importo = importo;
            DataMovimento = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Importo: {Importo} \n Data Movimento: {DataMovimento}";
        }
    }
}
