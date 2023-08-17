﻿namespace AulacLichKham.DTO
{
    public class ErrorResponse
    {
        public bool? Success { get; set; } = false;
        public string? Message { get; set; }
        public ErrorResponse(string? message)
        {
            Message = message;
        }
    }
}
