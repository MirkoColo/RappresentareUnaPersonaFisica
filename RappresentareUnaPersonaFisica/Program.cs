using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RappresentareUnaPersonaFisica
{
    class DatiAnagrafici
    {
        protected int _codice;
        protected string _nome;
        protected string _cognome;
        protected bool _registrato;

        public DatiAnagrafici() 
        {
            _codice = 101;
            _nome = "Fabio";
            _cognome = "Rovazzi";
            _registrato = false;
        } 
        public void Registra()
        {
            Console.WriteLine($"Registrazione avvenuta con successo");
            _registrato = true;
        }

        public void Stampa()
        {
            Console.WriteLine($"Nome: {_nome}\nCognome: {_cognome}\nCodice: {_codice}\nRegistrato: {(_registrato ? "Sì" : "No")}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            DatiAnagrafici datiAnagrafici = new DatiAnagrafici();
            datiAnagrafici.Stampa();
            datiAnagrafici.Registra();
            datiAnagrafici.Stampa();
        }
    }
}
