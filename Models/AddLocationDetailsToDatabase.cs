using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapsApplication.Models
{
    public class AddLocationDetailsToDatabase
    {
        public virtual int id { get; set; }
        public virtual string Name { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
    }
}
