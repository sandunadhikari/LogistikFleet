using LogistikFleetModel;
using LogistikFleetModel.AccessModels;
using LogistikFleetServices.ApiService;
using System;
using System.Collections.Generic;

namespace LogistikFleetController
{
    public class VehicleController
    {
        VehicleService vehicleService;
        public VehicleController()
        {
            vehicleService = new VehicleService();
        }

        public List<VehicleTypeResult> getVehicleTypes(string token)
        {
            List<VehicleTypeResult> vehicleTypeResults = null;
            try
            {
                vehicleTypeResults = vehicleService.getVehicleTypes(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vehicleTypeResults;
        }

        public GetVehicleDetailsMobileListResponse getVehicleTypesMobile(string token)
        {
            GetVehicleDetailsMobileListResponse vehicleTypeResults = null;
            try
            {
                vehicleTypeResults = vehicleService.getVehicleTypesMobile(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vehicleTypeResults;
        }

        public GetReservationConfigurationResponse getVehicleTypesMobileNew(GetReservationConfigurationMobileRequest vehicleMobileRequest, string token)
        {
            GetReservationConfigurationResponse vehicleTypeResults = null;
            try
            {
                vehicleTypeResults = vehicleService.getVehicleTypesMobileNew(vehicleMobileRequest,token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vehicleTypeResults;
        }

        public GetChecklistMobileResponse getDamageCheckListMobile(GetChecklistMobileRequest checklistMobileRequest, string token)
        {
            GetChecklistMobileResponse response = null;
            try
            {
                response = vehicleService.getDamageCheckListMobile(checklistMobileRequest, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
