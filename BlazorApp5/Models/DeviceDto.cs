using System.Text.Json.Serialization;

namespace BlazorApp5.Models
{
    public class DeviceDto
    {
        
        [JsonPropertyName("BattVoltage")]
        public double BattVoltage { get; set; }

        [JsonPropertyName("ConcentratorId")]
        public int ConcentratorId { get; set; }

        [JsonPropertyName("DeviceId")]
        public int DeviceId { get; set; }

        [JsonPropertyName("IsLocked")]
        public bool IsLocked { get; set; }

        [JsonPropertyName("LastMsgReceived")]
        public string LastMsgReceived { get; set; }

        [JsonPropertyName("LockUnlockTag")]
        public string LockUnlockTag { get; set; }

        [JsonPropertyName("LockerName")]
        public string LockerName { get; set; }

        [JsonPropertyName("LockerNumber")]
        public int LockerNumber { get; set; }
    }
}
