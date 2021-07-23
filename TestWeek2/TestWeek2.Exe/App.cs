using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2.Exe
{
    public class App
    {
        //test
        public static Account CreaAccount()
        {
            string nomeAccount = "";
            Console.WriteLine("Inserisci il nome della banca:");
            nomeAccount = Console.ReadLine();
            return new Account(nomeAccount);

        }

        public static bool Menu()
        {
            Console.WriteLine("Scegli l'operazione desiderata: ");
            Console.WriteLine("1. Crea nuovo Account");
            Console.WriteLine("Prelievo :");
            Console.WriteLine("2. Prelievo Cash");
            Console.WriteLine("3. Prelievo Transfer");
            Console.WriteLine("4. Prelievo CrediCard");
            Console.WriteLine("Versamento: ");
            Console.WriteLine("5. Versamento Cash");
            Console.WriteLine("6. Versamento Transfer");
            Console.WriteLine("7. Versamento CreditCard");
            Console.WriteLine("8. Stampa i dati del conto e i movimenti ");
            Console.WriteLine("0. Exit");
            int scelta = App.VerificaImput(8);
            var esito = App.AnalizzaScelta(scelta);
            return esito;
        }


        internal static bool AnalizzaScelta(int scelta)
        {
            Account a = new Account()
            {
                NumeroConto = "2993888",
                NomeBanca = "AMEX",
                Saldo = 200

            };
            bool go = true;

            switch (scelta)
            {
                case 1:
                    CreaAccount();
                    break;
                case 2:
                    Console.WriteLine("Inserisci nome utente: ");
                    string utente = Console.ReadLine();
                    a -= new CashMovement(InserimentoImporto(), utente);
                    break;
                case 3:
                    Console.WriteLine("Inserisci banca destinazione: ");
                    string dest = Console.ReadLine();
                    a -= new TransferMovement(InserimentoImporto(), a.NomeBanca, dest);
                    break;
                case 4:
                    a -= new CreditCardMovement(InserimentoImporto(), InserisciTipo(), InserisciNrCarta());
                    break;
                case 5:
                    Console.WriteLine("Inserisci nome utente: ");
                    string utente2 = Console.ReadLine();
                    a += new CashMovement(InserimentoImporto(), utente2);
                    break;
                case 6:
                    Console.WriteLine("Inserisci banca: ");
                    string banca = Console.ReadLine();
                    a += new TransferMovement(InserimentoImporto(), banca, a.NomeBanca);
                    break;
                case 7:
                    a += new CreditCardMovement(InserimentoImporto(), InserisciTipo(), InserisciNrCarta());
                    break;
                case 8:
                    a.Statement();
                    break;
                case 0:
                    Console.WriteLine("Ciao");
                    break;
                default:

                    go = false;
                    break;
            }

            return go;
        }



        internal static int VerificaImput(int max)
        {
            var conversione = Int32.TryParse(Console.ReadLine(), out int result);
            while (conversione == false || result < 0 || result > max)
            {
                Console.WriteLine("Choose one of the options available");
                conversione = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

        public static string InserisciNrCarta()
        {
            string num;

            Console.WriteLine("Inserisci numero di carta: ");
            num = Console.ReadLine();
            return num;

        }

        public static double InserimentoImporto()
        {
            double importo;
            do
            {
                Console.WriteLine("Inserisci importo: ");
            }
            while (!double.TryParse(Console.ReadLine(), out importo));
            return importo;
        }

        public static Tipo InserisciTipo()
        {
            Tipo tipo;
            Console.WriteLine("Inserisci tipo carta dalla seguente lista: " +
                "AMEX, VISA, MASTERCARD, OTHER");
            if (Console.ReadLine() == "AMEX")
            {
                tipo = Tipo.AMEX;
            }
            else if (Console.ReadLine() == "VISA")
            {
                tipo = Tipo.VISA;
            }
            else if (Console.ReadLine() == "MASTERCARD")
            {
                tipo = Tipo.MASTERCARD;
            }
            else
            {
                tipo = Tipo.OTHER;
            }
            return tipo;
        }
    }
}

