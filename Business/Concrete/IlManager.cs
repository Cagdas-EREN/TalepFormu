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
    public class IlManager : IIlServices
    {
        IIlDal _ılDal;

        public IlManager(IIlDal ılDal)
        {
            _ılDal = ılDal;
        }

        public List<Il> GetList()
        {
            return _ılDal.GetListAll();
        }
    }
}
