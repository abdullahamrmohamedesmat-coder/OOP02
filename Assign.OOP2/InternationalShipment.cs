using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign.OOP2
{
    public class InternationalShipment:Shipment
    {
        private string destinationCountry;
        private decimal customsFee;
        public InternationalShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress Destination,string DestinationCountry,decimal CustomsFee):base(TrackingCode, Description, Weight, DeliveryFee, Destination)
        {
            destinationCountry = DestinationCountry;
            customsFee = CustomsFee;
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { 
                    
                  destinationCountry=value;
                } 
            }
        }
        public decimal CustomsFee
        {
            get { return customsFee; }

            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }
        public decimal Estimated
        {
            get
            {
                return DeliveryFee + (Weight * 5m) + CustomsFee;
            }
        }
    }
}
