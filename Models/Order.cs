using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace LogiTrack.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public required string CustomerName { get; set; }
        public DateTime DatePlaced { get; set; }

        // Opcional: persistencia entre sesiones
        public string? SessionToken { get; set; }

        public List<InventoryItem> Items { get; set; } = new();

        public void AddItem(InventoryItem item) => Items.Add(item);

        public void RemoveItem(int itemId)
        {
            var item = Items.FirstOrDefault(i => i.ItemId == itemId);
            if (item != null) Items.Remove(item);
        }

        public string GetOrderSummary()
            => $"Order #{OrderId} for {CustomerName} | Items: {Items.Count} | Placed: {DatePlaced.ToShortDateString()}";
    }
}
