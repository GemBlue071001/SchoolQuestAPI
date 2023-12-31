﻿using Domain.Enums;
namespace Domain.Models
{
    public class User : Base
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int? HighestScore { get; set; }
        public string? Address { get; set; }
        public UserRole Role { get; set; }
        public int GameToken {  get; set; }
        public bool AllowMbti {  get; set; } 

        //Property Navigation
        public List<Attempt> Attempts { get; set; }
        public List<MBTI_UserRecord> MBTI_UserRecords { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<StudentPurchased> StudentPurchaseds { get; set; }

    }
}
