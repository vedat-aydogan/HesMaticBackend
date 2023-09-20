using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HesCode : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Code { get; set; }
        public string HealthStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime RecordDate { get; set; }

        public HesCode()
        {
            RecordDate = DateTime.Now;
        }
    }
}
