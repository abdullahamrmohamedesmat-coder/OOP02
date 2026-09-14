using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign.OOP2
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress Destination) :base(TrackingCode, Description, Weight, DeliveryFee, Destination)
        {
            
        }
    }
}
