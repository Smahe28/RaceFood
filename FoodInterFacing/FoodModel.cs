using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInterFacing
{
    public class FoodModel
    {
        private int foodid;
        private int restuarantID;
        private string foodName;
        private string foodPrice;
        private string restuarantname;
        private string address;
        private int commision;
     


      

        public int FoodID
        {
            get { return foodid; }
            set { foodid = value; }

        }
        public int RestuarantID
        {
            get { return restuarantID; }
            set { restuarantID = value; }
        }
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
        public string FoodPrice
        {
            get { return foodPrice; }
            set { foodPrice = value; }
        }
        public string RestuarantName
        {
            get { return restuarantname; }
            set { restuarantname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Commision
        {
            get { return commision; }
            set { commision = value; }
        }
    }
}
