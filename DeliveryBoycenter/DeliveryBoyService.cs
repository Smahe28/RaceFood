using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryBoyInterface;
using AllDeliveryBoys;
namespace DeliveryBoycenter
{
    public class DeliveryBoyService
    {
        public static WantoDeliveryBoy DeliveryBoyLogin()
        {
            return new DeliveryBoy();
        }
        public static WantoDeliveryBoy DeliverFoodDetails()
        {
            return new DeliveryBoy();
        }
        public static WantoDeliveryBoy OrderNotification()
        {
            return new DeliveryBoy();
        }
        public static WantoDeliveryBoy DeliBoyOrder()
        {
            return new DeliveryBoy();
        }
        public static WantoDeliveryBoy FinishOrder()
        {
            return new DeliveryBoy();
        }
    }
}
