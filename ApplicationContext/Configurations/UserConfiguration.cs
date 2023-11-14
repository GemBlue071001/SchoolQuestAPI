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

            var studentPass = CreatePasswordHash("student");
            var studentPass1 = CreatePasswordHash("student1");
            var studentPass2 = CreatePasswordHash("student2");
            var studentPass3 = CreatePasswordHash("student3");
            var studentPass4 = CreatePasswordHash("student4");
            var studentPass5 = CreatePasswordHash("student5");
            var studentPass6 = CreatePasswordHash("student6");
            var studentPass7 = CreatePasswordHash("student7");
            var studentPass8 = CreatePasswordHash("student8");
            var studentPass9 = CreatePasswordHash("student9");
            var studentPass10 = CreatePasswordHash("student10");
            var studentPass11 = CreatePasswordHash("student11");
            var studentPass12 = CreatePasswordHash("student12");
            var studentPass13 = CreatePasswordHash("student13");
            var studentPass14 = CreatePasswordHash("student14");
            var studentPass15 = CreatePasswordHash("student15");
            var studentPass16 = CreatePasswordHash("student16");
            var studentPass17 = CreatePasswordHash("student17");
            var studentPass18 = CreatePasswordHash("student18");
            var studentPass19 = CreatePasswordHash("student19");
            var studentPass20 = CreatePasswordHash("student20");
            var studentPass21 = CreatePasswordHash("student21");
            var adminPass = CreatePasswordHash("admin");

            builder.HasData(
            new User
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
                Id = Guid.Parse("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                Email = "student2@gmail.com",
                PasswordHash = studentPass1.PasswordHash,
                PasswordSalt = studentPass1.PasswordSalt,
                FirstName = "Minh",
                LastName = "Vu",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student2",
                PhoneNumber = "1234567890",
                HighestScore = 9,
                Address = "Tran quoc toan"
            }, 
            new User
            {
                Id = Guid.Parse("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                Email = "student2@gmail.com",
                PasswordHash = studentPass2.PasswordHash,
                PasswordSalt = studentPass2.PasswordSalt,
                FirstName = "Minh",
                LastName = "Duc",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student2",
                PhoneNumber = "1234567890",
                HighestScore = 6,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                Email = "student3@gmail.com",
                PasswordHash = studentPass3.PasswordHash,
                PasswordSalt = studentPass3.PasswordSalt,
                FirstName = "Minh",
                LastName = "Quan",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student3",
                PhoneNumber = "1234567890",
                HighestScore = 7,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                Email = "student4@gmail.com",
                PasswordHash = studentPass4.PasswordHash,
                PasswordSalt = studentPass4.PasswordSalt,
                FirstName = "Minh",
                LastName = "Tam",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student4",
                PhoneNumber = "1234567890",
                HighestScore = 6,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                Email = "student5@gmail.com",
                PasswordHash = studentPass5.PasswordHash,
                PasswordSalt = studentPass5.PasswordSalt,
                FirstName = "Trinh",
                LastName = "Tam",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student5",
                PhoneNumber = "1234567890",
                HighestScore = 5,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("324ed66e-e8de-4710-a139-18c50b442945"),
                Email = "student6@gmail.com",
                PasswordHash = studentPass6.PasswordHash,
                PasswordSalt = studentPass6.PasswordSalt,
                FirstName = "Van",
                LastName = "Ba",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student6",
                PhoneNumber = "1234567890",
                HighestScore = 4,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                Email = "student7@gmail.com",
                PasswordHash = studentPass7.PasswordHash,
                PasswordSalt = studentPass7.PasswordSalt,
                FirstName = "Van",
                LastName = "Hung",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student7",
                PhoneNumber = "1234567890",
                HighestScore = 3,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                Email = "student8@gmail.com",
                PasswordHash = studentPass8.PasswordHash,
                PasswordSalt = studentPass8.PasswordSalt,
                FirstName = "Ly",
                LastName = "Hung",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student8",
                PhoneNumber = "1234567890",
                HighestScore = 2,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                Email = "student9@gmail.com",
                PasswordHash = studentPass9.PasswordHash,
                PasswordSalt = studentPass9.PasswordSalt,
                FirstName = "Ly",
                LastName = "Lac",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student9",
                PhoneNumber = "1234567890",
                HighestScore = 1,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                Email = "student10@gmail.com",
                PasswordHash = studentPass10.PasswordHash,
                PasswordSalt = studentPass10.PasswordSalt,
                FirstName = "Tran",
                LastName = "Hong",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student10",
                PhoneNumber = "1234567890",
                HighestScore = 9,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                Email = "student11@gmail.com",
                PasswordHash = studentPass11.PasswordHash,
                PasswordSalt = studentPass11.PasswordSalt,
                FirstName = "Nhan",
                LastName = "Hong",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student11",
                PhoneNumber = "1234567890",
                HighestScore = 10,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("e798134f-8d1b-41aa-98c1-c8914240366d"),
                Email = "student12@gmail.com",
                PasswordHash = studentPass12.PasswordHash,
                PasswordSalt = studentPass12.PasswordSalt,
                FirstName = "Nhan",
                LastName = "Chia",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student12",
                PhoneNumber = "1234567890",
                HighestScore = 7,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("8f744e72-da12-4038-a54e-7512a0ada884"),
                Email = "student13@gmail.com",
                PasswordHash = studentPass13.PasswordHash,
                PasswordSalt = studentPass13.PasswordSalt,
                FirstName = "Huan",
                LastName = "Hoe",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student13",
                PhoneNumber = "1234567890",
                HighestScore = 8,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                Email = "student14@gmail.com",
                PasswordHash = studentPass14.PasswordHash,
                PasswordSalt = studentPass14.PasswordSalt,
                FirstName = "Cook",
                LastName = "Lee",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student14",
                PhoneNumber = "1234567890",
                HighestScore = 1,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                Email = "student15@gmail.com",
                PasswordHash = studentPass15.PasswordHash,
                PasswordSalt = studentPass15.PasswordSalt,
                FirstName = "Trinh",
                LastName = "Quan",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student15",
                PhoneNumber = "1234567890",
                HighestScore = 1,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                Email = "student16@gmail.com",
                PasswordHash = studentPass16.PasswordHash,
                PasswordSalt = studentPass16.PasswordSalt,
                FirstName = "Trinh",
                LastName = "Trong",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student16",
                PhoneNumber = "1234567890",
                HighestScore = 5,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                Email = "student17@gmail.com",
                PasswordHash = studentPass17.PasswordHash,
                PasswordSalt = studentPass17.PasswordSalt,
                FirstName = "Kim",
                LastName = "Trong",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student17",
                PhoneNumber = "1234567890",
                HighestScore = 1,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                Email = "student18@gmail.com",
                PasswordHash = studentPass18.PasswordHash,
                PasswordSalt = studentPass18.PasswordSalt,
                FirstName = "Kim",
                LastName = "Ly",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student18",
                PhoneNumber = "1234567890",
                HighestScore = 10,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("666bc14a-4078-4619-85f1-bc63033c556f"),
                Email = "student19@gmail.com",
                PasswordHash = studentPass19.PasswordHash,
                PasswordSalt = studentPass19.PasswordSalt,
                FirstName = "Cach",
                LastName = "Ly",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student19",
                PhoneNumber = "1234567890",
                HighestScore = 2,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("96e0097f-ce73-4950-8ee2-89b313581154"),
                Email = "student20@gmail.com",
                PasswordHash = studentPass20.PasswordHash,
                PasswordSalt = studentPass20.PasswordSalt,
                FirstName = "Biet",
                LastName = "Ly",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student20",
                PhoneNumber = "1234567890",
                HighestScore = 3,
                Address = "Tran quoc toan"
            },
            new User
            {
                Id = Guid.Parse("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                Email = "student21@gmail.com",
                PasswordHash = studentPass21.PasswordHash,
                PasswordSalt = studentPass21.PasswordSalt,
                FirstName = "Bien",
                LastName = "Ly",
                Role = Domain.Enums.UserRole.Student,
                UserName = "student21",
                PhoneNumber = "1234567890",
                HighestScore = 4,
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
                HighestScore = null
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
