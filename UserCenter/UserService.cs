using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using UserInterfacing;
using SearchFoodInterFace;
using OrderInterface;
namespace UserCenter
{
    public class UserService
    {
        public static WantToUser GetUserObject()
        {
            return new AllUsers();
        }
        public static WantToUser Login()
        {
            return new AllUsers();
        }
        public static WantToUser FoodSearch()
        {
            return new AllUsers();
        }
        public static WantToUser OrderFood()
        {
            return new AllUsers();
        }
        public static WantToUser CartFood()
        {
            return new AllUsers();
        }

        public static WantToUser AddCart()
        {
            return new AllUsers();
        }
        public static WantToUser RemoveCart()
        {
            return new AllUsers();
        }
        public static WantToUser OrderComplete()
        {
            return new AllUsers();
        }
        public static WantToUser FinishCart()
        {
            return new AllUsers();
        }
        public static WantToUser YourOrders()
        {
            return new AllUsers();
        }
        public static WantToUser CancelYourOrder()
        {
            return new AllUsers();
        }
        public static WantToUser StoreCancelOrder()
        {
            return new AllUsers();
        }
     
    }
}
