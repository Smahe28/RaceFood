using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFoodInterFace
{
  public  class SearchFoodModel
    {
        private int id;
        private int restuarantID;
        private string restuarantname;
        private string address;
        private string foodname;
        private string foodprice;
        private int userid;
        private int quantity;
        private int amount;
        private int foodid;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int RestuarantID
        {
            get { return restuarantID; }
            set { restuarantID = value; }
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
        public string FoodName
        {
            get { return foodname; }
            set { foodname = value; }
        }
        public string FoodPrice
        {
            get { return foodprice; }
            set { foodprice = value; }
        }
        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int FoodID
        {
            get { return foodid; }
            set { foodid = value; }
        }
    }
}
