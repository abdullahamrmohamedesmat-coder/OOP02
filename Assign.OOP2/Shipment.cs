using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign.OOP2
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress destination { get; set; }

        public Shipment(string TrackingCode) {
            this.trackingCode = "TKD-787";
           trackingCode = TrackingCode;
            this.description = "Un Known";
            this.Weight = 1;
            this.DeliveryFee = 50;
            this.destination = default;

        }
        public Shipment(string TrackingCode,string Description,decimal Weight,decimal DeliveryFee,DeliveryAddress Destination) {
            trackingCode = TrackingCode;
            description= Description;
            weight = Weight;
            deliveryFee= DeliveryFee;
            destination = Destination;
        }
        public string TrackingCode
        {
            get => trackingCode;
            private set
            {
                if (!string.IsNullOrEmpty(trackingCode))
                {
                    trackingCode=value;
                }
            }
        }
        public string Description
        {

            get => description;

            set
            {
                if (string.IsNullOrEmpty(description))
                {
                    description = value;
                }
            }
        }
        public decimal Weight
        {
            get => weight;
            set
            {
                if (value > 0)
                {
                    weight = value;
                }

            }
        }
        public decimal DeliveryFee
        {
            get => deliveryFee;

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }
        public decimal EstimatedCost
        {
            get { 
             
             return DeliveryFee+((decimal)weight*5m);
            }
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
            
        }
        public void Print()
        {
            Console.WriteLine(TrackingCode);
            Console.WriteLine(Description);
            Console.WriteLine(Weight);
            Console.WriteLine(DeliveryFee);
            Console.WriteLine(destination.GetAddress());
            Console.WriteLine(EstimatedCost);
            
        }

    }
}
