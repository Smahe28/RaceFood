using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodInterFacing;
using UserInterfacing;
using OrderInterface;
using DeliverOrder;
using DeliveryBoyInterface;
namespace Admininterfacing
{
    public interface WantToAdmin
    {
        bool DeleteRestuarant(int RestuarantID);
        List<FoodModel> FoodList(int RestuarantID);
        List<UserModel> UserList();
        bool DeleteUser(int UserID);
        List<YourOrdersModel> YourOrder();
        List<DelivaryModel> OrdersList();
        List<DelivaryModel> CompleteOrders();
        List<DelivaryModel> CancelOrders();
        void RegisterDeliveryBoy(DelivaryBoyModel DeboyData);
        List<DelivaryBoyModel> DeliBoyList();
        bool DeleteDeliBoy(int DeliBoyID);
        List<DelivaryModel> CompleteOrdersForDeliBoy( int DeliBoyID);
        AdminModel Counts();
        List<DelivaryModel> Filltercomplete(string OrderDate);
      
        List<DelivaryModel> FillterCancel(string OrderDate);
    }
}
