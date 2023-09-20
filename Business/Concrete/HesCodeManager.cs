using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HesCodeManager : IHesCodeService
    {
        IHesCodeDal _hesCodeDal;

        public HesCodeManager(IHesCodeDal hesCodeDal)
        {
            _hesCodeDal = hesCodeDal;
        }

        public IResult Add(HesCode hesCode)
        {
            _hesCodeDal.Add(hesCode);
            return new SuccessResult(Messages.HesCodeAdded);
        }

        public IResult Delete(HesCode hesCode)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<HesCode>> GetAll()
        {
            var result = _hesCodeDal.GetAll();
            return new SuccessDataResult<List<HesCode>>(result);
        }

        public IDataResult<HesCode> GetById(int hesCodeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<HesCode>> GetByUserId(int userId)
        {
            var result = _hesCodeDal.GetAll(hc => hc.UserId == userId);
            return new SuccessDataResult<List<HesCode>>(result);
        }

        public IDataResult<List<HesCode>> GetHesCodesOfTodayByUserId(int userId)
        {
            DateTime date = DateTime.Today;

            var result = _hesCodeDal.GetAll(hc => hc.UserId == userId && hc.RecordDate.Date == date);
            return new SuccessDataResult<List<HesCode>>(result);
        }

        public IDataResult<List<HesCode>> GetHesCodesByDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            var result = startDate == endDate ? _hesCodeDal.GetAll(hc => hc.UserId == userId && hc.RecordDate.Date == startDate)
                                              : _hesCodeDal.GetAll(hc => hc.UserId == userId && (hc.RecordDate.Date >= startDate && hc.RecordDate.Date <= endDate));

            return new SuccessDataResult<List<HesCode>>(result);
        }

        public IResult Update(HesCode hesCode)
        {
            throw new NotImplementedException();
        }
    }
}
