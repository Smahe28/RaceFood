using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantInterFacing
{
    public interface WantToRestuarant
    {
        bool DeleteRestuarant(int ID);
        List<RestuarantModel> RegisterRestuarant();
      
        List<RestuarantModel> RestuarantDetails();
        void Register(RestuarantModel RestuarantData);
        RestuarantModel Login(RestuarantModel RestuarantData);
        RestuarantModel GetRestuarantName(int RestID);
        //RestuarantModel GetFood(int RestID);

    }
}
