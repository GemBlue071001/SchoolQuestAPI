﻿using Domain.Enums;
using System.Text.Json.Serialization;

namespace BusinessLogicLayer.ResponseModel.User
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserRole Role { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
