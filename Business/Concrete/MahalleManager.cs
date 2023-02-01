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
    public class MahalleManager : IMahalleService
    {
        IMahalleDal _mahalleDal;

        public MahalleManager(IMahalleDal mahalleDal)
        {
            _mahalleDal = mahalleDal;
        }

        public List<Mahalle> GetList()
        {
            return _mahalleDal.GetListAll();
        }
    }
}
