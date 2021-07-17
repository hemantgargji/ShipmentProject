using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shipment.ShipmentServices;
using Shipment.Models;
using Microsoft.Extensions.Logging;

namespace Shipment.Controllers
{
    public class ShipmentController : Controller
    {
        private readonly IShipmentService _shipmentService;
        private readonly ILogger _logger;
        public ShipmentController(IShipmentService shipmentService, ILoggerFactory logFactory)
        {
            _shipmentService = shipmentService;
            _logger = logFactory.CreateLogger<ShipmentController>();
        }

        public IActionResult Index()
        {
          
            return View();
        }
        [HttpGet]      
        public async Task<List<ShipmentInfo>> GetShipment()
        {
            try
            {             
                var myTask = Task.Run(() => _shipmentService.GetShipment());
                List<ShipmentInfo> lstShipment = await myTask;
                return lstShipment;
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message+" "+ ex.StackTrace);
                throw ex;
            }
            

        }

        // POST: ShipmentController/Create
        [HttpPost]
        public async Task<int> Create(ShipmentInfo shipmentInfo)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    var myTask = Task.Run(() => _shipmentService.AddShipment(shipmentInfo));
                    return await myTask;
                   
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                //Log the exception here
                _logger.LogInformation(ex.Message + " " + ex.StackTrace);
                throw ex;

            }


        }
        
        // POST: ShipmentController/Delete
        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                var myTask = Task.Run(() => _shipmentService.DeleteShipment(id));
                return await myTask;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message + " " + ex.StackTrace);
                throw ex;
            }

        }

        public IActionResult Error()
        {
            return View();
        }


    }
}
