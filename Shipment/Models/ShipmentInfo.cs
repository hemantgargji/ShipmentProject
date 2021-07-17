using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Shipment.Models
{
    public partial class ShipmentInfo
    {
        public int ShipmentId { get; set; }
        public string SenderName { get; set; }
        public string Description { get; set; }
        public string RecipientAddress { get; set; }
        public bool? Expedited { get; set; }
        public string ShipmentType { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DtCreated { get; set; }
        public DateTime? DtUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
