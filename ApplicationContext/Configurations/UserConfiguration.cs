using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContext.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();

            var studentPass = CreatePasswordHash("student1");
            var adminPass = CreatePasswordHash("admin");

            builder.HasData(new User
            {
                Id = Guid.Parse("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                Email = "student@gmail.com",
                PasswordHash = studentPass.PasswordHash,
                PasswordSalt = studentPass.PasswordSalt,
                FirstName = "Nguyen",
                LastName = "Vu",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student1",
                PhoneNumber = "1234567890",
                HighestScore = 10,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                Email = "admin@gmail.com",
                PasswordHash = adminPass.PasswordHash,
                PasswordSalt = adminPass.PasswordSalt,
                FirstName = "admin",
                LastName = "admin",
                Role = Domain.Enums.UserRole.Admin,
                UserName = "admin",
                PhoneNumber = "1234567890",
                Address = "tran quoc toan",
                HighestScore = 10
            }
            );
        }


        private PasswordDTO CreatePasswordHash(string password)
        {
            PasswordDTO pass = new PasswordDTO();
            using (var hmac = new HMACSHA512())
            {
                pass.PasswordSalt = hmac.Key;
                pass.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
            return pass;
        }

        public class PasswordDTO
        {
            public byte[] PasswordHash { get; set; } = new byte[32];
            public byte[] PasswordSalt { get; set; } = new byte[32];
        }

    }
}
