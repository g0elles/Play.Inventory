using Play.Inventory.Service.Dtos;
using Play.Inventory.Service.Entitites;

namespace Play.Inventory.Service
{
    public static class Extensions
    {
        public static InventoryItemDto AsDto(this InventoryItem item)
        {
            return new InventoryItemDto(item.CatalogItemID, item.Quantity, item.AdquiredDate);
        }
    }
}