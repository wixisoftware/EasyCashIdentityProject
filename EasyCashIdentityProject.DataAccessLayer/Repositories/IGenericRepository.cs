using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Repositories
{
    public class IGenericRepository<T> : IGenericDAL<T> where T : class
    {

       
        public void Delete(T t)
        {

            // Dispose Method ile çalışmak RAM açısından performansı etkiler Scope arasında açılır ve yok edilir RAMde açılan alan
            using (Context  c = new Context())
            {
                c.Set<T>().Remove(t);
                c.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
           using var context = new Context();
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
            // Find primary key olan alan ile arama yapar
        }

        public void Insert(T t)
        {
            using var context = new Context();
             context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new Context();
             context.Set<T>().Update(t);
            // Asp.Net MVC de update bulunmamakta Core ile gelen bir metot

            context.SaveChanges() ;
        }
    }
}
