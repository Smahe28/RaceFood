using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchFoodInterFace;
namespace FoodInterFacing
{
   public interface WantToFood
    {
        void AddFood(FoodModel FoodData);
        List<FoodModel> GetFood(int RestID);
        bool DeleteFood(int ID);
        FoodModel FoodEdit(int ID);
        FoodModel UpdateFood(FoodModel FoodDt);
     
       

    }
}
