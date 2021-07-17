using Shipment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shipment.ShipmentServices
{
    public class ShipmentService : IShipmentService
    {
        private readonly ShipmentContext _shipmentDbContext;
        public ShipmentService(ShipmentContext shipmentDbContext)
        {
            _shipmentDbContext = shipmentDbContext;
        }
     
        public int AddShipment(ShipmentInfo shipmentInfo)
        {

            _shipmentDbContext.ShipmentInfo.Add(shipmentInfo);
            return _shipmentDbContext.SaveChanges();          
        }

        public Boolean DeleteShipment(int Id)
        {
            var shipmentInfo = _shipmentDbContext.ShipmentInfo.FirstOrDefault(x => x.ShipmentId == Id);
            if (shipmentInfo != null)
            {
                shipmentInfo.IsDeleted = true;
                _shipmentDbContext.Update(shipmentInfo);
                _shipmentDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    

        public  List<ShipmentInfo> GetShipment()
        {
            return  _shipmentDbContext.ShipmentInfo.Where(x=>x.IsDeleted==false).ToList();
           
        }
    }
}

