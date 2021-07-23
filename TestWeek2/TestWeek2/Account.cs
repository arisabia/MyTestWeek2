using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public class Account
    {
        public string NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public double Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public List<Movimento> ListaMovimenti { get; set; } = new List<Movimento>();

        //public Account(string numeroConto, string nomeBaca, double saldo)
        //{
        //    NumeroConto = numeroConto;
        //    NomeBanca = nomeBaca;
        //    Saldo = saldo;

        //}
        public Account(string nomeBanca) { NomeBanca = nomeBanca; }
        public Account() { }

        public static Account operator +(Account account, Movimento movimento)
        {
            account.ListaMovimenti.Add(movimento);
            account.Saldo += movimento.Importo;
            account.DataUltimaOperazione = DateTime.Now;
            return account;
        }
        public static Account operator -(Account account, Movimento movimento)
        {
            account.ListaMovimenti.Add(movimento);
            account.Saldo -= movimento.Importo;
            account.DataUltimaOperazione = DateTime.Now;
            return account;
        }

        public void Versa(Movimento movimento)
        {
            ListaMovimenti.Add(movimento);
            Saldo += movimento.Importo;
            DataUltimaOperazione = DateTime.Now;
        }

        public void Preleva(Movimento movimento)
        {
            ListaMovimenti.Add(movimento);
            Saldo -= movimento.Importo;
            DataUltimaOperazione = DateTime.Now;
        }
        public void Statement()
        {
            string MovimentiString = "";
            foreach (var m in ListaMovimenti)
            {
                MovimentiString += ("\n" + m.ToString());
            }
            Console.WriteLine($"Conto: {NumeroConto}, " +
                             $"Banca: {NomeBanca}, " +
                             $"Saldo: {Saldo}," +
                             $" Data ultima operazione: {DataUltimaOperazione}," +
                             $"Lista movimenti: {MovimentiString}");
        }
        

    }
}
