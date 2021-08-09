using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Entities
{
    interface IWheeledVehicle :IVehicle
    {
        public string TransmissionType { get; set; }
    }
}
