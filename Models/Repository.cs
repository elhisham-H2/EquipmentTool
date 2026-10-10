using System.Collections.Generic;

namespace EquipmentTool.Models
{
    public static class Repository
    {
        private static int _nextRequestId = 1;
        private static readonly List<EquipmentRequest> _requests = new();

        private static readonly List<Equipment> _equipmentList = new()
        {
            new Equipment { Id = 1, Type = EquipmentType.Laptop, Description = "Dell XPS 15 (i7, 32GB RAM)", IsAvailable = true },
            new Equipment { Id = 2, Type = EquipmentType.Laptop, Description = "MacBook Pro 16 M1 Pro", IsAvailable = false },
            new Equipment { Id = 3, Type = EquipmentType.Phone, Description = "iPhone 15 Pro Test Unit", IsAvailable = true },
            new Equipment { Id = 4, Type = EquipmentType.Phone, Description = "Google Pixel 8 Developer Device", IsAvailable = false },
            new Equipment { Id = 5, Type = EquipmentType.Tablet, Description = "iPad Air 11-inch with Pencil", IsAvailable = true },
            new Equipment { Id = 6, Type = EquipmentType.Tablet, Description = "Samsung Galaxy Tab S9", IsAvailable = false },
            new Equipment { Id = 7, Type = EquipmentType.Another, Description = "Raspberry Pi 5 8GB Starter Kit", IsAvailable = true },
            new Equipment { Id = 8, Type = EquipmentType.Another, Description = "Arduino Sensor Lab Pack", IsAvailable = true }
        };

        public static IEnumerable<EquipmentRequest> Requests => _requests;

        public static IEnumerable<Equipment> AllEquipment => _equipmentList;

        public static void AddRequest(EquipmentRequest request)
        {
            request.Id = _nextRequestId++;
            _requests.Add(request);
        }
    }
}
