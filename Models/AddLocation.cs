﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHibernate;
namespace MapsApplication.Models
{
    public class AddLocation
    {
        public virtual string Name { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
    }
}
