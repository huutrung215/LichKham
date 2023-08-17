namespace AulacLichKham.DTO.GetRFID
{
    public class GetRFIDPDTO
    {
        public string? DeviceID { get; set; }
        public string? ID { get; set; }
    }

    public class GetRFIDPResponse
    {
        public string? StatusCode { get; set; }
    }

    public class GetRFID2Response
    {
        public string? StatusCode { get; set; }
        public string? Data { get; set; }
    }
}
