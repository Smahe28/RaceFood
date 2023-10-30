using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admininterfacing
{
    public class AdminModel
    {
        private int userCount;
        private int restuarantCount;
        private int completeOrdersCount;
        private int pendingOrdersCount;
        private int cancelOrdersCount;
        private int deliboyCount;
        private int resturantRequestCount;
       
        public int Usercount
        {
            get { return userCount; }
            set { userCount = value; }
        }
        public int RestuarantCount
        {
            get { return restuarantCount; }
            set { restuarantCount = value; }
        }
        public int CompleteOrdersCount
        {
            get { return completeOrdersCount; }
            set { completeOrdersCount = value; }
        }
        public int PendingOrdersCount
        {
            get { return pendingOrdersCount; }
            set { pendingOrdersCount = value; }
        }
        public int CancelOrdersConut
        {
            get { return cancelOrdersCount; }
            set { cancelOrdersCount = value; }
        }
        public int DeliBoyCount
        {
            get { return deliboyCount; }
            set { deliboyCount = value; }
        }
        public int ResRequestCount
        {
            get { return resturantRequestCount; }
            set { resturantRequestCount = value; }
        }



    }
}
