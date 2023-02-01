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
    public class IlceManager : IIlceService
    {
        IIlceDal _IlceDal;

        public IlceManager(IIlceDal ılceDal)
        {
            _IlceDal = ılceDal;
        }

        public List<Ilce> GetList()
        {
            return _IlceDal.GetListAll();
        }
    }
}
