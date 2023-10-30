using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderInterface;
using DeliverOrder;
namespace DeliveryBoyInterface
{
    public interface WantoDeliveryBoy
    {

        DelivaryBoyModel Login(DelivaryBoyModel UserData);
        List<DelivaryModel> FoodDetails(int DeliBoyID);
        bool  OrderNotification(int OrderID);
        List<DelivaryModel> OrderDetails( int DeliBoyID);
        bool FinishOrder(int OrderID);
        List<YourOrdersModel> CompleteOrders( int FinishID);
    }
}
