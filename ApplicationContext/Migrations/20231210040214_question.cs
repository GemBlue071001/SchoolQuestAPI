using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class question : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 12, 10, 4, 2, 13, 945, DateTimeKind.Utc).AddTicks(1418), new DateTime(2023, 12, 11, 4, 2, 13, 945, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreatedBy", "IsDeleted", "ModifiedBy", "ModifiedDate", "TopicId" },
                values: new object[,]
                {
                    { new Guid("043ce175-c8d9-421e-a4fe-c56bec91b704"), "{\"Question\":\"C\\u00E1c d\\u00E2n t\\u1ED9c c\\u00F3 quy\\u1EC1n d\\u00F9ng ti\\u1EBFng n\\u00F3i, ch\\u1EEF vi\\u1EBFt c\\u1EE7a m\\u00ECnh l\\u00E0 n\\u1ED9i dung b\\u00ECnh \\u0111\\u1EB3ng v\\u1EC1\",\"ListAnswer\":[{\"Value\":\"V\\u0103n h\\u00F3a\",\"IsAnswer\":true},{\"Value\":\"X\\u00E3 h\\u1ED9i\",\"IsAnswer\":false},{\"Value\":\"Ch\\u00EDnh tr\\u1ECB\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("b80adb23-18d3-4b5e-9fc0-2fa25d47dd49") },
                    { new Guid("17a5ca0d-c4da-4554-a714-e0b9badada82"), "{\"Question\":\"Trong c\\u01A1 c\\u1EA5u lao \\u0111\\u1ED9ng c\\u00F3 vi\\u1EC7c l\\u00E0m \\u1EDF n\\u01B0\\u1EDBc ta ph\\u00E2n theo tr\\u00ECnh \\u0111\\u1ED9 chuy\\u00EAn m\\u00F4n k\\u0129 thu\\u1EADt, th\\u00E0nh ph\\u1EA7n chi\\u1EBFm t\\u1EC9 tr\\u1ECDng cao nh\\u1EA5t l\\u00E0\",\"ListAnswer\":[{\"Value\":\"Ch\\u01B0a qua \\u0111\\u00E0o t\\u1EA1o\",\"IsAnswer\":true},{\"Value\":\"Cao \\u0111\\u1EB3ng, \\u0111\\u1ECBa h\\u1ECDc, tr\\u00EAn \\u0111\\u1EA1i h\\u1ECDc\",\"IsAnswer\":false},{\"Value\":\"C\\u00F3 ch\\u1EE9ng ch\\u1EC9 s\\u01A1 c\\u1EA5p\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("370bb392-410b-46b5-9971-2df9a53e7670") },
                    { new Guid("188c4fda-2283-4ab1-8eae-e1f9db22a2b0"), "{\"Question\":\"S\\u1EF1 ph\\u00E1t sinh, ph\\u00E1t tri\\u1EC3n c\\u1EE7a s\\u1EF1 s\\u1ED1ng tr\\u00EAn Tr\\u00E1i \\u0110\\u1EA5t l\\u1EA7n l\\u01B0\\u1EE3t tr\\u1EA3i qua c\\u00E1c giai \\u0111o\\u1EA1n:\",\"ListAnswer\":[{\"Value\":\"Ti\\u1EBFn h\\u00F3a h\\u00F3a h\\u1ECDc \\u2013 ti\\u1EBFn h\\u00F3a ti\\u1EC1n sinh h\\u1ECDc - ti\\u1EBFn h\\u00F3a sinh h\\u1ECDc\",\"IsAnswer\":true},{\"Value\":\"Ti\\u1EBFn h\\u00F3a h\\u00F3a h\\u1ECDc \\u2013 ti\\u1EBFn h\\u00F3a sinh h\\u1ECDc.\",\"IsAnswer\":false},{\"Value\":\"Ti\\u1EBFn h\\u00F3a sinh h\\u1ECDc \\u2013 ti\\u1EBFn h\\u00F3a h\\u00F3a h\\u1ECDc \\u2013 ti\\u1EBFn h\\u00F3a ti\\u1EC1n sinh h\\u1ECDc.\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("03699ee1-aa9b-4695-8593-8112a5b7145f") },
                    { new Guid("1abf63a6-2a63-4b91-bd36-856c13309419"), "{\"Question\":\"Trong ph\\u00F2ng th\\u00ED nghi\\u1EC7m, ng\\u01B0\\u1EDDi ta s\\u1EED d\\u1EE5ng 3 lo\\u1EA1i nucleotit c\\u1EA5u t\\u1EA1o n\\u00EAn ARN \\u0111\\u1EC3 t\\u1ED5ng h\\u1EE3p 1 ph\\u00E2n t\\u1EED mARN nh\\u00E2n t\\u1EA1o. Ph\\u00E2n t\\u1EED mARN n\\u00E0y ch\\u1EC9 c\\u00F3 th\\u1EC3 th\\u1EF1c hi\\u1EC7n \\u0111\\u01B0\\u1EE3c d\\u1ECBch m\\u00E3 khi 3 lo\\u1EA1i nucleotit \\u0111\\u01B0\\u1EE3c s\\u1EED d\\u1EE5ng l\\u00E0\",\"ListAnswer\":[{\"Value\":\"U, G v\\u00E0 X\",\"IsAnswer\":false},{\"Value\":\"G, A v\\u00E0 X\",\"IsAnswer\":false},{\"Value\":\"G, A v\\u00E0 U\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("533446a5-2f4c-4618-a441-f02bad78e322") },
                    { new Guid("208c8070-f3bd-4caa-8a72-fcfc805a2756"), "{\"Question\":\"D\\u00E2n s\\u1ED1 Vi\\u1EC7t Nam n\\u0103m 2015 l\\u00E0 91,71 tri\\u1EC7u ng\\u01B0\\u1EDDi. Gi\\u1EA3 s\\u1EED trong 5 n\\u0103m t\\u1EC9 l\\u1EC7 t\\u0103ng d\\u00E2n s\\u1ED1 l\\u00E0 kh\\u00F4ng \\u0111\\u1ED5i. H\\u1ECFi t\\u1EC9 l\\u1EC7 n\\u00E0y c\\u00F3 th\\u1EC3 nh\\u1EADn gi\\u00E1 tr\\u1ECB t\\u1ED1i \\u0111a l\\u00E0 bao nhi\\u00EAu \\u0111\\u1EC3 d\\u00E2n s\\u1ED1 Vi\\u1EC7t Nam n\\u0103m 2020 kh\\u00F4ng v\\u01B0\\u1EE3t qu\\u00E1 96,5 tri\\u1EC7u ng\\u01B0\\u1EDDi (l\\u00E0m tr\\u00F2n k\\u1EBFt qu\\u1EA3 \\u0111\\u1EBFn ph\\u1EA7n ch\\u1EE5c ngh\\u00ECn) ?\",\"ListAnswer\":[{\"Value\":\"1,08%\",\"IsAnswer\":false},{\"Value\":\"1,02%\",\"IsAnswer\":true},{\"Value\":\"0,91%\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("f9c20b6d-10ed-4d8c-bb76-f418113c4a8e") },
                    { new Guid("2688e556-145c-4f09-8dbc-8e475b30f79e"), "{\"Question\":\"Reading \\u2026\\u2026 an integral role in enhancing knowledge and relaxing.\",\"ListAnswer\":[{\"Value\":\"holds \",\"IsAnswer\":false},{\"Value\":\"plays\",\"IsAnswer\":true},{\"Value\":\"takes\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("470c4063-38b5-437c-9820-2a29a470c708") },
                    { new Guid("2c845a9e-bf68-475f-8cdc-90d3634e44bb"), "{\"Question\":\"L\\u00EAn men m gam glucoz\\u01A1 v\\u1EDBi hi\\u1EC7u su\\u1EA5t 90%, l\\u01B0\\u1EE3ng kh\\u00ED CO2 sinh ra h\\u1EA5p th\\u1EE5 h\\u1EBFt v\\u00E0o n\\u01B0\\u1EDBc v\\u00F4i trong, thu \\u0111\\u01B0\\u1EE3c 10 gam k\\u1EBFt t\\u1EE7a. Kh\\u1ED1i l\\u01B0\\u1EE3ng dung d\\u1ECBch sau ph\\u1EA3n \\u1EE9ng gi\\u1EA3m 3,4 gam so v\\u1EDBi kh\\u1ED1i l\\u01B0\\u1EE3ng ban \\u0111\\u1EA7u. Gi\\u00E1 tr\\u1ECB c\\u1EE7a m l\\u00E0\",\"ListAnswer\":[{\"Value\":\"15,0.\",\"IsAnswer\":true},{\"Value\":\"30\",\"IsAnswer\":false},{\"Value\":\"13,5\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("9207680f-4c5e-4725-aec7-85d64102b0e9") },
                    { new Guid("30746883-03fd-47aa-99eb-d9c0c3c39f93"), "{\"Question\":\"Ph\\u00E2\\u0300n th\\u01B0\\u0323c cu\\u0309a s\\u00F4\\u0301 ph\\u01B0\\u0301c z = -i la\\u0300\",\"ListAnswer\":[{\"Value\":\"1\",\"IsAnswer\":false},{\"Value\":\"0\",\"IsAnswer\":true},{\"Value\":\"-i\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("74d64b16-20e1-4f3c-9f54-facf73dd9740") },
                    { new Guid("32cea7fb-b070-4f98-a1af-e5d7fdb494e2"), "{\"Question\":\"Ti\\u0300m ca\\u0301c s\\u00F4\\u0301 th\\u01B0\\u0323c x, y sao cho (x \\u2013 2y) \\u002B (x \\u002B y \\u002B 4).i = (2x \\u002B y) \\u002B 2yi.\",\"ListAnswer\":[{\"Value\":\"x = -3, y = 1\",\"IsAnswer\":true},{\"Value\":\"x = -3, y = -1\",\"IsAnswer\":false},{\"Value\":\"x = 3, y = 1 \",\"IsAnswer\":false}]}", null, false, null, null, new Guid("74d64b16-20e1-4f3c-9f54-facf73dd9740") },
                    { new Guid("37c803d8-be52-48c9-af20-aa586878cd6f"), "{\"Question\":\"V\\u1EDBi gi\\u00E1 tr\\u1ECB n\\u00E0o c\\u1EE7a m, h\\u00E0m s\\u1ED1 y = (x - m)^3 - 3x \\u0111\\u1EA1t c\\u1EF1c ti\\u1EC3u t\\u1EA1i \\u0111i\\u1EC3m c\\u00F3 ho\\u00E0nh \\u0111\\u1ED9 x = 0?\",\"ListAnswer\":[{\"Value\":\"-1\",\"IsAnswer\":true},{\"Value\":\"1\",\"IsAnswer\":false},{\"Value\":\"Kh\\u00F4ng t\\u1ED3n t\\u1EA1i\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("7612387b-bd34-4ff2-bc52-535d32fe45ec") },
                    { new Guid("3848919c-ba2f-41f3-8c50-176275dd76cb"), "{\"Question\":\"N\\u0103m 1977, Vi\\u1EC7t Nam tr\\u1EDF th\\u00E0nh th\\u00E0nh vi\\u00EAn th\\u1EE9 m\\u1EA5y c\\u1EE7a Li\\u00EAn h\\u1EE3p qu\\u1ED1c?\",\"ListAnswer\":[{\"Value\":\"Th\\u00E0nh vi\\u00EAn th\\u1EE9 148\",\"IsAnswer\":false},{\"Value\":\"Th\\u00E0nh vi\\u00EAn th\\u1EE9 149\",\"IsAnswer\":true},{\"Value\":\"Th\\u00E0nh vi\\u00EAn th\\u1EE9 147\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("c5470d64-b50b-447c-8d89-fc5b9bf338d3") },
                    { new Guid("3e62a92e-e050-42b4-8d13-4194ecac2f42"), "{\"Question\":\"The Spirit of \\u2026\\u2026 22nd SEA GAMES was solidarity, co-operation for peace and development.\",\"ListAnswer\":[{\"Value\":\"the\",\"IsAnswer\":true},{\"Value\":\"a\",\"IsAnswer\":false},{\"Value\":\"an\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("838f30bd-d9cf-4ea6-8825-fe729c55e5af") },
                    { new Guid("45d36bbc-a0fb-44bb-9d53-0a957348a341"), "{\"Question\":\"C\\u00F4ng d\\u00E2n c\\u00F3 th\\u1EC3 h\\u1ECDc b\\u1EA5t c\\u1EE9 ng\\u00E0nh, ngh\\u1EC1 n\\u00E0o ph\\u00F9 h\\u1EE3p v\\u1EDBi\",\"ListAnswer\":[{\"Value\":\"M\\u1EE5c \\u0111\\u00EDch, y\\u00EAu c\\u1EA7u c\\u1EE7a b\\u1EA3n th\\u00E2n v\\u00E0 \\u0111i\\u1EC1u ki\\u1EC7n c\\u1EE7a gia \\u0111\\u00ECnh\",\"IsAnswer\":false},{\"Value\":\"M\\u1EE5c \\u0111\\u00EDch, s\\u1EDF th\\u00EDch, \\u0111i\\u1EC1u ki\\u1EC7n v\\u00E0 \\u0111am m\\u00EA c\\u1EE7a m\\u00ECnh\",\"IsAnswer\":false},{\"Value\":\"N\\u0103ng khi\\u1EBFu, kh\\u1EA3 n\\u0103ng, s\\u1EDF th\\u00EDch v\\u00E0 \\u0111i\\u1EC1u ki\\u1EC7n c\\u1EE7a m\\u00ECnh\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("7b39b159-82aa-48a9-9dd1-6d0b435f50be") },
                    { new Guid("479690de-b69a-4652-b0db-49545b76a26e"), "{\"Question\":\"M\\u1ED9t c\\u00F4ng ti qu\\u1EA3n l\\u00ED chu\\u1EA9n b\\u1ECB x\\u00E2y d\\u1EF1ng m\\u1ED9t khu chung c\\u01B0 m\\u1EDBi. H\\u1ECD t\\u00EDnh to\\u00E1n n\\u1EBFu t\\u00F2a nh\\u00E0 c\\u00F3 x c\\u0103n h\\u1ED9 th\\u00EC chi ph\\u00ED b\\u1EA3o tr\\u00EC c\\u1EE7a t\\u00F2a nh\\u00E0 l\\u00E0: C(x) = 4000 - 14x \\u002B 0,04x^2. Khu \\u0111\\u1EA5t c\\u1EE7a h\\u1ECD c\\u00F3 th\\u1EC3 x\\u00E2y \\u0111\\u01B0\\u1EE3c t\\u00F2a nh\\u00E0 ch\\u1EE9a t\\u1ED1i \\u0111a 300 c\\u0103n h\\u1ED9. H\\u1ECFi h\\u1ECD n\\u00EAn x\\u00E2y d\\u1EF1ng t\\u00F2a nh\\u00E0 c\\u00F3 bao nhi\\u00EAu c\\u0103n h\\u1ED9 \\u0111\\u1EC3 chi ph\\u00ED b\\u1EA3o tr\\u00EC c\\u1EE7a t\\u00F2a nh\\u00E0 l\\u00E0 nh\\u1ECF nh\\u1EA5t?\",\"ListAnswer\":[{\"Value\":\"150\",\"IsAnswer\":false},{\"Value\":\"175\",\"IsAnswer\":true},{\"Value\":\"225\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("e83b8918-df70-4d49-8ddc-adcdac56a057") },
                    { new Guid("51c0e4fa-7565-4230-9dd6-cd40f4667ccc"), "{\"Question\":\"H\\u1EC7 sinh th\\u00E1i t\\u1EF1 nhi\\u00EAn c\\u00F3 c\\u1EA5u tr\\u00FAc \\u1ED5n \\u0111\\u1ECBnh v\\u00E0 ho\\u00E0n ch\\u1EC9nh v\\u00EC\",\"ListAnswer\":[{\"Value\":\"c\\u00F3 nhi\\u1EC1u chu\\u1ED7i v\\u00E0 l\\u01B0\\u1EDBi th\\u1EE9c \\u0103n\",\"IsAnswer\":false},{\"Value\":\"c\\u00F3 s\\u1EF1 \\u0111a d\\u1EA1ng sinh h\\u1ECDc\",\"IsAnswer\":true},{\"Value\":\"c\\u00F3 c\\u1EA5u tr\\u00FAc l\\u1EDBn nh\\u1EA5t\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("356135ae-0bc9-4560-af03-191995168919") },
                    { new Guid("5801238f-e7f7-4335-8e99-f92728cc6d59"), "{\"Question\":\"Ng\\u00E0y 27 th\\u00E1ng 3 n\\u0103m 2016 b\\u00E0 Mai g\\u1EEDi ti\\u1EBFt ki\\u1EC7m v\\u00E0o ng\\u00E2n h\\u00E0ng s\\u1ED1 ti\\u1EC1n 100 tri\\u1EC7u \\u0111\\u1ED3ng v\\u1EDBi h\\u00ECnh th\\u1EE9c l\\u00E3i k\\u00E9p v\\u00E0 l\\u00E3i su\\u1EA5t 6,8% m\\u1ED9t n\\u0103m. B\\u00E0 Mai d\\u1EF1 t\\u00EDnh \\u0111\\u1EBFn ng\\u00E0y 27 th\\u00E1ng 3 n\\u0103m 2020 th\\u00EC r\\u00FAt h\\u1EBFt ti\\u1EC1n ra \\u0111\\u1EC3 lo c\\u00F4ng chuy\\u1EC7n. H\\u1ECFi b\\u00E0 s\\u1EBD r\\u00FAt \\u0111\\u01B0\\u1EE3c bao nhi\\u00EAu ti\\u1EC1n (l\\u00E0m tr\\u00F2n k\\u1EBFt qu\\u1EA3 \\u0111\\u1EBFn h\\u00E0ng ngh\\u00ECn) ?\",\"ListAnswer\":[{\"Value\":\"38949000 \\u0111\\u1ED3ng\",\"IsAnswer\":false},{\"Value\":\"31259000 \\u0111\\u1ED3ng\",\"IsAnswer\":false},{\"Value\":\"30102000 \\u0111\\u1ED3ng\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("f9c20b6d-10ed-4d8c-bb76-f418113c4a8e") },
                    { new Guid("58aca4f0-7ef3-4d69-828b-35d19e42cace"), "{\"Question\":\"Trong 1 qu\\u1EA7n th\\u1EC3 giao ph\\u1ED1i, nh\\u1EADn \\u0111\\u1ECBnh n\\u00E0o d\\u01B0\\u1EDBi \\u0111\\u00E2y l\\u00E0 \\u0111\\u00FAng?\",\"ListAnswer\":[{\"Value\":\"T\\u1EA7n s\\u1ED1 t\\u01B0\\u01A1ng \\u0111\\u1ED1i c\\u1EE7a c\\u00E1c alen trong 1gen n\\u00E0o \\u0111\\u00F3 l\\u00E0 kh\\u00F4ng \\u0111\\u1EB7c tr\\u01B0ng cho t\\u1EEBng qu\\u1EA7n th\\u1EC3.\",\"IsAnswer\":false},{\"Value\":\"T\\u1EA7n s\\u1ED1 t\\u01B0\\u01A1ng \\u0111\\u1ED1i c\\u1EE7a c\\u00E1c alen trong 1gen n\\u00E0o \\u0111\\u00F3 l\\u00E0 \\u0111\\u1EB7c tr\\u01B0ng cho t\\u1EEBng qu\\u1EA7n th\\u1EC3.\",\"IsAnswer\":false},{\"Value\":\"T\\u1EA7n s\\u1ED1 t\\u01B0\\u01A1ng \\u0111\\u1ED1i c\\u1EE7a c\\u00E1c ki\\u1EC3u gen c\\u00F3 t\\u00EDnh \\u0111\\u1EB7c tr\\u01B0ng cho t\\u1EEBng qu\\u1EA7n th\\u1EC3.\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("0546ebd3-376e-4246-bdb3-9ae20e6f253c") },
                    { new Guid("5c780d44-d323-48ad-9cc4-8f03b61c6678"), "{\"Question\":\"Ph\\u00E1p lu\\u1EADt \\u0111\\u01B0\\u1EE3c Nh\\u00E0 n\\u01B0\\u1EDBc ban h\\u00E0nh v\\u00E0 b\\u1EA3o \\u0111\\u1EA3m th\\u1EF1c hi\\u1EC7n b\\u1EB1ng\",\"ListAnswer\":[{\"Value\":\"\\u00DD ch\\u00ED c\\u1EE7a Nh\\u00E0 n\\u01B0\\u1EDBc\",\"IsAnswer\":false},{\"Value\":\"Quy\\u1EC1n l\\u1EF1c Nh\\u00E0 n\\u01B0\\u1EDBc\",\"IsAnswer\":true},{\"Value\":\"D\\u01B0 lu\\u1EADn x\\u00E3 h\\u1ED9i.\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("28bbe836-de18-4d85-9555-a47d95f85a5f") },
                    { new Guid("65fce6a4-b1fc-4cea-a040-5fd0cf7e0958"), "{\"Question\":\"Cho h\\u00E0m s\\u1ED1 y = - x^3 \\u002B 3x^2 - 3x \\u002B 1, m\\u1EC7nh \\u0111\\u1EC1 n\\u00E0o sau \\u0111\\u00E2y l\\u00E0 \\u0111\\u00FAng?\",\"ListAnswer\":[{\"Value\":\"H\\u00E0m s\\u1ED1 lu\\u00F4n ngh\\u1ECBch bi\\u1EBFn.\",\"IsAnswer\":true},{\"Value\":\"H\\u00E0m s\\u1ED1 lu\\u00F4n \\u0111\\u1ED3ng bi\\u1EBFn\",\"IsAnswer\":false},{\"Value\":\"H\\u00E0m s\\u1ED1 \\u0111\\u1EA1t c\\u1EF1c \\u0111\\u1EA1i t\\u1EA1i x = 1\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("77963fa2-2bc8-4273-929b-835f0efd31f6") },
                    { new Guid("67077697-1769-4658-b9ce-e443180e6ff4"), "{\"Question\":\"Quy tr\\u00ECnh t\\u1EA1o ra nh\\u1EEFng t\\u1EBF b\\u00E0o ho\\u1EB7c sinh v\\u1EADt c\\u00F3 gen b\\u1ECB bi\\u1EBFn \\u0111\\u1ED5i ho\\u1EB7c c\\u00F3 th\\u00EAm gen m\\u1EDBi, t\\u1EEB \\u0111\\u00F3 t\\u1EA1o ra c\\u00E1c c\\u01A1 th\\u1EC3 v\\u1EDBi nh\\u1EEFng \\u0111\\u1EB7c \\u0111i\\u1EC3m m\\u1EDBi \\u0111\\u01B0\\u1EE3c g\\u1ECDi l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"c\\u00F4ng ngh\\u1EC7 vi sinh v\\u1EADt\",\"IsAnswer\":false},{\"Value\":\"c\\u00F4ng ngh\\u1EC7 gen\",\"IsAnswer\":true},{\"Value\":\"c\\u00F4ng ngh\\u1EC7 t\\u1EBF b\\u00E0o\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("45b651e7-9e76-42d0-b996-aeb00ec00d3f") },
                    { new Guid("6d8d0d49-2fcb-438b-b0f7-16496a737a6c"), "{\"Question\":\"\\u0110\\u1EA3m b\\u1EA3o quy\\u1EC1n b\\u00ECnh \\u0111\\u1EB3ng c\\u1EE7a c\\u00F4ng d\\u00E2n tr\\u01B0\\u1EDBc ph\\u00E1p lu\\u1EADt l\\u00E0 tr\\u00E1ch nhi\\u1EC7m c\\u1EE7a\",\"ListAnswer\":[{\"Value\":\"Nh\\u00E0 n\\u01B0\\u1EDBc v\\u00E0 c\\u00F4ng d\\u00E2n\",\"IsAnswer\":false},{\"Value\":\"Nh\\u00E0 n\\u01B0\\u1EDBc v\\u00E0 x\\u00E3 h\\u1ED9i.\",\"IsAnswer\":true},{\"Value\":\"Nh\\u00E0 n\\u01B0\\u1EDBc v\\u00E0 c\\u00F4ng d\\u00E2n\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("898a8245-bff3-4cbb-9ac4-8692cc84d2e1") },
                    { new Guid("6e6f683f-70cc-415a-bb0c-f0aa7962d649"), "{\"Question\":\"Polime n\\u00E0o sau \\u0111\\u00E2y thu\\u1ED9c lo\\u1EA1i polime thi\\u00EAn nhi\\u00EAn ?\",\"ListAnswer\":[{\"Value\":\"polietilen\",\"IsAnswer\":false},{\"Value\":\"tinh b\\u1ED9t\",\"IsAnswer\":true},{\"Value\":\"polistiren\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("cb01694c-ebac-478c-bbef-6845d723e501") },
                    { new Guid("72606ff9-6cb1-4466-a9c1-f2143e68f4cf"), "{\"Question\":\"C\\u1EE7ng c\\u1ED1 qu\\u1ED1c ph\\u00F2ng, b\\u1EA3o v\\u1EC7 an ninh qu\\u1ED1c gia l\\u00E0 nhi\\u1EC7m v\\u1EE5 c\\u1EE7a to\\u00E0n d\\u00E2n m\\u00E0 n\\u00F2ng c\\u1ED1t l\\u00E0\",\"ListAnswer\":[{\"Value\":\"C\\u00F4ng an nh\\u00E2n d\\u00E2n\",\"IsAnswer\":false},{\"Value\":\"Qu\\u00E2n \\u0111\\u1ED9i nh\\u00E2n d\\u00E2n\",\"IsAnswer\":false},{\"Value\":\"Qu\\u00E2n \\u0111\\u1ED9i nh\\u00E2n d\\u00E2n v\\u00E0 C\\u00F4ng an nh\\u00E2n d\\u00E2n\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("72c5c4ca-e8f8-4b02-97cd-4666ab7ccd44") },
                    { new Guid("733909fe-c214-4d72-b6fc-f4c8e176f842"), "{\"Question\":\"Hi\\u1EC7n t\\u01B0\\u1EE3ng kh\\u1ED1ng ch\\u1EBF sinh h\\u1ECDc \\u0111\\u00E3\",\"ListAnswer\":[{\"Value\":\"\\u0111\\u1EA3m b\\u1EA3o c\\u00E2n b\\u1EB1ng sinh th\\u00E1i trong qu\\u1EA7n x\\u00E3\",\"IsAnswer\":true},{\"Value\":\"l\\u00E0m cho m\\u1ED9t lo\\u00E0i b\\u1ECB ti\\u00EAu di\\u1EC7t\",\"IsAnswer\":false},{\"Value\":\"m\\u1EA5t c\\u00E2n b\\u1EB1ng trong qu\\u1EA7n x\\u00E3\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("49d712a6-e7ca-4252-a430-308f954047ff") },
                    { new Guid("75a4aef4-0914-4509-a778-149c8c18edce"), "{\"Question\":\"M\\u1ED7i lo\\u00E0i giao ph\\u1ED1i l\\u00E0 m\\u1ED9t t\\u1ED5 ch\\u1EE9c t\\u1EF1 nhi\\u00EAn, c\\u00F3 t\\u00EDnh to\\u00E0n v\\u1EB9n l\\u00E0 do c\\u00E1ch li\",\"ListAnswer\":[{\"Value\":\"di truy\\u1EC1n\",\"IsAnswer\":false},{\"Value\":\"sinh s\\u1EA3n\",\"IsAnswer\":true},{\"Value\":\"sinh th\\u00E1i\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("b2a7a480-c0e9-424a-a3cf-e35ed4f7e794") },
                    { new Guid("75e9556c-f0b0-4b3b-b2d1-c34f19e7491b"), "{\"Question\":\"T\\u00E2y Nguy\\u00EAn c\\u00F3 v\\u1ECB tr\\u00ED \\u0111\\u1EB7c bi\\u1EC7t v\\u1EC1 m\\u1EB7t qu\\u1ED1c ph\\u00F2ng v\\u00EC\",\"ListAnswer\":[{\"Value\":\"Gi\\u00E1p v\\u1EDBi v\\u00F9ng Duy\\u00EAn h\\u1EA3i Nam Trung B\\u1ED9\",\"IsAnswer\":false},{\"Value\":\"R\\u1EA5t g\\u1EA7n v\\u1EDBi TP H\\u1ED3 Ch\\u00ED Minh\",\"IsAnswer\":false},{\"Value\":\"C\\u00F3 bi\\u00EAn gi\\u1EDBi k\\u00E9o d\\u00E0i v\\u1EDBi L\\u00E0o v\\u00E0 Campuchia\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("020841e0-c4da-4010-9556-e67ad0b7d816") },
                    { new Guid("75eeeaf3-5d75-48e4-aa8b-f18f4fbe81eb"), "{\"Question\":\"S\\u1EF1 ki\\u1EC7n Nenx\\u01A1n Man\\u0111\\u00EAla tr\\u1EDF th\\u00E0nh t\\u1ED5ng th\\u1ED1ng Nam Phi (1994) \\u0111\\u00E1nh d\\u1EA5u\",\"ListAnswer\":[{\"Value\":\"s\\u1EF1 ch\\u1EA5m d\\u1EE9t ho\\u00E0n to\\u00E0n ch\\u1EE7 ngh\\u0129a ph\\u00E2n bi\\u1EC7t ch\\u1EE7ng t\\u1ED9c \\u1EDF Nam Phi.\",\"IsAnswer\":true},{\"Value\":\"s\\u1EF1 s\\u1EE5p \\u0111\\u1ED5 ho\\u00E0n to\\u00E0n c\\u1EE7a ch\\u1EE7 ngh\\u0129a th\\u1EF1c d\\u00E2n c\\u0169 tr\\u00EAn th\\u1EBF gi\\u1EDBi.\",\"IsAnswer\":false},{\"Value\":\"s\\u1EF1 th\\u1EAFng l\\u1EE3i c\\u1EE7a phong tr\\u00E0o gi\\u1EA3i ph\\u00F3ng d\\u00E2n t\\u1ED9c \\u1EDF ch\\u00E2u Phi.\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("c20ee29b-c548-4a55-9f5c-2c78113b445e") },
                    { new Guid("760f9cce-e1bf-415f-9432-71cc69c9af85"), "{\"Question\":\"The USA is a country of high youth unemployment.\",\"ListAnswer\":[{\"Value\":\"We find high youth unemployment a problem in the USA\",\"IsAnswer\":false},{\"Value\":\"High youth unemployment is found in the USA\",\"IsAnswer\":true},{\"Value\":\"The USA is a country of young people\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("4f830591-4a73-4976-9a63-dcebb53ca4c2") },
                    { new Guid("79c09f5a-9ee5-4a93-b268-05d178d43f23"), "{\"Question\":\"\\u0110\\u01B0\\u1EDDng l\\u1ED1i kh\\u00E1ng chi\\u1EBFn ch\\u1ED1ng Ph\\u00E1p c\\u1EE7a \\u0110\\u1EA3ng l\\u00E0\",\"ListAnswer\":[{\"Value\":\"to\\u00E0n d\\u00E2n, to\\u00E0n di\\u1EC7n, \\u0111\\u00E1nh nhanh th\\u1EAFng nhanh, t\\u1EF1 l\\u1EF1c c\\u00E1nh sinh\",\"IsAnswer\":false},{\"Value\":\"to\\u00E0n d\\u00E2n, to\\u00E0n di\\u1EC7n, tr\\u01B0\\u1EDDng k\\u00EC, ch\\u1EC9 d\\u1EF1a v\\u00E0o s\\u1EE9c l\\u1EF1c b\\u1EA3n th\\u00E2n\",\"IsAnswer\":false},{\"Value\":\"to\\u00E0n d\\u00E2n, to\\u00E0n di\\u1EC7n, tr\\u01B0\\u1EDDng k\\u00EC, t\\u1EF1 l\\u1EF1c c\\u00E1nh sinh v\\u00E0 tranh th\\u1EE7 s\\u1EF1 \\u1EE7ng h\\u1ED9 qu\\u1ED1c t\\u1EBF\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("596c886d-ae82-4b7e-9d88-7f185f57778e") },
                    { new Guid("7a03d7ad-eeef-48ae-b732-6833bcf3a044"), "{\"Question\":\"M\\u1ED9t trong nh\\u1EEFng \\u0111\\u1EB7c \\u0111i\\u1EC3m c\\u01A1 b\\u1EA3n c\\u1EE7a \\u0111i\\u1EC3m c\\u00F4ng nghi\\u1EC7p \\u1EDF n\\u01B0\\u1EDBc ta l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"Do Ch\\u00EDnh ph\\u1EE7 th\\u00E0nh l\\u1EADp\",\"IsAnswer\":false},{\"Value\":\"C\\u00F3 c\\u00E1c ng\\u00E0nh chuy\\u00EAn m\\u00F4n h\\u00F3a\",\"IsAnswer\":false},{\"Value\":\"Th\\u01B0\\u1EDDng h\\u00ECnh th\\u00E0nh \\u1EDF c\\u00E1c t\\u1EC9nh mi\\u1EC1n n\\u00FAi\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("adda106e-b8ba-4bfb-bdea-e2fcd916137c") },
                    { new Guid("7af0247b-a9fe-48e0-aa2f-eb7b31dcd698"), "{\"Question\":\"\\u1EDE c\\u00E1c lo\\u00E0i sinh v\\u1EADt l\\u01B0\\u1EE1ng b\\u1ED9i, s\\u1ED1 nh\\u00F3m gen li\\u00EAn k\\u1EBFt \\u1EDF m\\u1ED7i lo\\u00E0i b\\u1EB1ng s\\u1ED1\",\"ListAnswer\":[{\"Value\":\"t\\u00EDnh tr\\u1EA1ng c\\u1EE7a lo\\u00E0i\",\"IsAnswer\":false},{\"Value\":\"NST trong b\\u1ED9 l\\u01B0\\u1EE1ng b\\u1ED9i c\\u1EE7a lo\\u00E0i\",\"IsAnswer\":false},{\"Value\":\"NST trong b\\u1ED9 \\u0111\\u01A1n b\\u1ED9i c\\u1EE7a lo\\u00E0i\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("f0a45c6c-be92-4c73-829e-907591c7694a") },
                    { new Guid("7c142395-2435-4549-a4cf-d483179cd48a"), "{\"Question\":\"Gi\\u00E1 tr\\u1ECB l\\u1EDBn nh\\u1EA5t c\\u1EE7a h\\u00E0m s\\u1ED1 f(x) = -x^2 \\u002B 4 l\\u00E0\",\"ListAnswer\":[{\"Value\":\"0\",\"IsAnswer\":false},{\"Value\":\"2\",\"IsAnswer\":false},{\"Value\":\"4\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("468f1e58-d93b-46db-b4df-4a173513befb") },
                    { new Guid("7d2ef0c9-bbcc-4313-a9b5-45e7ea76bdd0"), "{\"Question\":\"Trong c\\u00E1c m\\u1EC7nh \\u0111\\u1EC1 sau m\\u1EC7nh \\u0111\\u1EC1 n\\u00E0o nh\\u1EADn gi\\u00E1 tr\\u1ECB \\u0111\\u00FAng?\",\"ListAnswer\":[{\"Value\":\"H\\u00E0m s\\u1ED1 y = 1/x c\\u00F3 nguy\\u00EAn h\\u00E0m tr\\u00EAn (-\\u221E; \\u002B\\u221E).\",\"IsAnswer\":true},{\"Value\":\"H\\u00E0m s\\u1ED1 y = |x| c\\u00F3 nguy\\u00EAn h\\u00E0m tr\\u00EAn (-\\u221E;\\u002B\\u221E).\",\"IsAnswer\":false},{\"Value\":\"1/x \\u002B C l\\u00E0 h\\u1ECD nguy\\u00EAn h\\u00E0m c\\u1EE7a ln\\u2061x tr\\u00EAn (0;\\u002B\\u221E).\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("56057547-6172-4967-a8c3-e8e9afc494ac") },
                    { new Guid("7ef701de-6f5d-4059-9bfe-596bddfbeaac"), "{\"Question\":\"N\\u1ED9i dung n\\u00E0o kh\\u00F4ng ph\\u1EA3i l\\u00E0 h\\u00ECnh th\\u1EE9c th\\u1EF1c hi\\u1EC7n ph\\u00E1p lu\\u1EADt?\",\"ListAnswer\":[{\"Value\":\"Thi h\\u00E0nh ph\\u00E1p lu\\u1EADt.\",\"IsAnswer\":false},{\"Value\":\"Ph\\u1ED5 bi\\u1EBFn ph\\u00E1p lu\\u1EADt.\",\"IsAnswer\":true},{\"Value\":\"S\\u1EED d\\u1EE5ng ph\\u00E1p lu\\u1EADt\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("6880b25a-40ec-410e-b332-e6616982e206") },
                    { new Guid("84680ba8-f5b2-4c12-839d-1177b98a0b4c"), "{\"Question\":\"\\u0110un n\\u00F3ng este HCOOCH3 v\\u1EDBi m\\u1ED9t l\\u01B0\\u1EE3ng v\\u1EEBa \\u0111\\u1EE7 dung d\\u1ECBch NaOH, s\\u1EA3n ph\\u1EA9m thu \\u0111\\u01B0\\u1EE3c l\\u00E0\",\"ListAnswer\":[{\"Value\":\"HCOONa v\\u00E0 CH3OH\",\"IsAnswer\":true},{\"Value\":\"CH3COONa v\\u00E0 C2H5OH\",\"IsAnswer\":false},{\"Value\":\"CH3COONa v\\u00E0 CH3OH\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("111d9344-66dd-4653-8cff-96bb9bc3863a") },
                    { new Guid("8d199b0b-e54f-41d1-b266-32da75652d57"), "{\"Question\":\"One advantage of living in a/an \\u2026\\u2026 is to strengthen relationships between young children and adults.\",\"ListAnswer\":[{\"Value\":\"nuclear family\",\"IsAnswer\":false},{\"Value\":\"nuclear house\",\"IsAnswer\":false},{\"Value\":\"extended family\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("2addcd1a-4f32-42dc-bf9f-637fd7769c3c") },
                    { new Guid("8e9f36cb-54eb-48d4-b5c9-d7cbaf1f744c"), "{\"Question\":\"Chi\\u1EBFn tranh c\\u1EE5c b\\u1ED9 kh\\u00E1c Chi\\u1EBFn tranh \\u0111\\u1EB7c bi\\u1EC7t \\u1EDF \\u0111i\\u1EC3m n\\u00E0o ?\",\"ListAnswer\":[{\"Value\":\"Chi\\u1EBFn tranh c\\u1EE5c b\\u1ED9 s\\u1EED d\\u1EE5ng v\\u0169 kh\\u00ED v\\u00E0 ph\\u01B0\\u01A1ng ti\\u1EC7n chi\\u1EBFn tranh do M\\u0129 cung c\\u1EA5p\",\"IsAnswer\":false},{\"Value\":\"Chi\\u1EBFn tranh c\\u1EE5c b\\u1ED9 l\\u00E0 h\\u00ECnh th\\u1EE9c chi\\u1EBFn tranh c\\u1EE7a ch\\u1EE7 ngh\\u0129a th\\u1EF1c d\\u00E2n m\\u1EDBi\",\"IsAnswer\":false},{\"Value\":\"Chi\\u1EBFn tranh c\\u1EE5c b\\u1ED9 ch\\u1EE7 y\\u1EBFu \\u0111\\u01B0\\u1EE3c ti\\u1EBFn h\\u00E0nh b\\u1EB1ng l\\u1EF1c l\\u01B0\\u1EE3ng qu\\u00E2n vi\\u1EC5n chinh M\\u0129\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("1649f0c1-8557-4c2a-99a8-b4ffde8e7bbe") },
                    { new Guid("921aecb2-3208-448b-bc96-0c833dd576cc"), "{\"Question\":\"Chu\\u1EA9n \\u0111\\u1ED9 20ml dung d\\u1ECBch HCl aM b\\u1EB1ng dung d\\u1ECBch NaOH 0,5M c\\u1EA7n d\\u00F9ng h\\u1EBFt 11ml. G\\u00EDa tr\\u1ECB c\\u1EE7a a l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"0,275\",\"IsAnswer\":true},{\"Value\":\"0,265\",\"IsAnswer\":false},{\"Value\":\"0,11\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("4bf74338-43a1-495c-ba6a-8d4b4aa431ab") },
                    { new Guid("92557132-9238-4d73-8f09-d95717bd90f3"), "{\"Question\":\"C\\u00F3 6 ch\\u1EA5t r\\u1EAFn ri\\u00EAng bi\\u1EC7t g\\u1ED3m CuO, FeO, Fe3O4, MnO2, Ag2O v\\u00E0 h\\u1ED7n h\\u1EE3p (Fe \\u002B FeO). C\\u00F3 th\\u1EC3 d\\u00F9ng dung d\\u1ECBch ch\\u1EE9a ch\\u1EA5t n\\u00E0o sau \\u0111\\u00E2y \\u0111\\u1EC3 ph\\u00E2n bi\\u1EC7t 6 ch\\u1EA5t r\\u1EAFn tr\\u00EAn ?\",\"ListAnswer\":[{\"Value\":\"H2SO4 \\u0111\\u1EB7c ngu\\u1ED9i\",\"IsAnswer\":false},{\"Value\":\"H2SO4 lo\\u00E3ng\",\"IsAnswer\":false},{\"Value\":\"HCl lo\\u00E3ng, \\u0111un n\\u00F3ng\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("4bf74338-43a1-495c-ba6a-8d4b4aa431ab") },
                    { new Guid("956ad23f-9c28-42d7-aeea-764dca133c20"), "{\"Question\":\"\\u2026\\u2026 a desert requires a lot of careful preparation and survival skills.\",\"ListAnswer\":[{\"Value\":\"Visiting\",\"IsAnswer\":false},{\"Value\":\"Explore\",\"IsAnswer\":false},{\"Value\":\"Exploring \",\"IsAnswer\":true}]}", null, false, null, null, new Guid("7294fa9f-78c5-49f3-a9fa-c99feb6d6a5c") },
                    { new Guid("99b02765-cceb-4bc3-a28e-705d20737154"), "{\"Question\":\"Quy\\u1EC1n b\\u1EA7u c\\u1EED v\\u00E0 quy\\u1EC1n \\u1EE9ng c\\u1EED l\\u00E0 c\\u00E1c quy\\u1EC1n d\\u00E2n ch\\u1EE7 c\\u01A1 b\\u1EA3n c\\u1EE7a c\\u00F4ng d\\u00E2n trong l\\u0129nh v\\u1EF1c\",\"ListAnswer\":[{\"Value\":\"V\\u0103n h\\u00F3a\",\"IsAnswer\":false},{\"Value\":\"Kinh t\\u1EBF\",\"IsAnswer\":false},{\"Value\":\"Ch\\u00EDnh tr\\u1ECB\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("0faf3a0d-3e02-41f1-890c-51610de8e8cb") },
                    { new Guid("9bf57282-2764-4111-a657-eb17760c070a"), "{\"Question\":\"H\\u00E0m s\\u1ED1 n\\u00E0o d\\u01B0\\u1EDBi \\u0111\\u00E2y kh\\u00F4ng ph\\u1EA3i l\\u00E0 m\\u1ED9t nguy\\u00EAn h\\u00E0m c\\u1EE7a f(x)=2x-sin\\u20612x ?\",\"ListAnswer\":[{\"Value\":\"x^2 \\u002B (1/2).cos\\u20612x\",\"IsAnswer\":false},{\"Value\":\"x^2 \\u002B cos^2 x\",\"IsAnswer\":false},{\"Value\":\"x^2 \\u002B cos\\u20612x\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("56057547-6172-4967-a8c3-e8e9afc494ac") },
                    { new Guid("9c51879f-c0d9-48ac-8b12-4815d5b44974"), "{\"Question\":\"N\\u1ED9i dung n\\u00E0o sau \\u0111\\u00E2y kh\\u00F4ng thu\\u1ED9c v\\u1EC1 quan h\\u1EC7 b\\u00ECnh \\u0111\\u1EB3ng trong h\\u00F4n nh\\u00E2n v\\u00E0 gia \\u0111\\u00ECnh?\",\"ListAnswer\":[{\"Value\":\"B\\u00ECnh \\u0111\\u1EB3ng gi\\u1EEFa ch\\u00FA b\\u00E1c v\\u00E0 ch\\u00E1u\",\"IsAnswer\":true},{\"Value\":\"B\\u00ECnh \\u0111\\u1EB3ng gi\\u1EEFa anh, ch\\u1ECB, em.\",\"IsAnswer\":false},{\"Value\":\"B\\u00ECnh \\u0111\\u1EB3ng gi\\u1EEFa cha m\\u1EB9 v\\u00E0 con\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("fa93b3f0-ed5f-4b84-af34-6cc4f5b3831c") },
                    { new Guid("9cd5e3c3-056e-48ea-948c-707e2fb4efb3"), "{\"Question\":\"H\\u00ECnh th\\u1EE9c m\\u1EB7t tr\\u1EADn \\u0111\\u01B0\\u1EE3c th\\u00E0nh l\\u1EADp trong phong tr\\u00E0o 1930 - 1931 l\\u00E0\",\"ListAnswer\":[{\"Value\":\"Ch\\u1EC9 c\\u00F3 li\\u00EAn minh c\\u00F4ng - n\\u00F4ng.\",\"IsAnswer\":true},{\"Value\":\"M\\u1EB7t tr\\u1EADn d\\u00E2n ch\\u1EE7 \\u0110\\u00F4ng D\\u01B0\\u01A1ng\",\"IsAnswer\":false},{\"Value\":\"M\\u1EB7t tr\\u1EADn nh\\u00E2n d\\u00E2n ph\\u1EA3n \\u0111\\u1EBF \\u0110\\u00F4ng D\\u01B0\\u01A1ng\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("670f0b14-435e-413f-ac27-7271ed1b87bb") },
                    { new Guid("9fd1ad12-cebb-4450-bfeb-c8618d924b75"), "{\"Question\":\"T\\u1EEB n\\u0103m 1990 \\u0111\\u1EBFn n\\u0103m 2005, trong ng\\u00E0nh tr\\u1ED3ng tr\\u1ECDt hai nh\\u00F3m c\\u00E2y tr\\u1ED3ng c\\u00F3 t\\u1ED1c \\u0111\\u1ED9 t\\u0103ng tr\\u01B0\\u1EDFng gi\\u00E1 tr\\u1ECB s\\u1EA3n xu\\u1EA5t cao nh\\u1EA5t l\\u00E0\",\"ListAnswer\":[{\"Value\":\"C\\u00E2y rau \\u0111\\u1EA1u, c\\u00E2y \\u0103n qu\\u1EA3\",\"IsAnswer\":false},{\"Value\":\"C\\u00E2y c\\u00F4ng nghi\\u1EC7p, c\\u00E2y rau \\u0111\\u1EADu\",\"IsAnswer\":true},{\"Value\":\"C\\u00E2y l\\u01B0\\u01A1ng th\\u1EF1c, c\\u00E2y \\u0103n qu\\u1EA3\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("0c83b2dc-372d-4687-8a51-c35b5e51c991") },
                    { new Guid("a28c8be3-ab1e-4fc5-a641-0360d3f9f6e0"), "{\"Question\":\"He is one of the most \\u2026\\u2026\\u2026 bosses I have ever worked with. He behaves rudely to not only me but also others in the staff.\",\"ListAnswer\":[{\"Value\":\"thoughtful\",\"IsAnswer\":false},{\"Value\":\"impolite\",\"IsAnswer\":true},{\"Value\":\"communicative\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("64722757-eb15-4891-abbc-bd870caae9f1") },
                    { new Guid("a294a985-9bdb-4eee-b593-837776db1553"), "{\"Question\":\"Th\\u1EF1c d\\u00E2n Ph\\u00E1p ti\\u1EBFn h\\u00E0nh cu\\u1ED9c khai th\\u00E1c thu\\u1ED9c \\u0111\\u1ECBa l\\u1EA7n th\\u1EE9 hai \\u1EDF \\u0110\\u00F4ng D\\u01B0\\u01A1ng (1919 - 1929) khi\",\"ListAnswer\":[{\"Value\":\"Th\\u1EBF gi\\u1EDBi t\\u01B0 b\\u1EA3n \\u0111ang l\\u00E2m v\\u00E0o kh\\u1EE7ng ho\\u1EA3ng th\\u1EEBa\",\"IsAnswer\":false},{\"Value\":\"Cu\\u1ED9c chi\\u1EBFn tranh th\\u1EBF gi\\u1EDBi th\\u1EE9 nh\\u1EA5t k\\u1EBFt th\\u00FAc.\",\"IsAnswer\":true},{\"Value\":\"Kinh t\\u1EBF c\\u00E1c n\\u01B0\\u1EDBc t\\u01B0 b\\u1EA3n \\u0111ang tr\\u00EAn \\u0111\\u00E0 ph\\u00E1t tri\\u1EC3n\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("9654577c-a684-4ec7-ac30-fd49386482a7") },
                    { new Guid("abf931e5-52fd-44f8-9941-08ac0ec1c876"), "{\"Question\":\"Ho\\u00E0 tan ho\\u00E0n to\\u00E0n m (g) FexOy b\\u1EB1ng dd H2SO4 \\u0111\\u1EB7c n\\u00F3ng thu \\u0111\\u01B0\\u1EE3c 2,24lit SO2 (\\u0111ktc). Ph\\u1EA7n dd ch\\u1EE9a 120(g) m\\u1ED9t lo\\u1EA1i mu\\u1ED1i s\\u1EAFt duy nh\\u1EA5t. C\\u00F4ng th\\u1EE9c oxit s\\u1EAFt v\\u00E0 kh\\u1ED1i l\\u01B0\\u1EE3ng m l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"Fe3O4; m = 23,2(g)\",\"IsAnswer\":false},{\"Value\":\"FeO; m = 7,2(g)\",\"IsAnswer\":false},{\"Value\":\"Fe3O4; m = 46,4(g)\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("20dd53da-8d28-4f31-b2d6-7e722fbf1aea") },
                    { new Guid("b0a4c2fe-9e68-438b-898f-e2161826d722"), "{\"Question\":\"H\\u1ED9i ngh\\u1ECB l\\u1EA7n th\\u1EE9 24 Ban Ch\\u1EA5p h\\u00E0nh Trung \\u01B0\\u01A1ng \\u0110\\u1EA3ng (9/1975) \\u0111\\u00E3\",\"ListAnswer\":[{\"Value\":\"\\u0111\\u1EC1 ra nhi\\u1EC7m v\\u1EE5 th\\u1ED1ng nh\\u1EA5t \\u0111\\u1EA5t n\\u01B0\\u1EDBc v\\u1EC1 m\\u1EB7t nh\\u00E0 n\\u01B0\\u1EDBc\",\"IsAnswer\":true},{\"Value\":\"\\u0111\\u1EC1 ra \\u0111\\u01B0\\u1EDDng l\\u1ED1i \\u0111\\u1ED5i m\\u1EDBi \\u0111\\u1EA5t n\\u01B0\\u1EDBc \\u0111i l\\u00EAn ch\\u1EE7 ngh\\u0129a x\\u00E3 h\\u1ED9i\",\"IsAnswer\":false},{\"Value\":\"\\u0111\\u1EC1 ra ch\\u1EE7 tr\\u01B0\\u01A1ng gi\\u1EA3i ph\\u00F3ng mi\\u1EC1n Nam, th\\u1ED1ng nh\\u1EA5t \\u0111\\u1EA5t n\\u01B0\\u1EDBc\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("179ea3f8-4ed8-4151-b360-7dbe9f033e0c") },
                    { new Guid("b4134c55-0411-45c9-9d97-89d8ab11bfc4"), "{\"Question\":\"\\u0110\\u00E1nh ng\\u01B0\\u1EDDi l\\u00E0 h\\u00E0nh vi x\\u00E2m ph\\u1EA1m \\u0111\\u1EBFn quy\\u1EC1n n\\u00E0o sau \\u0111\\u00E2y c\\u1EE7a c\\u00F4ng d\\u00E2n?\",\"ListAnswer\":[{\"Value\":\"Quy\\u1EC1n \\u0111\\u01B0\\u1EE3c ph\\u00E1p lu\\u1EADt b\\u1EA3o h\\u1ED9 v\\u1EC1 t\\u00EDnh m\\u1EA1ng, s\\u1EE9c kh\\u1ECFe\",\"IsAnswer\":true},{\"Value\":\"Quy\\u1EC1n b\\u1EA5t kh\\u1EA3 x\\u00E2m ph\\u1EA1m v\\u1EC1 th\\u00E2n th\\u1EC3\",\"IsAnswer\":false},{\"Value\":\"Quy\\u1EC1n \\u0111\\u01B0\\u1EE3c s\\u1ED1ng v\\u00E0 \\u0111\\u01B0\\u1EE3c t\\u00F4n tr\\u1ECDng c\\u1EE7a c\\u00F4ng d\\u00E2n\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("c2b93d0f-1032-45c9-94bf-a53e2c5aa3be") },
                    { new Guid("b57da0ee-c931-43bc-8709-1eaf851a6aec"), "{\"Question\":\"T\\u1EC9nh n\\u00E0o sau \\u0111\\u00E2y kh\\u00F4ng thu\\u1ED9c v\\u00F9ng T\\u00E2y Nguy\\u00EAn ?\",\"ListAnswer\":[{\"Value\":\"Kon Tum\",\"IsAnswer\":false},{\"Value\":\"\\u0110\\u1ED3ng Nai\",\"IsAnswer\":true},{\"Value\":\"Gia Lai\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("020841e0-c4da-4010-9556-e67ad0b7d816") },
                    { new Guid("b6477824-5d8c-4b82-a725-b765000c7830"), "{\"Question\":\"C\\u00E1c c\\u00E2y c\\u00F4ng nghi\\u1EC7p l\\u00E2u n\\u0103m c\\u00F3 gi\\u00E1 tr\\u1ECB kinh t\\u00EA cao c\\u1EE7a n\\u01B0\\u1EDBc ta l\\u00E0\",\"ListAnswer\":[{\"Value\":\"C\\u00E0 ph\\u00EA, cao su, m\\u00EDa\",\"IsAnswer\":false},{\"Value\":\"H\\u1ED3 ti\\u00EAu, b\\u00F4ng, ch\\u00E8\",\"IsAnswer\":false},{\"Value\":\"C\\u00E0 ph\\u00EA, \\u0111i\\u1EC1u, ch\\u00E8\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("a9902cb8-b044-4e0e-8e22-9ec0337dea6b") },
                    { new Guid("b7aa8c42-5ad5-4a5c-9b5d-b4f2d1d4e331"), "{\"Question\":\"S\\u1ED1 nh\\u00F3m amino v\\u00E0 s\\u1ED1 nh\\u00F3m cacboxyl c\\u00F3 trong m\\u1ED9t ph\\u00E2n t\\u1EED axit glutamic t\\u01B0\\u01A1ng \\u1EE9ng l\\u00E0\",\"ListAnswer\":[{\"Value\":\"2 v\\u00E0 2\",\"IsAnswer\":false},{\"Value\":\"1 v\\u00E0 2.\",\"IsAnswer\":true},{\"Value\":\"1 v\\u00E0 1\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("dd4d8c18-5a33-4a61-a34b-e2cd10226ec8") },
                    { new Guid("bc590d16-97bb-4ccf-8245-584675f0cd60"), "{\"Question\":\"C\\u01A1 s\\u1EDF ph\\u00E1p l\\u00ED \\u0111\\u1EC3 th\\u1EF1c hi\\u1EC7n c\\u00F3 hi\\u1EC7u qu\\u1EA3 qu\\u00E1 tr\\u00ECnh h\\u1EE3p t\\u00E1c l\\u00E0\",\"ListAnswer\":[{\"Value\":\"Hi\\u1EBFn ph\\u00E1p\",\"IsAnswer\":false},{\"Value\":\"Ph\\u00E1p lu\\u1EADt\",\"IsAnswer\":true},{\"Value\":\"Lu\\u1EADt\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("86f6ce80-f585-47d8-b3f0-c2f1d6cd084a") },
                    { new Guid("bd235389-9531-44ac-b2ae-707c820c939b"), "{\"Question\":\"My teacher always gives me advice \\u2026\\u2026 suitable career in the future.\",\"ListAnswer\":[{\"Value\":\"to choose\",\"IsAnswer\":true},{\"Value\":\"choosing\",\"IsAnswer\":false},{\"Value\":\"not to choose\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("451fa872-1960-4c03-a3df-374dbfc81c83") },
                    { new Guid("be7ac590-66b0-4c93-81e5-6b893c386844"), "{\"Question\":\"M\\u1ED9t trong nh\\u1EEFng di s\\u1EA3n thi\\u00EAn nhi\\u00EAn th\\u1EBF gi\\u1EDBi \\u1EDF n\\u01B0\\u1EDBc ta l\\u00E0\",\"ListAnswer\":[{\"Value\":\"V\\u1ECBnh H\\u1EA1 Long\",\"IsAnswer\":true},{\"Value\":\"Th\\u00E1nh \\u0111\\u1ECBa M\\u1EF9 S\\u01A1n\",\"IsAnswer\":false},{\"Value\":\"Ph\\u1ED1 c\\u1ED5 H\\u1ED9i An\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("e992f53a-b7b0-4a1e-9b81-36ed3328c6e1") },
                    { new Guid("c96a6886-0210-4059-85c0-43b32ce23730"), "{\"Question\":\"A good leader should not be conservative, but rather \\u2026\\u2026 to new ideas.\",\"ListAnswer\":[{\"Value\":\"receptive\",\"IsAnswer\":true},{\"Value\":\"permissive\",\"IsAnswer\":false},{\"Value\":\"applicable\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("55469d88-1e76-4678-ad62-e3d233602dfa") },
                    { new Guid("cbdea889-463d-4ecc-bf8f-f05467f1fc19"), "{\"Question\":\"K\\u1EBF ho\\u1EA1ch 5 n\\u0103m (1946-1950) c\\u1EE7a Li\\u00EAn X\\u00F4 \\u0111\\u01B0\\u1EE3c ti\\u1EBFn h\\u00E0nh trong th\\u1EDDi gian bao l\\u00E2u?\",\"ListAnswer\":[{\"Value\":\"1 n\\u0103m 3 th\\u00E1ng\",\"IsAnswer\":false},{\"Value\":\"4 n\\u0103m 3 th\\u00E1ng\",\"IsAnswer\":true},{\"Value\":\"9 th\\u00E1ng\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("bffb16de-cbfc-4a26-8e27-370225aa09aa") },
                    { new Guid("cc760427-bedc-4728-bf27-96bf043db449"), "{\"Question\":\"You are old enough to take \\u2026\\u2026 for what you have done.\",\"ListAnswer\":[{\"Value\":\"responsibility\",\"IsAnswer\":true},{\"Value\":\"responsible\",\"IsAnswer\":false},{\"Value\":\"responsibly \",\"IsAnswer\":false}]}", null, false, null, null, new Guid("33fcdca5-2b11-49cf-8824-f91d45c86dd2") },
                    { new Guid("cca4025d-9a6e-4f2a-8759-2dfac58c6a6a"), "{\"Question\":\"A water polo team \\u2026\\u2026 seven players, six swimmers and a goalie.\",\"ListAnswer\":[{\"Value\":\"composes\",\"IsAnswer\":false},{\"Value\":\"consists of\",\"IsAnswer\":true},{\"Value\":\"includes of \",\"IsAnswer\":false}]}", null, false, null, null, new Guid("9a4f72df-ee78-4455-8b67-76b3a26ce507") },
                    { new Guid("cf13aa13-1104-4b55-bc06-bef52a8dcdb3"), "{\"Question\":\"Di truy\\u1EC1n y h\\u1ECDc l\\u00E0 ng\\u00E0nh khoa h\\u1ECDc v\\u1EADn d\\u1EE5ng nh\\u1EEFng hi\\u1EC3u bi\\u1EBFt v\\u1EC1 Di truy\\u1EC1n h\\u1ECDc ng\\u01B0\\u1EDDi v\\u00E0o y h\\u1ECDc\",\"ListAnswer\":[{\"Value\":\"\\u0111\\u1EC3 \\u0111i\\u1EC1u tr\\u1ECB trong 1 s\\u1ED1 tr\\u01B0\\u1EDDng h\\u1EE3p b\\u1EC7nh l\\u00ED\",\"IsAnswer\":false},{\"Value\":\"gi\\u00FAp cho vi\\u1EC7c gi\\u1EA3i th\\u00EDch, ch\\u1EA9n \\u0111o\\u00E1n, ph\\u00F2ng ng\\u1EEBa, h\\u1EA1n ch\\u1EBF c\\u00E1c b\\u1EC7nh t\\u1EADt di truy\\u1EC1n v\\u00E0 \\u0111i\\u1EC1u tr\\u1ECB trong 1 s\\u1ED1 tr\\u01B0\\u1EDDng h\\u1EE3p b\\u1EC7nh l\\u00ED.\",\"IsAnswer\":true},{\"Value\":\"\\u0111\\u1EC3 gi\\u1EA3i th\\u00EDch, ch\\u1EA9n \\u0111o\\u00E1n c\\u00E1c t\\u1EADt, b\\u1EC7nh di truy\\u1EC1n\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("4881c89c-4995-4833-a00c-90bac688b8c4") },
                    { new Guid("d6fe0d35-1858-41dd-9ef6-747adb651bb2"), "{\"Question\":\"H\\u1ED7n h\\u1EE3p X ch\\u1EE9a Na2O, NH4Cl, NaHCO3 v\\u00E0 BaCl2 v\\u1EDBi s\\u1ED1 mol c\\u00E1c ch\\u1EA5t b\\u1EB1ng nhau. Cho h\\u1ED7n h\\u1EE3p X v\\u00E0o n\\u01B0\\u1EDBc d\\u01B0 v\\u00E0 \\u0111un n\\u00F3ng. C\\u00E1c ch\\u1EA5t tan trong dung d\\u1ECBch thu \\u0111\\u01B0\\u1EE3c l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"NaCl, NaOH, BaCl2\",\"IsAnswer\":false},{\"Value\":\"NaCl, NaOH\",\"IsAnswer\":false},{\"Value\":\"NaCl\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("111aa302-4022-42e7-bf44-5546d2212240") },
                    { new Guid("d9cf5916-5fe2-424b-bf05-83d07b07fce1"), "{\"Question\":\"\\u0110\\u1EC3 t\\u0103ng s\\u1EA3n l\\u01B0\\u1EE3ng l\\u01B0\\u01A1ng th\\u1EF1c \\u1EDF n\\u01B0\\u1EDBc ta, bi\\u1EC7n ph\\u00E1p quan tr\\u1ECDng nh\\u1EA5t l\\u00E0\",\"ListAnswer\":[{\"Value\":\"M\\u1EDF r\\u1ED9ng di\\u1EC7n t\\u00EDch \\u0111\\u1EA5t tr\\u1ED3ng c\\u00E2y l\\u01B0\\u01A1ng th\\u1EF1c\",\"IsAnswer\":false},{\"Value\":\"\\u0110\\u1EA9y m\\u1EA1nh th\\u00E2m canh, t\\u0103ng n\\u0103ng su\\u1EA5t\",\"IsAnswer\":true},{\"Value\":\"K\\u00EAu g\\u1ECDi \\u0111\\u1EA7u t\\u01B0 n\\u01B0\\u1EDBc ngo\\u00E0i v\\u00E0o s\\u1EA3n xu\\u1EA5t n\\u00F4ng nghi\\u1EC7p\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("0c83b2dc-372d-4687-8a51-c35b5e51c991") },
                    { new Guid("de226c30-025a-4f46-b071-fc76cbfc5ff5"), "{\"Question\":\"H\\u1EADu qu\\u1EA3 c\\u1EE7a Chi\\u1EBFn tranh th\\u1EBF gi\\u1EDBi th\\u1EE9 hai (1939-1945) \\u0111\\u1EC3 l\\u1EA1i \\u0111\\u00E3 l\\u00E0m cho n\\u1EC1n kinh t\\u1EBF T\\u00E2y \\u00C2u tr\\u1EDF n\\u00EAn\",\"ListAnswer\":[{\"Value\":\"Ph\\u00E1t tri\\u1EC3n m\\u1EA1nh m\\u1EBD\",\"IsAnswer\":false},{\"Value\":\"Ph\\u00E1t tri\\u1EC3n ch\\u1EADm\",\"IsAnswer\":false},{\"Value\":\"Ki\\u1EC7t qu\\u1EC7\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("5054a03a-17d9-4ba1-b33c-fef16aa2ffc0") },
                    { new Guid("e3ddebdc-b041-4f1a-9c32-1f287ee75c08"), "{\"Question\":\"\\u0110\\u01B0\\u1EDDng bi\\u00EAn gi\\u1EDBi d\\u00E0i nh\\u1EA5t tr\\u00EAn \\u0111\\u1EA5t li\\u1EC1n n\\u01B0\\u1EDBc ta l\\u00E0 v\\u1EDBi\",\"ListAnswer\":[{\"Value\":\"L\\u00E0o\",\"IsAnswer\":true},{\"Value\":\"Campuchia\",\"IsAnswer\":false},{\"Value\":\"Trung Qu\\u1ED1c\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("0bca65ca-2ce4-4923-a507-43e381130c9f") },
                    { new Guid("e6b2ed05-8c88-47ce-8cb7-ab7038ac93c5"), "{\"Question\":\"H\\u1EA1n ch\\u1EBF l\\u1EDBn nh\\u1EA5t c\\u1EE7a ngu\\u1ED3n lao \\u0111\\u1ED9ng n\\u01B0\\u1EDBc ta l\\u00E0\",\"ListAnswer\":[{\"Value\":\"Tr\\u00ECnh \\u0111\\u1ED9 chuy\\u00EAn m\\u00F4n, k\\u0129 thu\\u1EADt ch\\u01B0a cao\",\"IsAnswer\":true},{\"Value\":\"Th\\u1EC3 l\\u1EF1c ch\\u01B0a th\\u1EADt t\\u1ED1t\",\"IsAnswer\":false},{\"Value\":\"C\\u00F2n thi\\u1EBFu k\\u0129 n\\u0103ng l\\u00E0m vi\\u1EC7c\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("370bb392-410b-46b5-9971-2df9a53e7670") },
                    { new Guid("e7d454dc-e07b-4d56-bfc0-c33b4455192d"), "{\"Question\":\"D\\u1EA5u hi\\u1EC7u n\\u00E0o kh\\u00F4ng ph\\u1EA3i l\\u00E0 \\u0111\\u1EB7c tr\\u01B0ng c\\u1EE7a qu\\u1EA7n th\\u1EC3?\",\"ListAnswer\":[{\"Value\":\"\\u0111\\u1ED9 \\u0111a d\\u1EA1ng\",\"IsAnswer\":true},{\"Value\":\"t\\u1EC9 l\\u1EC7 \\u0111\\u1EF1c \\u2013 c\\u00E1i\",\"IsAnswer\":false},{\"Value\":\"m\\u1EADt \\u0111\\u1ED9\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("c444dd00-cde1-43b3-9761-ea0eca9553e9") },
                    { new Guid("ea6ca33f-7780-4ecb-9311-4d1c3d8e4337"), "{\"Question\":\"\\u0110\\u1EC3 \\u0111i\\u1EC1u ch\\u1EBF Al kim lo\\u1EA1i ta c\\u00F3 th\\u1EC3 d\\u00F9ng ph\\u01B0\\u01A1ng ph\\u00E1p n\\u00E0o trong c\\u00E1c ph\\u01B0\\u01A1ng ph\\u00E1p sau \\u0111\\u00E2y ?\",\"ListAnswer\":[{\"Value\":\"D\\u00F9ng CO kh\\u1EED Al2O3\",\"IsAnswer\":false},{\"Value\":\"\\u0110i\\u1EC7n ph\\u00E2n n\\u00F3ng ch\\u1EA3y Al2O3\",\"IsAnswer\":true},{\"Value\":\"D\\u00F9ng Zn \\u0111\\u1EA9y AlCl3 ra kh\\u1ECFi mu\\u1ED1i\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("db827133-7fbb-4b8e-bcdd-7f769e849505") },
                    { new Guid("efaaf3af-cbfc-4a92-a101-1533a05081fc"), "{\"Question\":\"\\u0110\\u1EC3 ch\\u1EE9ng minh trong ph\\u00E2n t\\u1EED c\\u1EE7a glucoz\\u01A1 c\\u00F3 nhi\\u1EC1u nh\\u00F3m hi\\u0111roxyl, ng\\u01B0\\u1EDDi ta cho dung d\\u1ECBch glucoz\\u01A1 ph\\u1EA3n \\u1EE9ng v\\u1EDBi\",\"ListAnswer\":[{\"Value\":\"Cu(OH)2 \\u1EDF nhi\\u1EC7t \\u0111\\u1ED9 th\\u01B0\\u1EDDng\",\"IsAnswer\":true},{\"Value\":\"Kim lo\\u1EA1i Na\",\"IsAnswer\":false},{\"Value\":\"Cu(OH)2 trong NaOH, \\u0111un n\\u00F3ng\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("9207680f-4c5e-4725-aec7-85d64102b0e9") },
                    { new Guid("f1854eb1-754b-4488-9d4a-088c008c5cf0"), "{\"Question\":\"Sau chi\\u1EBFn tranh th\\u1EBF gi\\u1EDBi th\\u1EE9 hai, quan h\\u1EC7 gi\\u1EEFa M\\u0129 v\\u00E0 Li\\u00EAn X\\u00F4 \\u0111\\u00E3 c\\u00F3 s\\u1EF1 chuy\\u1EC3n bi\\u1EBFn nh\\u01B0 th\\u1EBF n\\u00E0o?\",\"ListAnswer\":[{\"Value\":\"H\\u1EE3p t\\u00E1c v\\u1EDBi nhau trong vi\\u1EC7c gi\\u1EA3i quy\\u1EBFt nhi\\u1EC1u v\\u1EA5n \\u0111\\u1EC1 qu\\u1ED1c t\\u1EBF l\\u1EDBn\",\"IsAnswer\":false},{\"Value\":\"T\\u1EEB \\u0111\\u1ED3ng minh trong chi\\u1EBFn tranh chuy\\u1EC3n sang \\u0111\\u1ED1i \\u0111\\u1EA7u v\\u00E0 \\u0111i \\u0111\\u1EBFn t\\u00ECnh tr\\u1EA1ng chi\\u1EBFn tranh l\\u1EA1nh.\",\"IsAnswer\":true},{\"Value\":\"Chuy\\u1EC3n t\\u1EEB \\u0111\\u1ED1i \\u0111\\u1EA7u sang \\u0111\\u1ED1i tho\\u1EA1i, th\\u1EF1c hi\\u1EC7n h\\u1EE3p t\\u00E1c tr\\u00EAn nhi\\u1EC1u l\\u0129nh v\\u1EF1c\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("b4f8ba38-e4f6-4fa9-a49a-18e74322e133") }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedBy", "Description", "Index", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SubjectId" },
                values: new object[] { new Guid("7c506348-0444-4c91-ad50-15b952135294"), null, "Môn ngữ văn", 1, false, null, null, "Môn ngữ văn", new Guid("c0456f7f-1963-4598-8b7c-8f44bd7e2dbe") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 182, 129, 73, 1, 216, 96, 3, 5, 1, 217, 82, 56, 229, 114, 116, 57, 250, 218, 103, 233, 132, 24, 86, 71, 132, 68, 243, 23, 227, 31, 142, 209, 79, 12, 173, 89, 233, 67, 5, 217, 62, 176, 101, 189, 222, 68, 110, 172, 224, 201, 11, 21, 208, 169, 204, 194, 82, 161, 153, 238, 62, 225, 193 }, new byte[] { 71, 247, 46, 185, 39, 59, 8, 208, 247, 186, 234, 79, 93, 50, 21, 90, 186, 247, 61, 22, 207, 105, 34, 214, 35, 177, 106, 62, 90, 94, 79, 253, 127, 6, 213, 129, 34, 245, 208, 53, 163, 166, 137, 77, 87, 209, 201, 56, 151, 108, 85, 212, 162, 31, 248, 229, 106, 71, 159, 36, 212, 10, 104, 245, 255, 17, 84, 129, 96, 157, 228, 29, 192, 21, 171, 149, 204, 246, 107, 156, 254, 165, 161, 184, 85, 193, 131, 109, 239, 163, 211, 113, 57, 25, 144, 188, 140, 38, 20, 66, 21, 235, 67, 61, 111, 182, 68, 1, 202, 144, 103, 185, 73, 5, 149, 254, 136, 153, 134, 41, 137, 106, 12, 34, 16, 152, 166, 16 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 220, 22, 198, 227, 128, 43, 19, 120, 184, 169, 115, 179, 10, 77, 214, 32, 231, 220, 63, 58, 160, 54, 121, 101, 15, 121, 170, 129, 105, 219, 115, 11, 172, 95, 231, 54, 90, 153, 252, 218, 36, 101, 230, 76, 245, 131, 220, 162, 246, 102, 141, 254, 218, 147, 134, 152, 12, 121, 248, 20, 170, 164, 232, 248 }, new byte[] { 216, 74, 75, 172, 19, 55, 179, 123, 114, 148, 231, 3, 31, 255, 193, 64, 117, 253, 224, 122, 121, 182, 8, 179, 78, 124, 197, 195, 236, 232, 225, 119, 81, 76, 206, 73, 118, 160, 24, 203, 192, 77, 77, 173, 216, 235, 138, 132, 167, 24, 183, 237, 199, 31, 81, 121, 217, 125, 65, 176, 148, 6, 164, 86, 100, 10, 60, 48, 238, 233, 38, 6, 182, 220, 123, 49, 84, 164, 117, 221, 45, 197, 182, 56, 88, 140, 35, 160, 25, 61, 18, 253, 108, 182, 19, 126, 237, 37, 53, 176, 134, 77, 33, 85, 139, 195, 14, 205, 8, 129, 156, 121, 19, 137, 206, 187, 74, 161, 163, 210, 165, 137, 147, 164, 95, 133, 209, 105 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 130, 170, 88, 69, 93, 253, 192, 41, 235, 86, 180, 12, 227, 96, 60, 20, 207, 196, 209, 110, 23, 83, 40, 109, 75, 77, 79, 226, 145, 244, 103, 1, 164, 95, 67, 146, 195, 250, 82, 168, 145, 206, 40, 100, 105, 42, 170, 68, 254, 165, 97, 178, 139, 71, 129, 228, 81, 52, 157, 147, 145, 10, 187 }, new byte[] { 118, 238, 27, 138, 243, 117, 207, 90, 155, 156, 124, 126, 80, 100, 65, 123, 82, 221, 51, 80, 180, 28, 177, 57, 30, 229, 30, 101, 153, 83, 31, 67, 209, 107, 156, 86, 2, 246, 43, 239, 193, 95, 214, 30, 154, 85, 224, 186, 222, 45, 39, 248, 38, 35, 38, 130, 70, 221, 192, 62, 191, 92, 198, 143, 97, 208, 200, 40, 141, 49, 129, 138, 233, 61, 90, 63, 25, 156, 247, 215, 234, 142, 249, 153, 67, 131, 215, 132, 187, 112, 112, 179, 74, 17, 248, 230, 246, 41, 120, 222, 180, 104, 151, 228, 180, 187, 241, 157, 245, 52, 5, 169, 142, 27, 65, 126, 163, 29, 243, 39, 214, 238, 15, 25, 254, 143, 0, 8 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 61, 0, 112, 4, 60, 28, 48, 107, 67, 182, 27, 72, 36, 190, 84, 226, 128, 207, 235, 12, 74, 55, 160, 166, 215, 36, 18, 251, 187, 7, 30, 69, 30, 201, 58, 157, 32, 254, 71, 220, 206, 192, 78, 152, 101, 97, 66, 235, 140, 228, 9, 191, 96, 207, 231, 17, 159, 147, 62, 189, 117, 254, 124, 118 }, new byte[] { 159, 168, 160, 30, 207, 210, 22, 178, 142, 171, 196, 197, 222, 222, 165, 67, 23, 34, 149, 27, 23, 236, 134, 42, 90, 163, 224, 139, 135, 178, 76, 3, 132, 9, 153, 66, 59, 111, 203, 32, 37, 103, 240, 193, 66, 77, 192, 36, 243, 16, 55, 98, 129, 31, 67, 253, 115, 127, 150, 57, 202, 162, 11, 61, 241, 207, 206, 238, 228, 95, 252, 33, 105, 5, 227, 134, 172, 140, 26, 221, 43, 203, 1, 31, 41, 202, 191, 202, 114, 139, 109, 181, 124, 5, 6, 31, 107, 133, 206, 179, 102, 24, 25, 153, 4, 31, 195, 23, 56, 3, 200, 9, 245, 89, 157, 64, 230, 131, 189, 186, 20, 168, 190, 61, 192, 133, 241, 30 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 112, 235, 70, 249, 111, 176, 161, 62, 31, 138, 189, 24, 137, 81, 129, 109, 63, 118, 160, 65, 205, 122, 180, 241, 96, 217, 190, 228, 5, 132, 239, 94, 8, 151, 188, 219, 165, 170, 52, 133, 139, 166, 147, 130, 31, 139, 101, 121, 34, 145, 145, 44, 224, 114, 230, 216, 61, 53, 109, 92, 103, 169, 213 }, new byte[] { 101, 196, 67, 108, 194, 178, 252, 153, 178, 75, 225, 0, 64, 63, 197, 242, 8, 239, 102, 237, 134, 196, 155, 68, 109, 165, 172, 143, 193, 4, 59, 146, 67, 183, 130, 125, 146, 46, 201, 18, 94, 50, 105, 189, 98, 20, 113, 219, 179, 49, 47, 128, 19, 36, 213, 167, 233, 13, 227, 178, 183, 254, 5, 80, 237, 252, 136, 72, 68, 207, 169, 126, 57, 94, 99, 208, 160, 17, 220, 208, 155, 255, 189, 206, 9, 87, 224, 168, 51, 126, 203, 145, 127, 238, 239, 44, 107, 2, 8, 107, 196, 113, 74, 31, 130, 198, 138, 139, 18, 244, 176, 237, 65, 154, 177, 12, 135, 116, 4, 140, 41, 108, 71, 209, 194, 91, 112, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 6, 133, 118, 228, 29, 132, 106, 180, 151, 214, 93, 151, 79, 34, 150, 96, 165, 198, 37, 165, 205, 222, 227, 42, 46, 6, 97, 142, 57, 32, 86, 233, 99, 21, 223, 135, 84, 51, 38, 202, 91, 47, 154, 11, 99, 89, 249, 198, 158, 184, 194, 4, 189, 1, 164, 107, 236, 142, 214, 204, 31, 2, 98, 5 }, new byte[] { 128, 151, 134, 172, 204, 141, 45, 141, 158, 144, 52, 37, 2, 147, 58, 61, 203, 231, 131, 0, 132, 124, 246, 111, 222, 248, 62, 66, 71, 136, 248, 84, 90, 249, 196, 37, 72, 146, 142, 218, 98, 94, 136, 20, 25, 50, 187, 211, 175, 230, 23, 10, 54, 195, 255, 206, 154, 255, 253, 106, 252, 47, 157, 98, 0, 252, 79, 232, 200, 162, 215, 62, 221, 10, 82, 88, 49, 253, 110, 245, 149, 134, 223, 79, 1, 171, 90, 163, 118, 196, 35, 6, 108, 203, 64, 83, 176, 150, 31, 203, 111, 192, 152, 115, 202, 225, 79, 14, 74, 167, 163, 41, 153, 110, 253, 188, 227, 81, 145, 126, 158, 156, 60, 130, 129, 192, 235, 146 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 180, 35, 22, 34, 78, 215, 241, 151, 162, 88, 255, 57, 175, 150, 90, 150, 19, 42, 13, 122, 147, 81, 187, 182, 128, 247, 13, 70, 110, 87, 118, 34, 40, 254, 200, 88, 198, 169, 66, 165, 253, 241, 99, 147, 37, 190, 234, 213, 55, 253, 143, 195, 251, 32, 57, 242, 244, 81, 10, 4, 149, 152, 162, 19 }, new byte[] { 182, 26, 252, 235, 205, 32, 116, 101, 28, 20, 189, 150, 55, 251, 191, 172, 90, 191, 76, 73, 184, 255, 1, 60, 127, 1, 202, 17, 73, 128, 128, 181, 175, 38, 173, 147, 241, 127, 127, 96, 252, 145, 117, 138, 152, 240, 49, 148, 41, 84, 240, 186, 123, 187, 75, 208, 213, 247, 15, 219, 151, 144, 253, 188, 105, 202, 8, 68, 81, 225, 137, 96, 140, 42, 149, 171, 102, 195, 143, 226, 161, 228, 101, 118, 159, 117, 3, 112, 186, 20, 105, 229, 170, 240, 133, 121, 81, 203, 144, 2, 32, 27, 79, 153, 128, 246, 82, 245, 77, 90, 184, 127, 191, 72, 143, 15, 29, 61, 74, 176, 221, 80, 159, 20, 101, 251, 28, 58 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 118, 84, 1, 113, 56, 29, 37, 65, 145, 252, 219, 140, 254, 138, 217, 212, 111, 91, 39, 153, 108, 49, 102, 94, 56, 184, 12, 77, 65, 181, 31, 53, 126, 44, 99, 190, 229, 0, 174, 207, 130, 205, 93, 184, 48, 140, 90, 150, 218, 63, 76, 155, 222, 7, 228, 164, 208, 81, 128, 132, 64, 116, 186, 20 }, new byte[] { 171, 242, 31, 147, 10, 9, 194, 117, 31, 91, 132, 72, 239, 138, 202, 34, 47, 209, 72, 69, 176, 155, 83, 50, 168, 212, 209, 5, 240, 185, 135, 103, 64, 53, 165, 223, 30, 189, 7, 172, 200, 195, 153, 42, 251, 133, 129, 227, 188, 82, 154, 96, 217, 75, 36, 245, 81, 226, 14, 198, 74, 32, 36, 130, 151, 113, 186, 0, 139, 41, 120, 83, 69, 80, 195, 9, 121, 192, 164, 78, 75, 171, 10, 212, 122, 104, 33, 14, 26, 165, 166, 9, 137, 100, 37, 56, 26, 52, 39, 219, 15, 62, 243, 186, 215, 9, 46, 240, 74, 242, 101, 133, 194, 15, 25, 17, 155, 138, 234, 74, 166, 162, 240, 185, 69, 32, 130, 8 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 4, 35, 11, 53, 57, 184, 31, 11, 9, 24, 179, 172, 114, 161, 237, 199, 42, 176, 77, 78, 214, 61, 87, 130, 182, 224, 58, 242, 147, 15, 114, 83, 173, 58, 203, 192, 184, 107, 196, 166, 197, 152, 177, 17, 136, 223, 109, 32, 195, 128, 21, 254, 36, 158, 0, 57, 236, 2, 43, 92, 88, 69, 66 }, new byte[] { 81, 123, 57, 73, 28, 130, 232, 208, 95, 52, 169, 234, 2, 108, 35, 188, 68, 87, 14, 82, 92, 205, 10, 201, 72, 129, 126, 213, 103, 42, 161, 194, 226, 100, 247, 34, 193, 119, 209, 155, 8, 33, 231, 1, 196, 112, 123, 84, 228, 206, 45, 122, 84, 43, 198, 164, 222, 163, 103, 106, 5, 78, 169, 187, 167, 2, 255, 72, 50, 58, 41, 238, 95, 97, 122, 123, 116, 175, 23, 155, 179, 157, 118, 166, 254, 210, 237, 92, 198, 46, 121, 0, 74, 229, 197, 245, 189, 42, 6, 3, 146, 252, 158, 180, 82, 232, 217, 221, 89, 146, 230, 50, 55, 93, 18, 79, 196, 134, 228, 38, 239, 26, 4, 191, 216, 224, 200, 228 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 242, 229, 255, 133, 101, 222, 171, 165, 161, 247, 39, 220, 246, 190, 192, 198, 40, 22, 253, 212, 162, 62, 131, 53, 247, 52, 67, 184, 121, 217, 152, 173, 1, 99, 24, 203, 224, 68, 150, 181, 158, 238, 121, 69, 248, 240, 63, 231, 22, 69, 14, 193, 35, 16, 194, 25, 10, 187, 135, 43, 250, 24, 123, 72 }, new byte[] { 157, 1, 163, 48, 52, 138, 236, 194, 4, 174, 63, 14, 124, 15, 228, 236, 227, 180, 49, 8, 95, 95, 244, 229, 190, 241, 157, 229, 68, 37, 182, 136, 153, 237, 122, 90, 9, 144, 135, 146, 17, 196, 160, 121, 234, 29, 13, 117, 222, 20, 249, 126, 93, 236, 236, 130, 177, 211, 226, 216, 125, 146, 130, 19, 152, 144, 145, 116, 96, 160, 125, 182, 60, 51, 15, 222, 179, 22, 95, 238, 203, 4, 121, 69, 123, 92, 0, 101, 146, 44, 188, 127, 198, 37, 197, 96, 38, 127, 125, 186, 183, 123, 184, 235, 241, 185, 29, 212, 56, 135, 82, 9, 35, 41, 241, 38, 229, 41, 83, 17, 229, 91, 237, 5, 154, 65, 67, 183 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 49, 105, 14, 84, 3, 80, 239, 63, 65, 205, 191, 8, 54, 247, 243, 182, 165, 108, 175, 89, 48, 142, 106, 27, 154, 118, 143, 211, 99, 195, 224, 17, 214, 183, 100, 65, 210, 91, 179, 70, 219, 212, 57, 146, 248, 47, 7, 188, 189, 228, 241, 165, 22, 24, 86, 60, 7, 104, 29, 42, 59, 62, 165 }, new byte[] { 68, 40, 229, 60, 219, 243, 175, 80, 228, 10, 48, 13, 172, 86, 107, 42, 47, 120, 97, 127, 229, 152, 57, 43, 92, 23, 7, 12, 227, 83, 195, 199, 209, 97, 115, 217, 212, 98, 40, 124, 71, 133, 23, 68, 76, 140, 246, 21, 79, 9, 150, 148, 152, 12, 112, 125, 164, 6, 87, 84, 26, 231, 92, 240, 190, 62, 187, 61, 165, 15, 48, 154, 12, 111, 135, 30, 223, 166, 211, 140, 24, 23, 104, 87, 214, 146, 224, 158, 241, 170, 33, 214, 77, 158, 205, 81, 37, 201, 147, 34, 16, 12, 93, 49, 4, 222, 6, 161, 8, 59, 47, 93, 248, 19, 219, 74, 189, 144, 143, 144, 186, 211, 130, 73, 238, 49, 109, 1 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 135, 111, 13, 32, 156, 224, 137, 85, 187, 84, 25, 202, 4, 169, 85, 26, 168, 35, 108, 202, 166, 75, 232, 163, 64, 4, 240, 79, 168, 81, 40, 62, 167, 154, 11, 103, 0, 9, 83, 72, 205, 66, 65, 111, 41, 192, 158, 188, 145, 2, 204, 34, 214, 48, 40, 230, 66, 57, 14, 242, 250, 127, 73, 245 }, new byte[] { 133, 245, 56, 23, 141, 114, 251, 190, 168, 123, 116, 174, 44, 154, 131, 214, 209, 228, 103, 221, 164, 108, 37, 27, 245, 13, 63, 46, 109, 183, 241, 200, 32, 205, 30, 10, 154, 157, 17, 241, 71, 61, 193, 106, 222, 17, 58, 191, 70, 77, 39, 179, 112, 240, 186, 199, 79, 28, 208, 204, 35, 225, 214, 166, 206, 45, 7, 249, 19, 18, 234, 249, 0, 175, 151, 30, 201, 94, 38, 49, 152, 140, 38, 226, 75, 253, 90, 42, 221, 184, 30, 225, 148, 120, 125, 67, 59, 18, 0, 208, 9, 84, 106, 89, 143, 120, 128, 200, 106, 27, 125, 177, 199, 96, 120, 188, 82, 163, 145, 127, 142, 229, 164, 114, 50, 78, 233, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 5, 114, 125, 239, 15, 202, 187, 236, 151, 123, 74, 149, 252, 231, 215, 103, 106, 101, 134, 160, 76, 90, 36, 148, 197, 52, 123, 68, 143, 176, 84, 40, 155, 249, 171, 217, 232, 207, 21, 59, 196, 70, 250, 187, 234, 59, 129, 58, 153, 51, 89, 199, 25, 95, 199, 206, 57, 225, 188, 122, 30, 191, 121 }, new byte[] { 18, 86, 245, 51, 104, 152, 124, 147, 169, 25, 44, 3, 55, 158, 48, 181, 170, 17, 182, 17, 49, 87, 173, 104, 3, 134, 143, 186, 30, 160, 91, 80, 143, 97, 235, 234, 191, 237, 153, 4, 229, 69, 188, 76, 66, 112, 214, 193, 175, 211, 18, 155, 234, 174, 121, 234, 122, 141, 60, 51, 49, 161, 117, 21, 40, 217, 99, 96, 212, 44, 230, 4, 236, 35, 169, 149, 182, 197, 133, 67, 233, 75, 19, 102, 175, 106, 160, 118, 125, 40, 77, 16, 229, 246, 71, 132, 210, 119, 117, 97, 86, 73, 220, 93, 243, 132, 211, 128, 155, 225, 196, 33, 16, 205, 229, 142, 210, 227, 197, 253, 252, 95, 52, 239, 16, 82, 122, 6 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 243, 154, 236, 67, 25, 220, 189, 132, 19, 1, 46, 92, 163, 164, 245, 253, 207, 58, 93, 22, 194, 132, 224, 65, 71, 157, 128, 36, 231, 136, 115, 162, 15, 190, 38, 178, 55, 95, 47, 214, 100, 205, 193, 198, 18, 56, 6, 216, 36, 184, 41, 95, 55, 70, 120, 177, 162, 157, 60, 110, 253, 159, 150, 112 }, new byte[] { 60, 144, 43, 52, 138, 129, 3, 140, 50, 77, 196, 200, 50, 145, 34, 180, 118, 224, 69, 59, 222, 36, 209, 203, 209, 18, 17, 182, 138, 40, 180, 155, 135, 71, 171, 67, 242, 161, 229, 81, 187, 135, 249, 122, 57, 55, 60, 218, 210, 153, 34, 71, 179, 152, 115, 131, 224, 240, 14, 54, 104, 38, 253, 24, 110, 69, 204, 173, 64, 166, 63, 166, 110, 73, 39, 88, 200, 99, 239, 95, 184, 31, 72, 181, 253, 187, 33, 212, 85, 90, 57, 242, 228, 240, 173, 52, 216, 26, 184, 126, 221, 162, 102, 222, 13, 162, 18, 95, 92, 66, 240, 76, 123, 121, 30, 147, 159, 245, 43, 212, 234, 116, 134, 255, 195, 252, 1, 206 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 108, 57, 134, 249, 46, 180, 104, 206, 242, 93, 244, 107, 83, 204, 159, 162, 192, 18, 46, 78, 69, 242, 195, 244, 125, 206, 191, 65, 34, 157, 202, 189, 108, 184, 233, 91, 194, 124, 116, 110, 177, 50, 141, 107, 134, 251, 170, 72, 181, 80, 156, 81, 6, 115, 245, 162, 67, 173, 65, 27, 183, 1, 163, 100 }, new byte[] { 193, 120, 95, 108, 8, 206, 53, 182, 15, 213, 122, 71, 38, 27, 126, 6, 145, 222, 174, 251, 78, 84, 94, 0, 162, 101, 110, 187, 90, 204, 249, 103, 173, 178, 156, 254, 194, 227, 249, 202, 122, 130, 206, 115, 50, 56, 8, 194, 83, 240, 228, 148, 149, 111, 125, 179, 11, 214, 203, 64, 80, 156, 188, 21, 41, 84, 36, 194, 79, 116, 162, 198, 248, 157, 203, 100, 74, 205, 98, 103, 198, 68, 36, 32, 13, 25, 24, 66, 118, 133, 234, 124, 78, 177, 44, 241, 243, 114, 241, 214, 39, 92, 6, 69, 204, 195, 20, 30, 250, 53, 102, 134, 208, 239, 7, 4, 240, 240, 136, 41, 82, 136, 96, 86, 172, 166, 225, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 27, 84, 243, 129, 187, 212, 17, 150, 104, 93, 20, 63, 89, 160, 3, 150, 19, 152, 17, 48, 57, 116, 10, 73, 138, 193, 48, 80, 12, 216, 194, 78, 22, 153, 111, 56, 112, 233, 32, 139, 203, 195, 251, 105, 24, 94, 182, 61, 78, 213, 251, 168, 17, 182, 151, 78, 125, 39, 219, 149, 118, 67, 13, 89 }, new byte[] { 130, 76, 233, 213, 216, 42, 186, 146, 73, 110, 176, 29, 39, 77, 84, 172, 96, 0, 198, 135, 38, 105, 112, 253, 104, 75, 168, 49, 75, 115, 252, 28, 135, 205, 38, 185, 99, 162, 67, 238, 216, 150, 249, 146, 138, 216, 79, 23, 204, 110, 252, 1, 243, 203, 6, 220, 36, 101, 7, 31, 18, 83, 100, 91, 24, 104, 10, 215, 66, 103, 206, 19, 120, 205, 241, 143, 149, 80, 197, 36, 216, 204, 227, 157, 252, 194, 4, 168, 214, 229, 195, 96, 144, 218, 91, 222, 158, 214, 33, 131, 75, 171, 2, 206, 23, 149, 44, 36, 141, 2, 115, 109, 95, 129, 29, 207, 137, 226, 124, 210, 24, 111, 38, 8, 203, 15, 41, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 118, 10, 122, 105, 6, 211, 76, 186, 226, 16, 181, 108, 192, 178, 41, 133, 219, 150, 85, 77, 210, 215, 139, 213, 90, 67, 16, 113, 115, 209, 22, 207, 29, 16, 201, 142, 55, 19, 68, 203, 188, 25, 77, 131, 2, 95, 36, 146, 200, 207, 61, 92, 182, 249, 156, 11, 100, 33, 156, 0, 94, 62, 130, 186 }, new byte[] { 221, 249, 95, 27, 133, 80, 122, 53, 148, 79, 192, 204, 50, 210, 74, 220, 170, 73, 72, 179, 208, 254, 192, 219, 21, 237, 231, 142, 194, 216, 9, 9, 36, 44, 164, 149, 251, 79, 118, 95, 44, 23, 142, 15, 28, 236, 139, 184, 200, 202, 109, 222, 207, 109, 176, 102, 146, 237, 206, 235, 230, 177, 15, 123, 146, 93, 121, 39, 131, 18, 49, 188, 191, 118, 209, 237, 169, 171, 101, 231, 225, 221, 135, 6, 95, 214, 128, 180, 223, 227, 168, 131, 98, 145, 121, 116, 84, 11, 56, 122, 238, 21, 63, 7, 44, 213, 140, 227, 164, 94, 197, 54, 221, 208, 171, 127, 213, 131, 118, 131, 238, 59, 196, 117, 161, 117, 45, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 243, 30, 100, 139, 184, 231, 170, 46, 133, 190, 111, 49, 76, 84, 51, 96, 75, 249, 238, 235, 217, 150, 192, 190, 85, 119, 46, 16, 119, 226, 3, 72, 250, 243, 224, 114, 42, 119, 140, 100, 132, 157, 88, 99, 117, 5, 205, 25, 104, 9, 232, 180, 153, 64, 71, 209, 228, 101, 142, 240, 207, 251, 158 }, new byte[] { 208, 241, 143, 49, 197, 73, 30, 102, 192, 48, 249, 182, 8, 108, 71, 120, 111, 235, 36, 217, 203, 202, 157, 40, 132, 80, 103, 236, 212, 64, 177, 185, 5, 179, 24, 150, 238, 29, 63, 17, 177, 137, 236, 213, 95, 125, 79, 129, 228, 70, 147, 153, 10, 220, 148, 51, 50, 202, 5, 119, 168, 19, 89, 14, 52, 241, 224, 115, 77, 10, 237, 35, 31, 144, 151, 145, 55, 187, 230, 103, 243, 164, 165, 7, 21, 51, 224, 18, 210, 42, 202, 70, 213, 165, 96, 180, 195, 138, 202, 155, 201, 42, 125, 233, 105, 111, 250, 229, 252, 35, 21, 49, 76, 135, 159, 95, 241, 37, 49, 103, 54, 170, 43, 168, 90, 65, 146, 212 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 254, 159, 121, 234, 87, 16, 144, 38, 119, 231, 253, 177, 254, 72, 109, 228, 26, 94, 62, 98, 74, 201, 245, 150, 37, 204, 195, 16, 129, 136, 241, 147, 129, 113, 122, 136, 135, 124, 31, 174, 205, 59, 24, 40, 54, 120, 4, 85, 118, 85, 189, 16, 134, 63, 84, 174, 35, 62, 202, 249, 42, 251, 195 }, new byte[] { 129, 158, 24, 154, 199, 194, 172, 165, 159, 153, 56, 31, 253, 51, 85, 167, 235, 133, 98, 244, 98, 87, 254, 32, 118, 70, 79, 190, 12, 217, 112, 255, 123, 170, 65, 255, 102, 228, 98, 173, 11, 254, 254, 39, 219, 182, 201, 41, 89, 66, 223, 177, 130, 107, 97, 210, 2, 75, 94, 153, 148, 60, 82, 182, 5, 208, 142, 230, 80, 178, 214, 225, 95, 6, 45, 204, 135, 126, 182, 122, 173, 188, 187, 155, 84, 177, 17, 248, 240, 128, 254, 121, 145, 194, 237, 46, 23, 133, 107, 156, 202, 102, 141, 178, 254, 46, 226, 1, 165, 189, 213, 148, 109, 140, 118, 35, 211, 120, 232, 62, 214, 30, 101, 214, 76, 3, 15, 35 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 251, 245, 51, 180, 130, 74, 129, 157, 124, 148, 4, 11, 159, 83, 60, 176, 199, 128, 252, 39, 231, 109, 67, 56, 198, 145, 41, 10, 193, 102, 51, 93, 11, 223, 12, 247, 53, 185, 155, 239, 49, 127, 110, 123, 87, 185, 99, 91, 231, 9, 182, 168, 28, 162, 119, 162, 248, 134, 46, 40, 164, 25, 240 }, new byte[] { 89, 45, 147, 26, 159, 55, 210, 69, 100, 64, 114, 153, 93, 39, 118, 211, 26, 137, 169, 248, 38, 63, 85, 185, 250, 237, 117, 24, 111, 139, 132, 107, 197, 134, 2, 40, 9, 194, 33, 229, 223, 251, 139, 39, 27, 163, 246, 2, 192, 187, 80, 48, 199, 162, 17, 47, 80, 6, 53, 25, 126, 153, 91, 195, 173, 244, 52, 222, 135, 146, 71, 29, 122, 40, 68, 14, 167, 205, 225, 34, 220, 188, 251, 234, 13, 155, 68, 162, 130, 255, 247, 171, 84, 166, 54, 119, 226, 172, 224, 0, 50, 15, 54, 175, 202, 217, 47, 43, 163, 255, 28, 246, 123, 124, 208, 90, 197, 163, 120, 218, 14, 216, 204, 254, 43, 73, 81, 106 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 23, 84, 104, 129, 217, 208, 48, 135, 99, 25, 35, 138, 163, 121, 119, 240, 210, 210, 51, 131, 251, 223, 161, 232, 229, 28, 241, 76, 29, 182, 181, 224, 96, 136, 44, 245, 249, 116, 103, 221, 182, 1, 144, 95, 144, 135, 166, 210, 174, 230, 190, 226, 104, 168, 47, 174, 6, 0, 205, 47, 209, 127, 248 }, new byte[] { 177, 32, 68, 30, 124, 176, 112, 129, 230, 10, 71, 106, 119, 78, 157, 115, 223, 218, 95, 112, 26, 24, 193, 155, 23, 28, 195, 110, 195, 118, 243, 218, 75, 19, 153, 219, 14, 32, 142, 179, 146, 39, 75, 39, 109, 135, 56, 86, 184, 169, 178, 253, 208, 252, 242, 63, 167, 153, 80, 191, 117, 5, 93, 168, 165, 107, 253, 185, 181, 247, 91, 157, 32, 243, 191, 56, 108, 67, 203, 58, 37, 58, 75, 161, 90, 79, 75, 127, 69, 96, 61, 97, 28, 220, 98, 245, 152, 79, 132, 208, 9, 86, 68, 32, 221, 88, 137, 188, 135, 251, 53, 225, 113, 156, 125, 125, 210, 223, 141, 182, 226, 164, 78, 120, 241, 233, 125, 116 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 149, 114, 60, 167, 205, 90, 13, 208, 89, 153, 254, 72, 225, 42, 101, 118, 191, 171, 216, 226, 161, 14, 173, 187, 87, 177, 236, 217, 51, 23, 20, 81, 253, 33, 163, 235, 32, 249, 176, 184, 176, 221, 231, 181, 61, 157, 7, 233, 33, 30, 203, 95, 123, 64, 118, 227, 28, 192, 98, 129, 71, 165, 227, 188 }, new byte[] { 250, 63, 214, 185, 114, 127, 148, 218, 176, 27, 148, 27, 137, 115, 207, 248, 24, 7, 163, 149, 109, 121, 244, 225, 90, 189, 181, 122, 219, 7, 89, 149, 36, 125, 130, 206, 203, 200, 10, 121, 226, 175, 208, 79, 42, 7, 44, 237, 231, 141, 117, 102, 212, 116, 137, 6, 145, 177, 26, 135, 162, 59, 61, 147, 158, 3, 41, 196, 158, 111, 26, 28, 50, 151, 75, 230, 84, 205, 209, 239, 51, 201, 214, 43, 24, 5, 192, 62, 94, 135, 5, 163, 183, 64, 158, 64, 176, 44, 241, 201, 217, 183, 80, 123, 217, 45, 43, 249, 163, 253, 234, 60, 92, 69, 84, 106, 177, 114, 4, 248, 28, 15, 137, 53, 13, 35, 155, 178 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 250, 110, 131, 157, 32, 201, 84, 238, 152, 44, 191, 95, 187, 188, 81, 47, 45, 110, 36, 93, 89, 81, 140, 248, 81, 139, 181, 72, 144, 98, 136, 110, 116, 253, 115, 0, 58, 244, 244, 2, 245, 97, 249, 64, 70, 207, 181, 97, 215, 217, 176, 100, 4, 121, 118, 205, 178, 72, 195, 37, 140, 49, 157 }, new byte[] { 154, 46, 81, 168, 12, 223, 226, 97, 253, 154, 163, 208, 185, 180, 43, 38, 198, 247, 202, 18, 202, 125, 5, 66, 210, 3, 94, 127, 93, 69, 111, 6, 244, 139, 84, 91, 123, 174, 132, 191, 249, 152, 166, 179, 17, 59, 65, 125, 140, 208, 118, 196, 92, 85, 196, 15, 133, 12, 26, 81, 189, 112, 201, 239, 69, 97, 5, 200, 153, 89, 133, 132, 10, 198, 52, 220, 168, 19, 49, 75, 138, 99, 131, 93, 39, 204, 37, 83, 153, 219, 220, 34, 159, 56, 244, 160, 127, 35, 24, 136, 207, 53, 74, 199, 22, 29, 108, 177, 6, 35, 9, 162, 30, 43, 205, 150, 186, 221, 53, 198, 198, 2, 128, 172, 212, 253, 228, 53 } });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreatedBy", "IsDeleted", "ModifiedBy", "ModifiedDate", "TopicId" },
                values: new object[,]
                {
                    { new Guid("12d2f288-dedb-414d-a7ca-3a7e4d527495"), "{\"Question\":\"Giai \\u0111o\\u1EA1n 1945-1975, v\\u0103n h\\u1ECDc Vi\\u1EC7t Nam \\u0111\\u00E3 t\\u00ECm \\u0111\\u1EBFn nh\\u1EEFng h\\u00ECnh th\\u1EE9c ngh\\u1EC7 thu\\u1EADt n\\u00E0o \\u0111\\u1EC3 ph\\u00F9 h\\u1EE3p v\\u1EDBi nhu c\\u1EA7u th\\u1EA9m m\\u0129 c\\u1EE7a \\u0111\\u1EA1i ch\\u00FAng\",\"ListAnswer\":[{\"Value\":\"M\\u1EDBi m\\u1EBB \\u0111\\u1ED1i v\\u1EDBi nh\\u00E2n d\\u00E2n, \\u0111\\u01B0\\u1EE3c th\\u1EC3 hi\\u1EC7n b\\u1EB1ng m\\u1ED9t ng\\u00F4n ng\\u1EEF ngh\\u1EC7 thu\\u1EADt tinh t\\u1EBF, trau chu\\u1ED1t.\",\"IsAnswer\":false},{\"Value\":\"Quen thu\\u1ED9c \\u0111\\u1ED1i v\\u1EDBi nh\\u00E2n d\\u00E2n, \\u0111\\u01B0\\u1EE3c th\\u1EC3 hi\\u1EC7n b\\u1EB1ng m\\u1ED9t ng\\u00F4n ng\\u1EEF b\\u00ECnh d\\u1ECB, trong s\\u00E1ng, d\\u1EC5 hi\\u1EC3u\",\"IsAnswer\":true},{\"Value\":\"D\\u1EC5 d\\u00E3i \\u0111\\u1ED1i v\\u1EDBi nh\\u00E2n d\\u00E2n, \\u0111\\u01B0\\u1EE3c th\\u1EC3 hi\\u1EC7n b\\u1EB1ng ng\\u00F4n ng\\u1EEF b\\u00ECnh d\\u00E2n, su\\u1ED3ng s\\u00E3\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("1bd17c9e-5fd5-4f20-8af6-8b25ccffddcd"), "{\"Question\":\"V\\u0103n h\\u1ECDc Vi\\u1EC7t Nam giai \\u0111o\\u1EA1n 1945-1975 kh\\u00F4ng m\\u1EAFc ph\\u1EA3i h\\u1EA1n ch\\u1EBF n\\u00E0o?\",\"ListAnswer\":[{\"Value\":\"M\\u1ED9t s\\u1ED1 c\\u00E2y b\\u00FAt ch\\u1EA1y theo th\\u1ECB hi\\u1EBFu th\\u1EA5p k\\u00E9m c\\u1EE7a 1 b\\u1ED9 ph\\u1EADn c\\u00F4ng ch\\u00FAng, bi\\u1EBFn s\\u00E1ng t\\u00E1c v\\u0103n h\\u1ECDc m\\u1ECDt th\\u1EE9 h\\u00E0ng h\\u00F3a \\u0111\\u1EC3 c\\u00E2u kh\\u00E1ch.\",\"IsAnswer\":true},{\"Value\":\"Y\\u00EAu c\\u1EA7u v\\u1EC1 ph\\u1EA9m ch\\u1EA5t ngh\\u1EC7 thu\\u1EADt c\\u1EE7a t\\u00E1c ph\\u1EA9m nhi\\u1EC1u khi b\\u1ECB h\\u1EA1 th\\u1EA5p\",\"IsAnswer\":false},{\"Value\":\"C\\u00E1 t\\u00EDnh, phong c\\u00E1ch ri\\u00EAng c\\u1EE7a nh\\u00E0 v\\u0103n ch\\u01B0a \\u0111\\u01B0\\u1EE3c ph\\u00E1t huy m\\u1EA1nh m\\u1EBD\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("22dd9c89-34df-47bf-9c84-fd4f64ba32f6"), "{\"Question\":\"Quan ni\\u1EC7m v\\u1EC1 \\u0111\\u1ED9c gi\\u1EA3 c\\u1EE7a v\\u0103n h\\u1ECDc Vi\\u1EC7t Nam sau n\\u0103m 1975 c\\u00F3 g\\u00EC m\\u1EDBi?\",\"ListAnswer\":[{\"Value\":\"\\u0110\\u1ED9c gi\\u1EA3 l\\u00E0 nh\\u1EEFng \\u0111\\u1ED1i t\\u01B0\\u1EE3ng \\u0111\\u1EC3 tuy\\u00EAn truy\\u1EC1n, gi\\u00E1c ng\\u1ED9\",\"IsAnswer\":false},{\"Value\":\"\\u0110\\u1ED9c gi\\u1EA3 l\\u00E0 ng\\u01B0\\u1EDDi mua h\\u00E0ng, nh\\u00E0 v\\u0103n l\\u00E0 ng\\u01B0\\u1EDDi b\\u00E1n h\\u00E0ng\",\"IsAnswer\":false},{\"Value\":\"\\u0110\\u1ED9c gi\\u1EA3 l\\u00E0 nh\\u1EEFng ng\\u01B0\\u1EDDi b\\u1EA1n \\u0111\\u1EC3 giao l\\u01B0u, d\\u1ED1i tho\\u1EA1i m\\u1ED9t c\\u00E1ch b\\u00ECnh \\u0111\\u1EB3ng\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("4cfbb40a-4b1d-472f-b6ed-f621ff2e9f58"), "{\"Question\":\"T\\u00E1c ph\\u1EA9m \\u0111\\u01B0\\u1EE3c chia th\\u00E0nh m\\u1EA5y ph\\u1EA7n?\",\"ListAnswer\":[{\"Value\":\"Hai ph\\u1EA7n\",\"IsAnswer\":false},{\"Value\":\"Ba ph\\u1EA7n\",\"IsAnswer\":true},{\"Value\":\"N\\u0103m ph\\u1EA7n\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("9edf87ce-ec37-4e8c-ba8c-79c800ad5d4e"), "{\"Question\":\"T\\u1EEB n\\u0103m 1929 \\u0111\\u1EBFn n\\u0103m 1936, Ph\\u1EA1m V\\u0103n \\u0110\\u1ED3ng b\\u1ECB th\\u1EF1c d\\u00E2n Ph\\u00E1p b\\u1EAFt, k\\u1EBFt \\u00E1n t\\u00F9 v\\u00E0 b\\u1ECB \\u0111i \\u0111\\u00E0y \\u1EDF:\",\"ListAnswer\":[{\"Value\":\"Qu\\u1EA3ng Ng\\u00E3i\",\"IsAnswer\":false},{\"Value\":\"C\\u00F4n \\u0110\\u1EA3o\",\"IsAnswer\":true},{\"Value\":\"Tam \\u0110\\u1EA3o\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("a1c0ea7c-58b7-4083-b9cc-e67423275a58"), "{\"Question\":\"Gi\\u00E1 tr\\u1ECB n\\u1ED9i dung c\\u1EE7a t\\u00E1c ph\\u1EA9m : Nguy\\u1EC5n \\u0110\\u00ECnh Chi\\u1EC3u, ng\\u00F4i sao s\\u00E1ng trong v\\u0103n ngh\\u1EC7 c\\u1EE7a d\\u00E2n t\\u1ED9c l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"T\\u00E1c gi\\u1EA3 h\\u1EBFt l\\u1EDDi ca ng\\u1EE3i Nguy\\u1EC5n \\u0110\\u00ECnh Chi\\u1EC3u, m\\u1ED9t ng\\u01B0\\u1EDDi tr\\u1ECDn \\u0111\\u1EDDi d\\u00F9ng c\\u00E2y b\\u00FAt l\\u00E0m v\\u0169 kh\\u00ED chi\\u1EBFn \\u0111\\u1EA5u cho d\\u00E2n, cho n\\u01B0\\u1EDBc, m\\u1ED9t ng\\u00F4i sao s\\u00E1ng trong n\\u1EC1n v\\u0103n ngh\\u1EC7 c\\u1EE7a d\\u00E2n t\\u1ED9c Vi\\u1EC7t Nam.\",\"IsAnswer\":false},{\"Value\":\"L\\u00E0m s\\u00E1ng t\\u1ECF m\\u1ED1i li\\u00EAn h\\u1EC7 kh\\u0103ng kh\\u00EDt gi\\u1EEFa th\\u01A1 v\\u0103n c\\u1EE7a Nguy\\u1EC5n \\u0110\\u00ECnh Chi\\u1EC3u v\\u1EDBi ho\\u00E0n c\\u1EA3nh c\\u1EE7a T\\u1ED5 qu\\u1ED1c l\\u00FAc b\\u1EA5y gi\\u1EDD v\\u00E0 v\\u1EDBi th\\u1EDDi \\u0111\\u1EA1i hi\\u1EC7n nay.\",\"IsAnswer\":false},{\"Value\":\"C\\u1EA3 hai \\u0111\\u00E1p \\u00E1n tr\\u00EAn \\u0111\\u1EC1u \\u0111\\u00FAng\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("acd7e283-1edb-40f9-bd36-2228d69a1819"), "{\"Question\":\"Truy\\u1EC7n th\\u01A1 n\\u00E0o sau \\u0111\\u00E2y kh\\u00F4ng ph\\u1EA3i c\\u1EE7a Nguy\\u1EC5n \\u0110\\u00ECnh Chi\\u1EC3u?\",\"ListAnswer\":[{\"Value\":\"D\\u01B0\\u01A1ng T\\u1EEB - H\\u00E0 M\\u1EADu\",\"IsAnswer\":false},{\"Value\":\"S\\u01A1 k\\u00EDnh t\\u00E2n trang\",\"IsAnswer\":true},{\"Value\":\"Ng\\u01B0 Ti\\u1EC1u Y thu\\u1EADt v\\u1EA5n \\u0111\\u00E1p\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("b6cb7448-a377-42c8-ae85-75c3f65fea88"), "{\"Question\":\"\\u0110\\u1EB7c \\u0111i\\u1EC3m n\\u00E0o sau \\u0111\\u00E2y kh\\u00F4ng ph\\u1EA3i l\\u00E0 \\u0111\\u1EB7c tr\\u01B0ng c\\u1EE7a phong c\\u00E1ch ng\\u00F4n ng\\u1EEF khoa h\\u1ECDc?\",\"ListAnswer\":[{\"Value\":\"T\\u00EDnh kh\\u00E1i qu\\u00E1t tr\\u1EEBu t\\u01B0\\u1EE3ng\",\"IsAnswer\":false},{\"Value\":\"T\\u00EDnh kh\\u00E1ch quan, phi c\\u00E1 th\\u1EC3\",\"IsAnswer\":false},{\"Value\":\"T\\u00EDnh truy\\u1EC1n c\\u1EA3m thuy\\u1EBFt ph\\u1EE5c\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("bc0e149e-20a5-4216-ba3f-245bb9e3e929"), "{\"Question\":\"\\u00DD n\\u00E0o sau \\u0111\\u00E2y kh\\u00F4ng \\u0111\\u00FAng khi n\\u00F3i v\\u1EC1 \\u0111\\u1EB7c \\u0111i\\u1EC3m khuynh h\\u01B0\\u1EDBng l\\u00E3ng m\\u1EA1n \\u0111\\u01B0\\u1EE3c th\\u1EC3 hi\\u1EC7n nh\\u01B0 th\\u1EBF n\\u00E0o trong v\\u0103n h\\u1ECDc giai \\u0111o\\u1EA1n 1945-1975\",\"ListAnswer\":[{\"Value\":\"L\\u00E0 khuynh h\\u01B0\\u1EDBng tr\\u00E0n \\u0111\\u1EA7y m\\u01A1 \\u01B0\\u1EDBc, h\\u01B0\\u1EDBng t\\u1EDBi t\\u01B0\\u01A1ng lai\",\"IsAnswer\":false},{\"Value\":\"Kh\\u1EB3ng \\u0111\\u1ECBnh l\\u00ED t\\u01B0\\u1EDFng c\\u1EE7a cu\\u1ED9c s\\u1ED1ng m\\u1EDBi, v\\u1EBB \\u0111\\u1EB9p c\\u1EE7a con ng\\u01B0\\u1EDDi m\\u1EDBi\",\"IsAnswer\":false},{\"Value\":\"C\\u00E1c t\\u00E1c ph\\u1EA9m \\u0111\\u1EC1u c\\u00F3 k\\u1EBFt th\\u00FAc c\\u00F3 h\\u1EADu, \\u0111\\u01B0\\u1EE3c h\\u01B0\\u1EDFng cu\\u1ED9c s\\u1ED1ng h\\u1EA1nh ph\\u00FAc, no \\u1EA5m\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") },
                    { new Guid("f4e17213-cfe6-4fd4-8f04-6ad9127c8ef7"), "{\"Question\":\"T\\u00E1c ph\\u1EA9m \\u0111\\u01B0\\u1EE3c vi\\u1EBFt theo th\\u1EC3 lo\\u1EA1i n\\u00E0o?\",\"ListAnswer\":[{\"Value\":\"V\\u0103n ngh\\u1ECB lu\\u1EADn\",\"IsAnswer\":true},{\"Value\":\"V\\u0103n xu\\u00F4i\",\"IsAnswer\":false},{\"Value\":\"V\\u0103n ch\\u00EDnh lu\\u1EADn\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("7c506348-0444-4c91-ad50-15b952135294") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("043ce175-c8d9-421e-a4fe-c56bec91b704"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("12d2f288-dedb-414d-a7ca-3a7e4d527495"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("17a5ca0d-c4da-4554-a714-e0b9badada82"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("188c4fda-2283-4ab1-8eae-e1f9db22a2b0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1abf63a6-2a63-4b91-bd36-856c13309419"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1bd17c9e-5fd5-4f20-8af6-8b25ccffddcd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("208c8070-f3bd-4caa-8a72-fcfc805a2756"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("22dd9c89-34df-47bf-9c84-fd4f64ba32f6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2688e556-145c-4f09-8dbc-8e475b30f79e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2c845a9e-bf68-475f-8cdc-90d3634e44bb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("30746883-03fd-47aa-99eb-d9c0c3c39f93"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("32cea7fb-b070-4f98-a1af-e5d7fdb494e2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("37c803d8-be52-48c9-af20-aa586878cd6f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3848919c-ba2f-41f3-8c50-176275dd76cb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3e62a92e-e050-42b4-8d13-4194ecac2f42"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("45d36bbc-a0fb-44bb-9d53-0a957348a341"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("479690de-b69a-4652-b0db-49545b76a26e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4cfbb40a-4b1d-472f-b6ed-f621ff2e9f58"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("51c0e4fa-7565-4230-9dd6-cd40f4667ccc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5801238f-e7f7-4335-8e99-f92728cc6d59"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("58aca4f0-7ef3-4d69-828b-35d19e42cace"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5c780d44-d323-48ad-9cc4-8f03b61c6678"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("65fce6a4-b1fc-4cea-a040-5fd0cf7e0958"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("67077697-1769-4658-b9ce-e443180e6ff4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d8d0d49-2fcb-438b-b0f7-16496a737a6c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6e6f683f-70cc-415a-bb0c-f0aa7962d649"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("72606ff9-6cb1-4466-a9c1-f2143e68f4cf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("733909fe-c214-4d72-b6fc-f4c8e176f842"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("75a4aef4-0914-4509-a778-149c8c18edce"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("75e9556c-f0b0-4b3b-b2d1-c34f19e7491b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("75eeeaf3-5d75-48e4-aa8b-f18f4fbe81eb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("760f9cce-e1bf-415f-9432-71cc69c9af85"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("79c09f5a-9ee5-4a93-b268-05d178d43f23"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7a03d7ad-eeef-48ae-b732-6833bcf3a044"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7af0247b-a9fe-48e0-aa2f-eb7b31dcd698"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7c142395-2435-4549-a4cf-d483179cd48a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7d2ef0c9-bbcc-4313-a9b5-45e7ea76bdd0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7ef701de-6f5d-4059-9bfe-596bddfbeaac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("84680ba8-f5b2-4c12-839d-1177b98a0b4c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8d199b0b-e54f-41d1-b266-32da75652d57"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8e9f36cb-54eb-48d4-b5c9-d7cbaf1f744c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("921aecb2-3208-448b-bc96-0c833dd576cc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92557132-9238-4d73-8f09-d95717bd90f3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("956ad23f-9c28-42d7-aeea-764dca133c20"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("99b02765-cceb-4bc3-a28e-705d20737154"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9bf57282-2764-4111-a657-eb17760c070a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9c51879f-c0d9-48ac-8b12-4815d5b44974"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9cd5e3c3-056e-48ea-948c-707e2fb4efb3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9edf87ce-ec37-4e8c-ba8c-79c800ad5d4e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9fd1ad12-cebb-4450-bfeb-c8618d924b75"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a1c0ea7c-58b7-4083-b9cc-e67423275a58"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a28c8be3-ab1e-4fc5-a641-0360d3f9f6e0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a294a985-9bdb-4eee-b593-837776db1553"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("abf931e5-52fd-44f8-9941-08ac0ec1c876"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("acd7e283-1edb-40f9-bd36-2228d69a1819"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b0a4c2fe-9e68-438b-898f-e2161826d722"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b4134c55-0411-45c9-9d97-89d8ab11bfc4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b57da0ee-c931-43bc-8709-1eaf851a6aec"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b6477824-5d8c-4b82-a725-b765000c7830"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b6cb7448-a377-42c8-ae85-75c3f65fea88"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b7aa8c42-5ad5-4a5c-9b5d-b4f2d1d4e331"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc0e149e-20a5-4216-ba3f-245bb9e3e929"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc590d16-97bb-4ccf-8245-584675f0cd60"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bd235389-9531-44ac-b2ae-707c820c939b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("be7ac590-66b0-4c93-81e5-6b893c386844"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c96a6886-0210-4059-85c0-43b32ce23730"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cbdea889-463d-4ecc-bf8f-f05467f1fc19"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cc760427-bedc-4728-bf27-96bf043db449"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cca4025d-9a6e-4f2a-8759-2dfac58c6a6a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cf13aa13-1104-4b55-bc06-bef52a8dcdb3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d6fe0d35-1858-41dd-9ef6-747adb651bb2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d9cf5916-5fe2-424b-bf05-83d07b07fce1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de226c30-025a-4f46-b071-fc76cbfc5ff5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e3ddebdc-b041-4f1a-9c32-1f287ee75c08"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e6b2ed05-8c88-47ce-8cb7-ab7038ac93c5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e7d454dc-e07b-4d56-bfc0-c33b4455192d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ea6ca33f-7780-4ecb-9311-4d1c3d8e4337"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("efaaf3af-cbfc-4a92-a101-1533a05081fc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f1854eb1-754b-4488-9d4a-088c008c5cf0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f4e17213-cfe6-4fd4-8f04-6ad9127c8ef7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7c506348-0444-4c91-ad50-15b952135294"));

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 12, 8, 2, 8, 47, 575, DateTimeKind.Utc).AddTicks(822), new DateTime(2023, 12, 9, 2, 8, 47, 575, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 177, 182, 147, 27, 96, 163, 9, 8, 63, 161, 150, 79, 103, 166, 242, 147, 186, 125, 37, 216, 152, 223, 72, 38, 209, 93, 95, 238, 131, 107, 201, 180, 98, 27, 190, 189, 213, 8, 76, 30, 126, 17, 113, 225, 80, 79, 83, 20, 69, 121, 72, 14, 151, 85, 105, 158, 171, 122, 250, 52, 188, 40, 208 }, new byte[] { 198, 214, 214, 222, 229, 84, 249, 97, 184, 194, 14, 51, 128, 201, 89, 58, 254, 124, 254, 253, 142, 235, 188, 9, 242, 56, 2, 252, 106, 77, 26, 104, 191, 5, 193, 5, 241, 225, 58, 31, 2, 75, 19, 222, 11, 246, 34, 22, 158, 47, 131, 84, 208, 22, 150, 184, 241, 75, 248, 120, 45, 246, 43, 143, 216, 238, 97, 157, 194, 29, 182, 65, 106, 206, 91, 118, 221, 221, 158, 178, 116, 96, 234, 205, 17, 146, 122, 190, 213, 202, 79, 12, 13, 124, 22, 234, 202, 174, 59, 246, 202, 161, 125, 206, 135, 168, 90, 71, 16, 79, 165, 223, 105, 176, 245, 143, 178, 167, 67, 92, 101, 39, 188, 139, 22, 123, 187, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 84, 167, 68, 246, 101, 184, 151, 140, 31, 154, 112, 115, 81, 216, 117, 228, 106, 29, 89, 76, 237, 218, 245, 33, 186, 153, 122, 51, 40, 71, 12, 230, 207, 173, 87, 89, 101, 85, 39, 181, 206, 110, 16, 118, 78, 253, 141, 165, 72, 85, 249, 57, 63, 201, 58, 246, 20, 43, 119, 29, 46, 146, 92, 18 }, new byte[] { 108, 69, 117, 140, 176, 95, 5, 41, 179, 9, 18, 105, 242, 204, 57, 62, 157, 80, 99, 116, 53, 183, 61, 116, 233, 10, 223, 59, 178, 193, 63, 165, 143, 19, 224, 218, 182, 69, 246, 143, 174, 41, 39, 213, 138, 140, 76, 246, 134, 201, 92, 126, 171, 112, 172, 0, 27, 64, 61, 222, 226, 119, 174, 251, 227, 250, 247, 99, 92, 151, 252, 253, 169, 19, 157, 214, 180, 89, 171, 191, 140, 182, 100, 93, 100, 147, 10, 142, 160, 49, 208, 7, 207, 177, 93, 33, 51, 61, 75, 186, 112, 47, 109, 84, 104, 107, 192, 158, 146, 172, 227, 94, 18, 167, 175, 167, 69, 38, 165, 195, 77, 174, 145, 147, 54, 227, 88, 6 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 170, 164, 46, 147, 225, 16, 222, 219, 109, 217, 133, 195, 208, 24, 255, 223, 102, 190, 36, 51, 17, 193, 121, 66, 213, 138, 249, 34, 57, 247, 203, 215, 95, 30, 174, 39, 84, 110, 250, 79, 111, 184, 116, 20, 251, 134, 76, 182, 91, 30, 128, 31, 22, 65, 223, 252, 33, 210, 123, 131, 83, 157, 255 }, new byte[] { 34, 93, 16, 138, 19, 209, 45, 34, 14, 134, 179, 206, 89, 122, 164, 224, 71, 140, 224, 97, 111, 226, 31, 190, 24, 74, 184, 220, 226, 107, 80, 54, 34, 158, 32, 67, 121, 206, 58, 139, 148, 215, 252, 231, 31, 32, 159, 219, 236, 42, 52, 218, 144, 117, 140, 29, 210, 68, 177, 138, 228, 254, 3, 117, 192, 98, 208, 50, 221, 75, 178, 100, 167, 13, 1, 194, 80, 82, 46, 228, 99, 250, 138, 179, 159, 50, 200, 144, 94, 118, 6, 186, 235, 196, 193, 176, 12, 103, 219, 172, 30, 113, 78, 185, 200, 52, 115, 135, 170, 196, 113, 59, 48, 23, 244, 243, 243, 161, 42, 92, 105, 93, 138, 163, 56, 57, 211, 103 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 48, 186, 122, 21, 197, 121, 69, 0, 63, 57, 190, 222, 161, 64, 175, 173, 117, 60, 197, 199, 255, 129, 181, 49, 174, 23, 1, 28, 165, 228, 31, 196, 144, 207, 174, 81, 73, 146, 198, 168, 96, 227, 153, 158, 46, 225, 95, 228, 119, 189, 87, 121, 182, 27, 69, 175, 215, 109, 201, 71, 209, 111, 137 }, new byte[] { 180, 171, 109, 187, 249, 39, 132, 174, 64, 20, 6, 35, 125, 226, 219, 247, 20, 36, 146, 169, 27, 237, 54, 88, 159, 151, 127, 176, 16, 136, 170, 227, 83, 16, 88, 90, 167, 172, 109, 253, 140, 105, 67, 3, 153, 142, 183, 153, 57, 103, 150, 220, 19, 195, 201, 122, 173, 9, 111, 8, 240, 12, 225, 9, 247, 72, 45, 199, 206, 143, 208, 216, 101, 156, 210, 11, 26, 67, 91, 242, 159, 204, 19, 159, 168, 39, 168, 192, 175, 108, 184, 75, 8, 213, 52, 117, 59, 63, 22, 243, 20, 192, 88, 205, 105, 153, 234, 209, 150, 171, 114, 62, 32, 4, 242, 242, 2, 161, 65, 23, 26, 66, 246, 200, 231, 129, 82, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 128, 151, 251, 85, 71, 155, 32, 58, 219, 104, 104, 247, 249, 113, 23, 159, 171, 145, 224, 58, 42, 188, 37, 210, 19, 125, 202, 240, 176, 251, 166, 206, 141, 234, 131, 180, 41, 64, 3, 204, 40, 140, 56, 7, 252, 75, 243, 108, 11, 98, 115, 118, 221, 202, 62, 6, 184, 135, 35, 39, 221, 232, 203 }, new byte[] { 211, 240, 0, 114, 88, 236, 58, 4, 169, 24, 176, 38, 121, 3, 173, 180, 94, 5, 50, 8, 242, 242, 47, 60, 239, 24, 156, 88, 61, 101, 214, 19, 153, 115, 245, 210, 118, 228, 14, 219, 50, 172, 197, 62, 61, 205, 170, 62, 113, 4, 69, 218, 40, 246, 191, 26, 12, 71, 193, 21, 74, 145, 0, 210, 129, 111, 252, 46, 65, 82, 7, 120, 179, 182, 188, 33, 41, 219, 163, 18, 111, 236, 253, 107, 93, 191, 17, 63, 57, 184, 174, 19, 31, 40, 252, 1, 88, 9, 100, 166, 109, 60, 81, 5, 80, 58, 1, 69, 23, 159, 169, 26, 190, 227, 209, 109, 20, 21, 0, 90, 50, 55, 46, 129, 201, 189, 63, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 92, 164, 24, 18, 144, 200, 144, 200, 141, 3, 171, 93, 149, 228, 59, 96, 100, 204, 3, 8, 13, 98, 185, 200, 243, 134, 17, 211, 224, 102, 196, 44, 27, 20, 46, 100, 216, 202, 174, 218, 80, 52, 64, 11, 152, 17, 18, 165, 103, 173, 42, 62, 46, 127, 250, 177, 202, 149, 233, 73, 104, 134, 235 }, new byte[] { 54, 226, 144, 216, 44, 148, 210, 223, 154, 65, 208, 7, 81, 141, 108, 9, 207, 83, 57, 206, 8, 135, 86, 247, 44, 32, 105, 14, 98, 52, 231, 92, 92, 93, 26, 50, 106, 4, 16, 254, 117, 227, 37, 82, 92, 131, 209, 38, 11, 61, 14, 76, 180, 54, 48, 144, 89, 244, 26, 48, 151, 176, 51, 22, 90, 10, 182, 6, 148, 243, 11, 50, 159, 16, 226, 119, 23, 44, 63, 52, 222, 201, 200, 160, 235, 49, 234, 95, 247, 235, 58, 63, 0, 39, 19, 13, 220, 47, 28, 184, 19, 102, 225, 116, 15, 48, 50, 39, 11, 117, 129, 43, 183, 26, 242, 14, 180, 183, 196, 189, 54, 110, 110, 191, 1, 167, 72, 20 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 91, 169, 7, 232, 143, 239, 1, 229, 195, 158, 168, 74, 146, 83, 17, 162, 11, 57, 214, 189, 54, 106, 129, 229, 184, 37, 69, 16, 32, 215, 173, 69, 176, 51, 115, 50, 121, 198, 82, 204, 15, 27, 223, 175, 162, 126, 166, 10, 151, 92, 161, 98, 94, 18, 166, 17, 19, 12, 114, 69, 97, 191, 54 }, new byte[] { 242, 237, 25, 250, 214, 172, 134, 62, 34, 115, 137, 52, 101, 1, 228, 107, 220, 11, 134, 162, 215, 46, 233, 138, 158, 13, 210, 2, 160, 86, 152, 252, 62, 46, 180, 67, 197, 246, 119, 125, 248, 57, 2, 253, 136, 165, 193, 34, 22, 98, 247, 220, 211, 15, 126, 192, 13, 75, 171, 88, 229, 225, 119, 20, 127, 122, 10, 35, 7, 34, 67, 89, 192, 232, 132, 158, 14, 110, 190, 158, 166, 241, 250, 235, 173, 97, 189, 254, 227, 234, 221, 66, 109, 147, 105, 76, 66, 218, 129, 14, 60, 21, 58, 240, 244, 68, 227, 54, 7, 230, 231, 222, 212, 105, 112, 201, 67, 3, 209, 249, 167, 96, 25, 101, 232, 88, 93, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 241, 111, 237, 160, 86, 207, 124, 86, 88, 213, 178, 55, 111, 84, 16, 99, 211, 112, 138, 82, 71, 110, 153, 51, 63, 60, 221, 152, 180, 138, 63, 114, 5, 170, 43, 19, 145, 85, 193, 17, 72, 249, 87, 15, 4, 102, 176, 196, 230, 12, 207, 42, 65, 222, 183, 231, 225, 183, 135, 170, 63, 174, 40 }, new byte[] { 5, 162, 238, 251, 47, 252, 249, 172, 230, 125, 13, 93, 216, 104, 116, 211, 31, 194, 185, 193, 175, 199, 205, 245, 94, 144, 245, 78, 237, 183, 13, 71, 158, 123, 202, 22, 207, 76, 56, 36, 168, 78, 244, 198, 193, 124, 216, 113, 150, 148, 244, 104, 72, 239, 59, 167, 109, 96, 122, 235, 1, 164, 136, 209, 136, 84, 179, 61, 79, 11, 84, 205, 245, 34, 226, 65, 151, 207, 53, 45, 222, 36, 199, 11, 159, 206, 179, 123, 114, 129, 103, 176, 121, 28, 205, 203, 206, 14, 198, 244, 245, 236, 230, 98, 62, 252, 236, 204, 216, 88, 184, 2, 109, 103, 190, 227, 204, 175, 101, 163, 255, 202, 82, 196, 218, 28, 143, 45 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 111, 137, 8, 195, 240, 180, 159, 49, 108, 241, 235, 208, 117, 102, 200, 130, 241, 251, 174, 97, 157, 189, 205, 70, 227, 57, 124, 228, 77, 88, 34, 213, 175, 16, 56, 128, 230, 127, 42, 212, 175, 15, 142, 214, 190, 119, 163, 49, 48, 235, 204, 142, 233, 240, 73, 94, 201, 6, 249, 126, 162, 194, 9 }, new byte[] { 47, 156, 27, 92, 190, 190, 198, 137, 90, 247, 165, 72, 229, 15, 118, 42, 48, 92, 71, 100, 186, 81, 251, 227, 212, 154, 187, 197, 34, 144, 120, 115, 145, 215, 77, 40, 88, 143, 146, 49, 123, 131, 91, 128, 177, 96, 219, 128, 230, 253, 94, 135, 253, 5, 149, 102, 250, 211, 180, 8, 166, 201, 218, 23, 191, 96, 61, 216, 160, 247, 145, 233, 21, 243, 94, 127, 146, 9, 83, 90, 125, 202, 64, 54, 136, 246, 240, 239, 143, 113, 16, 76, 49, 219, 155, 194, 109, 225, 5, 153, 25, 3, 72, 224, 38, 112, 3, 151, 121, 59, 8, 70, 214, 205, 7, 245, 67, 149, 39, 49, 146, 238, 26, 101, 160, 93, 181, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 143, 183, 26, 95, 198, 102, 195, 64, 231, 81, 206, 53, 209, 170, 198, 49, 250, 223, 94, 254, 9, 115, 46, 161, 154, 32, 149, 170, 196, 104, 3, 30, 97, 39, 164, 85, 168, 41, 201, 185, 107, 190, 28, 192, 59, 6, 55, 201, 36, 9, 48, 198, 117, 143, 68, 189, 55, 14, 192, 150, 121, 128, 186, 108 }, new byte[] { 186, 106, 213, 64, 37, 101, 2, 45, 213, 118, 133, 139, 32, 248, 114, 20, 81, 114, 187, 108, 27, 72, 172, 240, 42, 243, 143, 32, 140, 72, 120, 104, 247, 184, 174, 82, 145, 129, 241, 49, 2, 227, 62, 27, 34, 75, 139, 252, 76, 133, 50, 81, 69, 147, 153, 84, 128, 144, 9, 1, 202, 252, 9, 1, 194, 211, 170, 220, 83, 96, 2, 77, 67, 255, 141, 40, 39, 28, 174, 1, 95, 222, 212, 148, 171, 252, 163, 164, 97, 23, 54, 58, 250, 249, 66, 232, 71, 251, 124, 219, 246, 66, 29, 169, 28, 197, 9, 42, 115, 240, 87, 95, 192, 23, 143, 147, 93, 54, 7, 157, 8, 222, 213, 140, 192, 119, 115, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 166, 88, 16, 102, 78, 231, 18, 141, 183, 155, 204, 109, 235, 29, 100, 180, 218, 131, 77, 246, 64, 154, 247, 193, 111, 70, 75, 138, 159, 228, 239, 7, 79, 62, 176, 78, 244, 159, 133, 110, 62, 213, 53, 87, 138, 94, 166, 232, 121, 165, 133, 54, 180, 170, 76, 156, 2, 139, 151, 230, 194, 92, 61, 123 }, new byte[] { 149, 120, 192, 40, 161, 205, 232, 59, 21, 203, 10, 62, 201, 233, 178, 18, 38, 191, 149, 133, 122, 136, 242, 12, 34, 124, 20, 251, 198, 252, 96, 48, 196, 235, 248, 150, 74, 150, 25, 70, 34, 189, 96, 250, 116, 112, 206, 145, 176, 70, 89, 196, 100, 206, 69, 42, 246, 203, 168, 58, 52, 150, 103, 44, 213, 136, 113, 185, 18, 139, 18, 41, 27, 104, 207, 103, 17, 108, 90, 176, 108, 74, 156, 232, 82, 32, 21, 105, 23, 53, 101, 110, 117, 89, 133, 61, 179, 233, 202, 118, 196, 62, 227, 246, 68, 114, 242, 240, 249, 230, 80, 69, 202, 144, 133, 19, 177, 113, 144, 211, 119, 219, 221, 14, 228, 94, 22, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 254, 107, 196, 183, 139, 169, 12, 2, 199, 148, 76, 187, 93, 123, 168, 159, 111, 196, 35, 59, 218, 43, 81, 33, 42, 232, 61, 242, 244, 116, 193, 31, 109, 103, 227, 49, 231, 123, 68, 36, 170, 28, 85, 164, 203, 252, 100, 239, 72, 12, 158, 118, 21, 223, 6, 106, 179, 194, 164, 235, 99, 4, 52, 181 }, new byte[] { 35, 164, 146, 219, 217, 180, 183, 195, 181, 113, 195, 68, 19, 251, 10, 230, 15, 143, 226, 129, 142, 82, 130, 238, 105, 28, 242, 28, 116, 0, 52, 31, 208, 157, 238, 131, 10, 38, 181, 214, 102, 26, 82, 142, 132, 117, 171, 235, 2, 228, 107, 53, 202, 120, 84, 219, 20, 189, 237, 72, 249, 22, 47, 107, 155, 239, 101, 209, 68, 139, 50, 59, 167, 5, 23, 151, 217, 192, 27, 143, 149, 49, 69, 221, 0, 111, 110, 254, 70, 178, 197, 66, 196, 24, 193, 226, 110, 161, 118, 125, 20, 214, 69, 55, 222, 244, 228, 5, 194, 175, 156, 209, 210, 207, 224, 73, 74, 40, 94, 45, 181, 235, 161, 80, 175, 131, 241, 17 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 203, 219, 22, 107, 159, 10, 152, 12, 110, 122, 185, 123, 160, 122, 18, 68, 95, 40, 161, 52, 232, 84, 162, 208, 192, 149, 98, 16, 128, 91, 79, 182, 194, 245, 172, 179, 221, 234, 130, 135, 78, 27, 142, 194, 229, 53, 34, 87, 89, 82, 92, 126, 221, 89, 13, 85, 86, 70, 33, 84, 23, 123, 100, 230 }, new byte[] { 198, 101, 74, 252, 78, 60, 106, 71, 36, 72, 226, 198, 216, 62, 85, 162, 250, 160, 26, 205, 25, 161, 100, 46, 243, 239, 149, 11, 39, 108, 66, 225, 217, 89, 170, 138, 198, 135, 91, 209, 141, 139, 79, 119, 225, 195, 59, 92, 10, 149, 169, 184, 105, 23, 208, 251, 77, 228, 163, 62, 123, 24, 97, 192, 70, 148, 144, 134, 5, 245, 168, 188, 24, 1, 180, 63, 83, 148, 188, 251, 244, 34, 176, 134, 132, 89, 59, 63, 14, 87, 43, 68, 202, 242, 154, 254, 107, 127, 77, 102, 19, 228, 80, 244, 165, 166, 106, 153, 165, 86, 200, 181, 67, 251, 87, 23, 67, 85, 149, 137, 24, 217, 18, 190, 96, 155, 88, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 236, 194, 250, 252, 186, 68, 174, 228, 205, 162, 12, 172, 115, 85, 125, 114, 117, 146, 82, 30, 50, 22, 114, 136, 204, 145, 116, 65, 177, 101, 158, 116, 196, 187, 119, 212, 23, 96, 19, 99, 30, 8, 23, 117, 82, 179, 160, 155, 131, 178, 97, 248, 173, 12, 124, 33, 202, 82, 139, 88, 171, 92, 180 }, new byte[] { 46, 67, 174, 58, 104, 108, 3, 216, 136, 206, 137, 167, 41, 220, 76, 174, 206, 82, 60, 184, 56, 239, 132, 61, 94, 4, 133, 158, 118, 18, 83, 249, 209, 0, 223, 135, 29, 194, 90, 242, 133, 221, 63, 255, 13, 146, 100, 167, 222, 138, 91, 216, 60, 157, 22, 66, 45, 231, 41, 5, 227, 133, 227, 232, 190, 231, 190, 5, 231, 240, 142, 167, 231, 71, 29, 226, 117, 28, 142, 145, 210, 171, 123, 156, 86, 7, 98, 15, 51, 198, 255, 187, 227, 69, 21, 113, 231, 162, 187, 34, 2, 202, 29, 67, 163, 193, 144, 65, 40, 81, 23, 160, 247, 114, 254, 166, 112, 199, 223, 54, 190, 233, 119, 81, 134, 58, 16, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 198, 26, 200, 38, 114, 137, 92, 2, 166, 245, 10, 15, 96, 189, 75, 4, 59, 205, 42, 145, 95, 156, 228, 37, 233, 213, 201, 68, 180, 92, 72, 163, 63, 55, 76, 199, 251, 121, 198, 204, 88, 122, 122, 173, 57, 233, 20, 139, 75, 11, 59, 30, 53, 200, 208, 181, 173, 104, 14, 191, 83, 134, 21, 123 }, new byte[] { 223, 224, 168, 14, 179, 15, 118, 111, 178, 64, 54, 54, 107, 148, 30, 103, 194, 253, 136, 184, 93, 19, 60, 200, 19, 135, 234, 101, 232, 223, 178, 177, 208, 86, 42, 66, 253, 64, 37, 91, 128, 94, 144, 169, 192, 152, 179, 55, 62, 146, 223, 195, 51, 103, 72, 28, 11, 24, 42, 213, 74, 205, 99, 25, 89, 233, 153, 166, 124, 83, 147, 71, 164, 48, 214, 253, 117, 158, 217, 238, 109, 116, 171, 72, 220, 63, 129, 153, 141, 212, 127, 103, 77, 145, 53, 44, 213, 247, 203, 220, 10, 167, 82, 213, 209, 196, 150, 233, 64, 255, 0, 195, 9, 14, 124, 92, 31, 144, 99, 48, 167, 112, 76, 90, 15, 191, 102, 27 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 53, 246, 162, 146, 10, 52, 102, 143, 106, 148, 53, 115, 232, 29, 13, 145, 221, 109, 251, 254, 8, 56, 156, 250, 22, 244, 65, 176, 62, 151, 133, 114, 70, 254, 144, 0, 149, 22, 86, 249, 53, 228, 63, 177, 133, 91, 182, 247, 120, 162, 248, 36, 5, 81, 102, 150, 73, 214, 190, 153, 242, 185, 206, 160 }, new byte[] { 230, 236, 187, 164, 165, 196, 170, 73, 140, 27, 144, 132, 178, 218, 94, 220, 234, 72, 59, 21, 237, 161, 85, 78, 159, 104, 40, 195, 40, 172, 249, 101, 86, 192, 43, 253, 135, 100, 78, 21, 143, 120, 199, 255, 183, 193, 49, 181, 102, 0, 149, 103, 97, 3, 65, 206, 42, 108, 132, 69, 104, 177, 104, 163, 83, 68, 196, 167, 221, 140, 49, 144, 52, 149, 163, 185, 30, 180, 169, 39, 184, 135, 121, 181, 250, 238, 29, 133, 212, 200, 145, 77, 235, 109, 223, 238, 107, 232, 88, 49, 128, 16, 253, 47, 90, 133, 156, 207, 68, 110, 226, 70, 161, 36, 63, 19, 146, 146, 230, 5, 146, 159, 28, 232, 119, 131, 45, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 83, 4, 142, 122, 218, 124, 165, 52, 77, 253, 156, 189, 108, 25, 29, 149, 172, 32, 223, 93, 107, 234, 224, 24, 160, 135, 116, 151, 3, 40, 112, 75, 41, 104, 0, 209, 208, 11, 57, 73, 140, 49, 211, 214, 117, 150, 53, 37, 1, 116, 168, 152, 139, 106, 253, 158, 8, 139, 42, 213, 5, 166, 243 }, new byte[] { 7, 159, 40, 127, 45, 128, 147, 93, 110, 22, 178, 169, 37, 204, 208, 235, 125, 219, 146, 222, 16, 165, 195, 179, 123, 177, 169, 250, 113, 31, 201, 160, 186, 227, 47, 21, 22, 142, 112, 83, 6, 246, 66, 134, 180, 229, 12, 81, 231, 2, 224, 204, 63, 119, 197, 25, 48, 26, 90, 246, 38, 61, 112, 69, 48, 230, 118, 146, 149, 88, 232, 158, 80, 240, 87, 220, 137, 200, 21, 153, 168, 136, 204, 46, 35, 35, 84, 244, 44, 199, 162, 89, 58, 112, 43, 189, 29, 205, 193, 73, 97, 204, 192, 77, 132, 84, 99, 218, 129, 77, 42, 117, 232, 104, 76, 178, 226, 174, 132, 20, 83, 223, 143, 36, 141, 224, 180, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 207, 109, 224, 21, 115, 221, 188, 186, 27, 76, 237, 176, 148, 124, 175, 248, 37, 41, 254, 206, 207, 24, 104, 34, 70, 47, 32, 158, 92, 179, 119, 134, 97, 218, 214, 161, 28, 119, 126, 173, 211, 189, 158, 149, 235, 136, 49, 25, 64, 90, 180, 109, 73, 6, 175, 196, 28, 27, 153, 232, 9, 205, 148 }, new byte[] { 185, 20, 109, 120, 10, 144, 51, 100, 250, 131, 222, 255, 30, 60, 17, 143, 175, 133, 104, 167, 74, 195, 139, 254, 63, 128, 186, 61, 200, 228, 8, 254, 53, 248, 140, 194, 254, 161, 38, 109, 180, 20, 168, 203, 231, 236, 122, 38, 207, 72, 191, 250, 110, 31, 26, 134, 198, 233, 225, 141, 186, 25, 50, 199, 235, 126, 64, 227, 206, 65, 191, 116, 241, 190, 237, 49, 40, 208, 58, 120, 198, 249, 36, 8, 41, 179, 6, 254, 61, 18, 3, 214, 176, 32, 237, 165, 132, 137, 125, 156, 143, 215, 57, 149, 151, 109, 172, 159, 180, 99, 239, 138, 18, 249, 103, 207, 171, 92, 12, 95, 189, 166, 50, 213, 162, 196, 162, 62 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 153, 145, 0, 12, 21, 172, 125, 209, 151, 89, 18, 94, 108, 231, 231, 203, 191, 36, 232, 69, 161, 67, 173, 186, 228, 219, 207, 52, 96, 176, 174, 61, 52, 27, 191, 145, 1, 222, 42, 67, 235, 232, 155, 32, 132, 140, 94, 78, 224, 80, 173, 124, 240, 197, 73, 88, 85, 212, 119, 252, 177, 201, 252 }, new byte[] { 49, 48, 98, 198, 110, 206, 167, 238, 216, 64, 129, 243, 55, 31, 76, 193, 85, 213, 192, 146, 166, 216, 63, 13, 56, 61, 138, 217, 156, 117, 45, 20, 75, 69, 84, 181, 169, 26, 100, 220, 36, 137, 164, 162, 242, 231, 204, 176, 150, 148, 150, 93, 112, 132, 207, 190, 236, 52, 250, 234, 177, 54, 146, 171, 188, 36, 216, 14, 168, 226, 119, 103, 248, 20, 102, 89, 223, 95, 238, 36, 156, 180, 28, 57, 138, 248, 222, 34, 249, 63, 52, 251, 246, 49, 13, 79, 147, 143, 20, 190, 100, 63, 185, 102, 140, 95, 158, 252, 179, 7, 156, 221, 157, 56, 49, 200, 4, 78, 213, 192, 35, 43, 245, 151, 64, 169, 161, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 128, 204, 222, 72, 149, 130, 29, 224, 243, 78, 142, 197, 11, 63, 13, 211, 147, 102, 61, 112, 247, 70, 238, 58, 12, 95, 84, 179, 214, 188, 43, 197, 23, 252, 114, 44, 249, 101, 223, 158, 12, 10, 250, 23, 245, 67, 126, 77, 67, 228, 87, 113, 60, 185, 83, 85, 224, 252, 156, 51, 195, 17, 39, 220 }, new byte[] { 2, 169, 159, 156, 102, 185, 228, 249, 115, 70, 85, 41, 217, 11, 90, 99, 1, 183, 149, 94, 194, 232, 219, 200, 164, 6, 159, 169, 162, 215, 205, 49, 65, 118, 139, 255, 45, 247, 12, 27, 223, 237, 163, 117, 8, 164, 49, 163, 249, 240, 39, 208, 218, 45, 126, 142, 163, 153, 111, 109, 211, 23, 37, 26, 35, 71, 131, 115, 90, 222, 213, 162, 175, 123, 162, 234, 57, 250, 250, 136, 100, 75, 99, 184, 43, 31, 236, 232, 166, 71, 83, 61, 239, 243, 227, 140, 171, 58, 216, 45, 123, 69, 142, 55, 196, 193, 92, 63, 254, 56, 59, 117, 183, 128, 48, 119, 232, 237, 205, 36, 84, 71, 49, 229, 96, 124, 65, 165 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 206, 122, 75, 127, 131, 83, 23, 169, 165, 206, 61, 15, 213, 5, 154, 194, 143, 42, 24, 94, 130, 94, 46, 59, 173, 160, 86, 162, 18, 254, 73, 115, 112, 245, 33, 135, 187, 133, 228, 175, 227, 91, 98, 143, 187, 226, 155, 120, 238, 152, 250, 123, 188, 24, 252, 52, 115, 64, 115, 65, 55, 77, 118, 34 }, new byte[] { 114, 63, 253, 247, 96, 193, 6, 69, 206, 197, 146, 44, 197, 210, 228, 171, 151, 201, 206, 50, 6, 48, 128, 98, 155, 135, 167, 97, 116, 75, 226, 178, 112, 79, 27, 22, 60, 229, 53, 197, 125, 211, 172, 237, 26, 240, 138, 12, 87, 105, 80, 101, 168, 71, 226, 209, 130, 81, 61, 89, 43, 250, 19, 234, 229, 196, 148, 118, 218, 105, 114, 202, 33, 241, 13, 80, 180, 249, 61, 241, 151, 101, 237, 32, 36, 238, 104, 102, 253, 153, 247, 5, 224, 200, 169, 40, 51, 33, 72, 188, 127, 112, 157, 11, 207, 110, 128, 1, 181, 250, 43, 143, 122, 145, 95, 181, 89, 10, 133, 6, 230, 79, 139, 90, 140, 212, 168, 50 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 140, 87, 202, 62, 182, 134, 198, 24, 17, 240, 250, 186, 75, 104, 55, 79, 228, 95, 144, 239, 238, 67, 121, 168, 48, 132, 61, 150, 125, 239, 117, 241, 242, 14, 188, 232, 240, 179, 89, 240, 52, 190, 17, 234, 102, 76, 55, 246, 157, 21, 108, 119, 20, 141, 87, 47, 96, 72, 78, 174, 92, 217, 68 }, new byte[] { 177, 105, 208, 253, 81, 247, 39, 249, 120, 206, 143, 62, 86, 180, 48, 124, 59, 74, 244, 232, 211, 16, 121, 175, 30, 170, 189, 78, 58, 26, 202, 81, 255, 85, 90, 20, 26, 85, 239, 223, 114, 56, 225, 132, 231, 171, 39, 15, 77, 18, 72, 219, 110, 100, 18, 15, 207, 115, 137, 32, 29, 55, 208, 44, 169, 144, 139, 234, 142, 236, 163, 195, 231, 121, 63, 80, 138, 51, 45, 87, 162, 39, 81, 89, 201, 86, 58, 63, 244, 136, 107, 205, 119, 250, 82, 215, 90, 34, 80, 216, 19, 189, 88, 44, 182, 20, 46, 225, 9, 8, 237, 225, 180, 70, 248, 61, 14, 76, 175, 154, 196, 97, 6, 123, 9, 102, 248, 72 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 76, 138, 16, 230, 161, 115, 167, 254, 150, 253, 79, 106, 234, 251, 200, 235, 16, 161, 173, 223, 136, 68, 247, 56, 69, 162, 124, 239, 230, 117, 90, 131, 163, 108, 203, 131, 212, 94, 49, 97, 191, 40, 47, 234, 1, 184, 11, 43, 73, 199, 128, 128, 14, 4, 224, 161, 177, 73, 63, 168, 76, 181, 29 }, new byte[] { 130, 28, 79, 115, 79, 19, 156, 150, 198, 159, 91, 220, 162, 133, 95, 241, 152, 152, 42, 28, 208, 35, 170, 228, 103, 194, 215, 215, 48, 12, 80, 45, 76, 200, 211, 27, 61, 42, 234, 62, 93, 109, 118, 200, 231, 173, 185, 160, 1, 207, 142, 35, 167, 26, 43, 248, 17, 35, 96, 51, 129, 155, 132, 182, 46, 101, 183, 222, 243, 221, 111, 71, 74, 20, 184, 116, 177, 200, 24, 241, 232, 102, 38, 22, 25, 92, 41, 21, 234, 37, 51, 25, 19, 39, 36, 140, 103, 237, 180, 178, 234, 190, 171, 203, 51, 4, 55, 214, 4, 14, 96, 42, 117, 250, 229, 139, 111, 175, 42, 61, 188, 121, 238, 195, 40, 40, 27, 54 } });
        }
    }
}
