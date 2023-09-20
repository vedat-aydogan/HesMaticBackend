using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHesCodeService
    {
        IResult Add(HesCode hesCode);
        IResult Update(HesCode hesCode);
        IResult Delete(HesCode hesCode);
        IDataResult<List<HesCode>> GetAll();
        IDataResult<HesCode> GetById(int hesCodeId);
        IDataResult<List<HesCode>> GetByUserId(int userId);
        IDataResult<List<HesCode>> GetHesCodesOfTodayByUserId(int userId);
        IDataResult<List<HesCode>> GetHesCodesByDateRange(int userId, DateTime startDate, DateTime endDate);
    }
}
