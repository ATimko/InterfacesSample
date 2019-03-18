using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSample
{
    class MobilePhone : IDisplayable
    {
        ///<summ> 
        ///Operating System of the phone
        ///</summ>
        public string OS { get; set; }

        public double ScreenSize { get; set; }

        public double BatteryLifeHours { get; set; }

        public string GetDisplayText()
        {
            return $"The phone is {OS} with a screen" +
                    $"size of {ScreenSize}";
        }
    }

}
