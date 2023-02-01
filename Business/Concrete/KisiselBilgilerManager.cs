using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KisiselBilgilerManager : IKisiselBilgilerService
    {
        IKisiselBilgilerDal _kisiselBilgilerDal;

        public KisiselBilgilerManager(IKisiselBilgilerDal kisiselBilgilerDal)
        {
            _kisiselBilgilerDal = kisiselBilgilerDal;
        }

        //public List<KisiselBilgiler> GetListIl()
        //{
        //    return _kisiselBilgilerDal.GetWithIl();
        //}

        public void KisiselBilgilerAdd(KisiselBilgiler kisiselBilgiler)
        {
            _kisiselBilgilerDal.Insert(kisiselBilgiler);
        }
    }
}
