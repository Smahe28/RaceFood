using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestuarantInterFacing;
using Restuarant;
namespace RestuarantCenter
{
    public class RestuarantService
    {
        public static WantToRestuarant RestuarantObject()
        {
            return  new HoleRestuarant();
        }
        public static WantToRestuarant GetRestuarant()
        {
            return new HoleRestuarant();
        }

        public static WantToRestuarant RestuarantRegister()
        {
            return new HoleRestuarant();
        }
        public static WantToRestuarant Login()
        {
            return new HoleRestuarant();
        }
        public static WantToRestuarant GetRestuarantName()
        {
            return new HoleRestuarant();
        }
    }
    
}
