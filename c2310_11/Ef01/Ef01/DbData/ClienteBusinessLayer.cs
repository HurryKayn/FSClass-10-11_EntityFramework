using Ef01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.DbData
{
    internal class ClienteBusinessLayer
    {
        public bool AddNew(Cliente cliente)
        {   
            using (var ctx = new DbDataContext() )
            {
                ctx.Add(cliente);
                /*
                 * altro modo per inserire un nuovo record
                 * ctx.Clienti.Add(cliente); 
                 */
                //
                ctx.SaveChanges();// equivale commit
            }
            return true;
        }
        /// <summary>
        /// Ricerca record per key primaria
        /// torna:
        /// False record nonn trovato
        /// True record trovato
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal Cliente GetById(int id)
        {
            
            //-- Eseguo ricerca record per PK
            using (var ctx = new DbDataContext())
            {
                Cliente? cli = ctx.Clienti.Find(id);
                if(cli == null) { return null; }
                return cli;
            }
        }

        internal bool Update(Cliente cliente)
        {
            using (var ctx = new DbDataContext())
            {
                ctx.Update(cliente);
                /* in alternativa
                 * ctx.Clienti.Update(cliente)
                 */
                ctx.SaveChanges();
            }

            return true;
        }
        internal bool DeleteById(int id)
        {
            var cli = GetById(id);
            if (cli != null)
            {
                using (var ctx = new DbDataContext())
                {
                   ctx.Clienti.Remove(cli);
                   ctx.SaveChanges();
                }

            }
            return false;

            //using (var ctx = new DbDataContext())
            //{
            //    if (ctx.Clienti.Find(id) !=null)
            //    {
            //        ctx.Clienti.Remove(GetById(id));
            //        return true;
            //    }
            //}
            //return false;
        }

        internal List<Cliente> GetAll()
        {
            using (var ctx = new DbDataContext())
            {
                var l = ctx.Clienti.ToList();
                return l;
            }

            
        }
    }
}
