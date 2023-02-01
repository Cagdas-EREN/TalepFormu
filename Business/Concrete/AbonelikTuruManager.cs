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
    public class AbonelikTuruManager : IAbonelikTuruService
    {
        IAbonelikTuruDal _abonelikTuruDal;

        public AbonelikTuruManager(IAbonelikTuruDal abonelikTuruDal)
        {
            _abonelikTuruDal = abonelikTuruDal;
        }

        public List<AbonelikTuru> GetList()
        {
            return _abonelikTuruDal.GetListAll();
        }
    }
}
