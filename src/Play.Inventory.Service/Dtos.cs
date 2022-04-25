using System;
namespace Play.Inventory.Service.Dtos
{
    public record GrantItemsDto(Guid UserId, Guid CatalogItemID, int Quantity);

    public record InventoryItemDto(Guid CatalogItemID, int Quantity, DateTimeOffset AdquireDate);
}