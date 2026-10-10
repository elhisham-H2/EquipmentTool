using System.Collections.Generic;

namespace EquipmentTool.Models
{
    public static class Repository
    {
        private static int _nextRequestId = 1;
        private static readonly List<EquipmentRequest> _requests = new();

        public static IEnumerable<EquipmentRequest> Requests => _requests;

        public static void AddRequest(EquipmentRequest request)
        {
            request.Id = _nextRequestId++;
            _requests.Add(request);
        }
    }
}
