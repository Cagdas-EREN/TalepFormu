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
    public class CaddeManager : ICaddeService
    {
        ICaddeDal _caddeDal;

        public CaddeManager(ICaddeDal caddeDal)
        {
            _caddeDal = caddeDal;
        }

        public List<Cadde> GetList()
        {
            return _caddeDal.GetListAll();
        }
    }
}
