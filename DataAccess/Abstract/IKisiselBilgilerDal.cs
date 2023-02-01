using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IKisiselBilgilerDal : IGenericDal<KisiselBilgiler>
    {
        //List<KisiselBilgiler> GetWithIl();
    }
}
