using ApplicationContext.Migrations;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContext.Configurations
{
    public class MajorConfiguration : IEntityTypeConfiguration<Major>
    {
        public void Configure(EntityTypeBuilder<Major> builder)
        {
            builder.HasData(
                new Major()
                {
                    Id = Guid.Parse("c731c3f5-a1d2-4b8f-bd7f-2d57fa0acb0f"),
                    MajorName = "Kỹ thuật phần mềm",
                    Code = "KTPM",
                    Description = "Học về thiết kế phần mềm",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("63da08f2-e70f-488d-8d5a-eb24063697e5"),
                    MajorName = "Khoa học máy tính",
                    Code = "KHMT",
                    Description = "Nghiên cứu lý thuyết và thuật toán máy tính",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("2b72f32c-5d96-4b5d-ae68-597bbeead505"),
                    MajorName = "An toàn thông tin",
                    Code = "ATTT",
                    Description = "Nghiên cứu và bảo mật hệ thống thông tin",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("f5e68a91-1e8e-4ef7-9f0d-6da923dc5611"),
                    MajorName = "Trí tuệ nhân tạo",
                    Code = "TTNT",
                    Description = "Nghiên cứu và ứng dụng trí tuệ nhân tạo",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("ce320b5a-4eac-4436-92ef-90b985aec10f"),
                    MajorName = "Makerting",
                    Code = "MK",
                    Description = "Makerting",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("1b320b9a-3eac-4336-92ef-90b985aec101"),
                    MajorName = "Quản trị kinh doanh",
                    Code = "QTKD",
                    Description = "Ngành học về quản lý và điều hành các hoạt động trong doanh nghiệp",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("2c430b7a-5eac-4536-93ef-80b985aec202"),
                    MajorName = "Marketing",
                    Code = "MKT",
                    Description = "Ngành học về phân tích thị trường và xây dựng chiến lược marketing",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("3d550b8a-6eac-4636-92ef-70b985aec303"),
                    MajorName = "Kinh doanh quốc tế",
                    Code = "KDQT",
                    Description = "Ngành học về kinh doanh và thương mại giữa các quốc gia",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("4e661b9a-7eac-4736-92ef-60b985aec404"),
                    MajorName = "Kế toán",
                    Code = "KT",
                    Description = "Ngành học về công tác ghi chép, phân tích và kiểm tra các nghiệp vụ tài chính",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("1a111b2a-1eac-4132-92ef-90b985ae0101"),
                    MajorName = "Y khoa",
                    Code = "YK",
                    Description = "Ngành học về chẩn đoán, điều trị bệnh và nâng cao sức khỏe",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("2b222b3a-2eac-4233-93ef-80b985ae0202"),
                    MajorName = "Dược học",
                    Code = "DH",
                    Description = "Ngành học về nghiên cứu, phát triển và sản xuất thuốc",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("3c333b4a-3eac-4333-94ef-70b985ae0303"),
                    MajorName = "Điều dưỡng",
                    Code = "DD",
                    Description = "Ngành học về chăm sóc người bệnh tại các cơ sở y tế",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("4d444b5a-4eac-4434-95ef-60b985ae0404"),
                    MajorName = "Răng-Hàm-Mặt",
                    Code = "RHM",
                    Description = "Ngành học về phục hình, nha khoa và chỉnh nha",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("5e555b6a-5eac-4535-96ef-50b985ae0505"),
                    MajorName = "Y học cổ truyền",
                    Code = "YHCT",
                    Description = "Ngành học về phương pháp chữa bệnh bằng y học cổ truyền",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("a52a3b15-3a21-44cd-8d74-b4c6751e2963"),
                    MajorName = "Sư phạm toán học",
                    Code = "SPTH",
                    Description = "Đào tạo giáo viên toán học",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },
                new Major()
                {
                    Id = Guid.Parse("1dcd3794-f8d5-4d4e-9788-74a3b9426421"),
                    MajorName = "Sư phạm ngữ văn",
                    Code = "SPNV",
                    Description = "Đào tạo giáo viên ngữ văn",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },

                new Major()
                {
                    Id = Guid.Parse("cf3913ca-fa92-4f90-a55b-93725cae4b32"),
                    MajorName = "Sư phạm tiếng Anh",
                    Code = "SPTA",
                    Description = "Đào tạo giáo viên tiếng Anh",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },            
                new Major()
                {
                    Id = Guid.Parse("7ea9448b-e686-49e2-a0df-c425bd44f3ea"),
                    MajorName = "Quản lý giáo dục",
                    Code = "QLGD",
                    Description = "Đào tạo quản lý ngành giáo dục",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },
                new Major()
                {
                    Id = Guid.Parse("387c472b-1f7d-4655-838c-80982b8f9e24"),
                    MajorName = "Thiết kế đồ họa",
                    Code = "TDĐH",
                    Description = "Thiết kế các sản phẩm truyền thông đồ họa",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                },
                new Major()
                {
                    Id = Guid.Parse("b629fa64-5dea-4129-9d59-f48c265bca62"),
                    MajorName = "Thiết kế thời trang",
                    Code = "TDTT",
                    Description = "Thiết kế các sản phẩm thời trang",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                },
                new Major()
                {
                    Id = Guid.Parse("44929c3d-dd91-4405-9d4e-f4be315b7fbb"),
                    MajorName = "Thiết kế nội thất",
                    Code = "TDNT",
                    Description = "Thiết kế các sản phẩm nội thất",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                },
                new Major()
                {
                    Id = Guid.Parse("17d5462c-3a8a-4e93-b5e6-69d36186577e"),
                    MajorName = "Điêu khắc",
                    Code = "DK",
                    Description = "Đào tạo nghệ thuật điêu khắc",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                }
                );
        }
    }
}
