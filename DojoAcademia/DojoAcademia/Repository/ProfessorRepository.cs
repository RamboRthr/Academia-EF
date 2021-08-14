using DojoAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Repository
{
    public class ProfessorRepository
    {
        public int Save(Professor professor)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                {
                    db.Set<Professor>().Attach(professor);
                }
                if (db.Professores.Any(p => p.CPF == professor.CPF))
                {
                    db.Entry(professor).State = EntityState.Modified;
                }
                else
                {
                    db.Entry(professor).State = EntityState.Added;
                }

                return db.SaveChanges();
            }
        }

        public int Delete(Professor professor)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                    db.Set<Professor>().Attach(professor);
                db.Entry(professor).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
