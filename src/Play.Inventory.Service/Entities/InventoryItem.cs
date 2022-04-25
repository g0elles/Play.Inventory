using System;
using Play.Common;

namespace Play.Inventory.Service.Entitites
{
    public class InventoryItem : IEntity
    {
        public Guid Id {get; set;}
        public Guid UserId {get; set; }
        public Guid CatalogItemID { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset AdquiredDate { get; set; }
    }
}