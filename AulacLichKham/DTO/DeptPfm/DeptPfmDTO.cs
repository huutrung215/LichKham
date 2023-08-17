using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Utils;
using System.Text.Json.Serialization;

namespace AulacLichKham.DTO.DeptPfm
{
    public class DeptPfmDTO
    {
        [JsonPropertyName("DeptCurePrkID")]
        public string? DeptPrkID { get; set; }
        [JsonPropertyName("DeptCureID")]
        public string? DeptID { get; set; }
        [JsonPropertyName("DeptCureName")]
        public string? DeptName { get; set; }
        [JsonPropertyName("CountExamInDept")]
        public int? SL { get; set; }
    }
}
