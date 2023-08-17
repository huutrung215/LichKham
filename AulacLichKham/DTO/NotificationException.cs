namespace AulacLichKham.DTO
{
    public class NotificationException : Exception
    {
        public NotificationException(string notification) : base(notification) { }
    }
}
