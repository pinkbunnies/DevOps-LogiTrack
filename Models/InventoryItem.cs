using System;
using System.ComponentModel.DataAnnotations;

namespace LogiTrack.Models
{
    public class InventoryItem
    {
        [Key] // ✅ Marca esta propiedad como clave primaria
        public int ItemId { get; set; }

        public required string Name { get; set; }
        public int Quantity { get; set; }
        public required string Location { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Item: {Name} | Quantity: {Quantity} | Location: {Location}");
        }
    }
}
