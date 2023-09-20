﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IResult Add(Location location);
        IDataResult<List<Location>> GetAll();
        IDataResult<Location> GetById(int id);
        IDataResult<Location> GetByUserId(int userId);
    }
}
