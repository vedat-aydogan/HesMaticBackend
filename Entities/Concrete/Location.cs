using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Country { get; set; } = "Türkiye";
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal longitude { get; set; }
    }
}
