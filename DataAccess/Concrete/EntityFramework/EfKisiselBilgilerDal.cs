using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Concrete.EntityFramework.Repositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKisiselBilgilerDal : GenericRepository<KisiselBilgiler>, IKisiselBilgilerDal
    {
        //public List<KisiselBilgiler> GetWithIl()
        //{
        //    using (var context = new BasvuruContext())
        //    {
        //        //return context.KisiselBilgilers.Include(x =>x.Il).ToList();
        //    }
        //}
    }
}
