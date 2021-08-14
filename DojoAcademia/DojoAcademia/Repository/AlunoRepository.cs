using DojoAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Repository
{
    public class AlunoRepository
    {


        public int Save(Aluno aluno)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(aluno).State == EntityState.Detached)
                {
                    db.Set<Aluno>().Attach(aluno);
                }
                if (db.Alunos.Any(a => a.CPF == aluno.CPF))
                {
                    db.Entry(aluno).State = EntityState.Modified;
                }
                else
                {
                    db.Entry(aluno).State = EntityState.Added;
                }

                return db.SaveChanges();
            }
        }
        public int Delete(Aluno aluno)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(aluno).State == EntityState.Detached)
                    db.Set<Aluno>().Attach(aluno);
                db.Entry(aluno).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
