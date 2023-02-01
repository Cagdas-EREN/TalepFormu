using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T item)
        {
            using(var context = new BasvuruContext())
            {
                context.Remove(item);
                context.SaveChanges();
            }
        }

        public List<T> GetListAll()
        {
            using (var context = new BasvuruContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using (var context = new BasvuruContext())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public T GeyById(int id)
        {
            using var c = new BasvuruContext();
            return c.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            using(var context = new BasvuruContext())
            {
                context.Add(item);
                context.SaveChanges();
            }
        }

        public void Update(T item)
        {
            using (var context = new BasvuruContext())
            {
                context.Update(item);
                context.SaveChanges();
            }
        }
    }
}
