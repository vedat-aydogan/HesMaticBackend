using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHesCodeDal : EfEntityRepositoryBase<HesCode>, IHesCodeDal
    {
        public EfHesCodeDal(DbContext ctx):base(ctx) { }
    }
}
