using System.Transactions;

namespace Assign.OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1st answer
            //a) What is the difference between a class and a struct?
            //      class    |    struct
            //type: Referance|    Value
            //default const: has if no |  always has default
            //constructors   |            constructors
            //             |

            #endregion
            #region Question 1 b
            //2st answer
            //b) Why are classes more suitable than structs for large applications?
            //because class store data in heap not stack,class support oop paradigms :inheritance and polymorphism

            #endregion

            #region Question 3
            //3st answwr
            //            a) Which class is the parent class?
            //shipment is parent clss 
            //b) Which class is the child class?
            //Expressshipment is child

            //c) What members are inherited by ExpressShipment?
            //property : public strin TrackingCodde{get;set;}

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //inheritance make reusability,easier maintanance,reducing errors
            #endregion

            #region Parctical 
            
            //practical Answer
            DeliveryCenter center = new DeliveryCenter("Cairo");

            for (int i = 1; i <= 3; i++) {
                Console.WriteLine("enter TrackingCode");
                string Tcode=Console.ReadLine();

                Console.WriteLine("Enter Description");
                string desc = Console.ReadLine();

                Console.WriteLine("Enter Weight");
                decimal.TryParse(Console.ReadLine(), out decimal we);

                Console.WriteLine("Enter DeliveryFee");
                decimal.TryParse(Console.ReadLine(), out decimal dFee);

                Console.WriteLine("Enter Destination");
                string city=Console.ReadLine();

                Console.WriteLine("Enter strert");
                string street=Console.ReadLine();

                Console.WriteLine("Enter BuildingNumber");
                int.TryParse(Console.ReadLine(), out int buildN);

               DeliveryAddress address=new DeliveryAddress(city,street,buildN);
                Shipment shipment = new Shipment(Tcode,desc,we,dFee,address);
                center.AddShipmnent(shipment);
            }
            Shipment x= center["TKF-680"];
            if (x!=null)
            {
                       Console.WriteLine("shipment found");
            }
            else
            {
                Console.WriteLine("shipment not found");
            }

            Shipment z = center[6];
            if (z != null)
            {
                Console.WriteLine("shipment found");
            }
            else {
                Console.WriteLine("shipment not found");
            }

           if (center.RemoveShipment("TKF-680"))
           {
                Console.WriteLine("shipment removed");
           }
            else
            {
                Console.WriteLine("shipment not removed");
            }

            for (int i = 1; i <= 3; i++) { 
               Shipment s= center[i];
                if (s != null)
                {
                    s.Print();
                }
               
            }
            
          
            #endregion
        }
    }
}
