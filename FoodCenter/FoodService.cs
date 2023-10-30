using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodInterFacing;
using Food;
using SearchFoods;
namespace FoodCenter
{
    public class FoodService
    {
        public static WantToFood AddFoodObject()
        {
            return new HoleFoods();
        }
        public static WantToFood GetFoodDetails()
        {
            return new HoleFoods();
        }

        public static WantToFood DeleteFood()
        {
            return new HoleFoods();
        }
        public static WantToFood EditFood()
        {
            return new HoleFoods();
        }
        public static WantToFood UpdateFood()
        {
            return new HoleFoods();
        }
        public static WantToFood FoodSearch()
        {
            return new HoleFoods();
        }
        public static WantToFood OrderFood()
        {
            return new HoleFoods();
        }
        public static WantToFood CartFood()
        {
            return new HoleFoods();
        }
       
        public static WantToFood AddCart()
        {
            return new HoleFoods();
        }
    }
}
