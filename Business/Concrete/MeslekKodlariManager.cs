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
    public class MeslekKodlariManager : IMeslekKodlariService
    {
        IMeslekKodlariDal _meslekKodlari;

        public MeslekKodlariManager(IMeslekKodlariDal meslekKodlari)
        {
            _meslekKodlari = meslekKodlari;
        }

        public List<MeslekKodlari> GetList()
        {
            return _meslekKodlari.GetListAll();
        }
    }
}
