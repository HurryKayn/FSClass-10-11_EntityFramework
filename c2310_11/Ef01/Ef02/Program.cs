using Ef02.Model;

namespace Ef02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InserimentoNuoviAlunni();
            //UpdateAlunni();
            StampaAlunni();
            Console.WriteLine("---------");
            DeleteAlunni();
            Console.WriteLine("Record eliminato");
            Console.WriteLine("---------");
            StampaAlunni();
            Console.WriteLine("Applicazione terminata");
        }

        private static void DeleteAlunni()
        {
            AlunnoBusinessLayer abl = new AlunnoBusinessLayer();
            abl.DeleteById(3);
        }

        private static void StampaAlunni()
        {
            AlunnoBusinessLayer abl = new AlunnoBusinessLayer();
            var elenco=abl.GetAll();
            foreach (var item in elenco) 
            { 
                Console.WriteLine(item.AlunnoId+" "+ item.NomeCompleto+" EMail:"+item.Email);
            }
        }

        private static void UpdateAlunni()
        {
            AlunnoBusinessLayer abl = new AlunnoBusinessLayer();

            Alunno alunno=abl.GetById(2);
            alunno.Email = alunno.Nome.Trim() + alunno.Cognome.Trim() + "@tin.it";
            abl.Update(alunno);
        }

        private static void InserimentoNuoviAlunni()
        {
            {
                AlunnoBusinessLayer abl=new AlunnoBusinessLayer();
                Alunno alunno = new Alunno()
                {
                    Nome = "Carla",
                    Cognome = "Giacobbe"
                };
                abl.AddNew(alunno);
                //..
                alunno = new Alunno()
                {
                    Nome = "Anna Maria",
                    Cognome = "Russo"
                };
                abl.AddNew(alunno);

                //..
                alunno = new Alunno()
                {
                    Nome = "Giancarlo",
                    Cognome = "Russo"
                };
                abl.AddNew(alunno);
                //..
                alunno = new Alunno()
                {
                    Nome = "Andrea Celeste",
                    Cognome = "Rulfi"
                };
                abl.AddNew(alunno);

            }

        }
    }
}