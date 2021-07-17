using System;
using System.Collections.Generic;
using Shipment.Models;
namespace Shipment.ShipmentServices
{
   public interface IShipmentService
    {
        int AddShipment(ShipmentInfo shipmentInfo);

        List<ShipmentInfo> GetShipment();
        Boolean DeleteShipment(int Id);

    }
}
