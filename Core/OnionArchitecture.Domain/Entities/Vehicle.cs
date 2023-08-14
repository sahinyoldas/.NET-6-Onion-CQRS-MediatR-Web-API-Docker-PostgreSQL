using OnionArchitecture.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
