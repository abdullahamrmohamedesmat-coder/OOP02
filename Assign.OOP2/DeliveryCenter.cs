using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign.OOP2
{
    public class DeliveryCenter
    {
        public string centreName { get; set; }
        private Shipment[] Shipments;
        private int count;

        public DeliveryCenter(string CentreName)
        {
            CentreName = CentreName;
            Shipments = new Shipment[20];
            count = 0;
        }

        public Shipment this[int indexer]
        {

            get
            {
                if (indexer >= 0 && indexer < count)
                {
                    return Shipments[indexer];
                }
                return null;
            }
            set
            {
                if (indexer >= 0 && indexer < count && value != null)
                {

                    Shipments[indexer] = value;

                }
            }

        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (!string.IsNullOrEmpty(trackingCode))
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (Shipments[i] != null && Shipments[i].TrackingCode == trackingCode)
                        {
                            return Shipments[i];

                        }


                    }


                }
                return null;
            }

        }
        public bool AddShipmnent(Shipment shipment)
        {
            if (shipment != null && count < Shipments.Length)
            {
                Shipments[count] = shipment;
                count++;
                return true;
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            if (string.IsNullOrEmpty(trackingCode) || count == 0)
            {
                return false;

            }
            int indexRemove = -1;
            for (int i = 0; i < count; i++) {
                if (Shipments[i] != null && Shipments[i].TrackingCode== trackingCode)
                {
                    indexRemove = i;
                    break;
                }
            
            }
            if (indexRemove > -1) { 
              return false;
            }
            for (int i = 0; indexRemove < count - 1; i++) {

                Shipments[i] = Shipments[i + 1];
            }
            Shipments[count - 1] = null; 
            count--;
            return true;
        }

    }
}
