using Ef02.DataDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef02.Model
{
    internal class AlunnoBusinessLayer
    {
        /// <summary>
        /// esegue inserimento dati
        /// return false se errore e quindi inserimento non eseguito
        /// </summary>
        /// <param name="alunno"></param>
        /// <returns></returns>
        public bool AddNew(Alunno alunno)
        {
            using (var ctx  = new DataDbContext())
            {
                try
                {
                    ctx.Add(alunno);
                    // equivalente  ctx.Alunni.Add(alunno);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    string s = e.Message;
                    Console.WriteLine(s);
                    
                    throw; // se non eseguo throw;  return false
                }

            }
            return true;
        }

        internal bool DeleteById(int id)
        {
            try
            {
                var alunno = GetById(id);
                using (var ctx = new DataDbContext())
                {
                    if (alunno != null)
                    {
                        ctx.Remove(alunno);
                        ctx.SaveChanges();  
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception e)
            {
                string s = e.Message;
                Console.WriteLine(s);

                throw; // se non eseguo throw;  return false
            }
        }

        /// <summary>
        /// RITORNA elenco alunni
        /// </summary>
        internal List<Alunno> GetAll()
        {
            using (var ctx = new DataDbContext())
            {
                return ctx.Alunni.ToList();
            }
        }

        /// <summary>
        /// Esegue lettura record per PK
        /// return null se record non trovato
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal Alunno GetById(int id)
        {
            using (var ctx = new DataDbContext())
            {
                try
                {
                    return ctx.Alunni.Find(id);
                }
                catch (Exception e)
                {
                    string s = e.Message;
                    Console.WriteLine(s);

                    throw; // se non eseguo throw;  return false
                }
            }
            return null;
        }

        internal void Update(Alunno alunno)
        {
            using(var ctx = new DataDbContext())
            {
                try
                {
                    ctx.Alunni.Update(alunno);
                    // ctx.Update(alunno); in alternativa
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    string s = e.Message;
                    Console.WriteLine(s);

                    throw; // se non eseguo throw;  return false
                }
            }
        }
    }
}
