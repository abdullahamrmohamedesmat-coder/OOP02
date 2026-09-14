using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign.OOP2
{
    public class ExpressShipment:Shipment
    { private decimal extraFee;
        public ExpressShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress Destination,decimal extraFee):base(TrackingCode, Description, Weight, DeliveryFee, Destination)
        {

        }
        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if(value <= 0)
                {
                    extraFee = value;
                } 
            }
        }

        public decimal EstimatedCode
        {
            get
            {
                return DeliveryFee + (Weight * 5m) + ExtraFee;
            }
        }
    }
}
