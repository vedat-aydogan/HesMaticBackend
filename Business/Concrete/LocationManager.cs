using Business.Abstract;
using Core.Aspects.Autofac.Caching;
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
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        [CacheRemoveAspect("ILocationService.Get")]
        public IResult Add(Location location)
        {
            _locationDal.Add(location);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Location>> GetAll()
        {
            var result = _locationDal.GetAll();
            return new SuccessDataResult<List<Location>>(result);
        }

        [CacheAspect]
        public IDataResult<Location> GetById(int id)
        {
            var result = _locationDal.Get(l => l.Id == id);
            return new SuccessDataResult<Location>(result);
        }

        [CacheAspect]
        public IDataResult<Location> GetByUserId(int userId)
        {
            var result = _locationDal.Get(l => l.UserId == userId);
            return new SuccessDataResult<Location>(result);
        }
    }
}
