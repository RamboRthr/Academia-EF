using DojoAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Repository
{
    public class ModaliadeRepository
    {
        public int Save(Modalidade modalidade)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                {
                    db.Set<Modalidade>().Attach(modalidade);
                }
                if (db.Modalidades.Any(m => m.Nome == modalidade.Nome))
                {
                    db.Entry(modalidade).State = EntityState.Modified;
                }
                else
                {
                    db.Entry(modalidade).State = EntityState.Added;
                }

                return db.SaveChanges();
            }
        }

        public int Delete(Modalidade modalidade)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                {
                    db.Set<Modalidade>().Attach(modalidade);
                }
                db.Entry(modalidade).State = EntityState.Deleted;

                return db.SaveChanges();
            }
        }
                
    }
}
