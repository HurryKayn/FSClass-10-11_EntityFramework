using Ef01.DbData;
using Ef01.Model;

namespace Ef01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //InserimentoNuovoCliente();
                //UpdateCliente(2);
                stampaClienti();
            }

            Console.WriteLine("Termina Applicazione");
        }

        private static void stampaClienti()
        {
            var bl = new ClienteBusinessLayer();
            var elenco = bl.GetAll();
            foreach (var item in elenco) 
            { 
                Console.WriteLine(item.Nome+" ," + item.Cognome);
            }
        }

        /// <summary>
        /// Aggiornamento record tabella clienti
        /// Verrà aggiornato il record in base alla key primaria 
        /// passata come parametro
        /// </summary>
        /// <param name="id"></param>
        private static bool UpdateCliente(int id)
        {
            //-- 1°step: ricercare il record sulla tabella
            var bl = new ClienteBusinessLayer();
            var cliente = bl.GetById(id);
            //-- 2°step verifica che il record sia stato trovato
            if (cliente == null) { return false; }
            //-- 3°step se record trovato modifico i dati
            cliente.Nome = "Anna";
            //-- 4°step aggiorno il record sul database
            bl.Update(cliente);
            return true;
        }

        /// <summary>
        /// metodo inserimento cliente
        /// </summary>
        private static void InserimentoNuovoCliente()
        {
            Cliente cli = new Cliente();
            cli.Nome = "Laura";
            cli.Cognome = "Colombo";
            cli.Indirizzo = "Via Roma";
            cli.Cap = "20100";
            cli.Localita = "MIlano";
            cli.Prov = "MI";
            cli.CodiceFiscale = "abcd56";
            cli.PartitaIva = "1234567";
            new ClienteBusinessLayer().AddNew(cli);
        }
    }
}