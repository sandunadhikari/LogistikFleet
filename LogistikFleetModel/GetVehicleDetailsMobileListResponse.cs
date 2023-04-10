using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogistikFleetModel
{
    [Serializable]
    public class GetVehicleDetailsMobileListResponse
    {
        public List<VehicleTypeMobileResult> listVehicle { get; set; }

        public ApiMessage message { get; set; }
    }
}
