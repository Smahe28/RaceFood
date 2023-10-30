using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchFoodInterFace;
using OrderInterface;
using DeliverOrder;
using DeliveryBoyInterface;
namespace UserInterfacing
{
    public interface WantToUser
    {
        void AddUser(UserModel UserData);
        UserModel Login(UserModel UserData);
        List<SearchFoodModel> CartDetails(int UserID);
        List<SearchFoodModel> FoodSearch(string FoodName);
        SearchFoodModel OrderFood(int FoodID);
        void AddCarts(SearchFoodModel CartData);
        bool Removecart(int ID);
        void DelivaryDetails(DelivaryModel OrderData);
        bool FinishCart(int UserID);
        List<DelivaryModel> YourOrdersDetails(int UserID);
        List<YourOrdersModel> YourPendingOrder(int OrderID);
        List<YourOrdersModel> CanceledOrder(int CancelID);
  
        void OrderConfirm(SearchFoodModel UserData);
        bool CancelOrder( int OrderID);
       
    }
}
