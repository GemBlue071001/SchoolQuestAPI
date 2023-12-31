USE [master]
GO
/****** Object:  Database [HighSchoolQuest]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE DATABASE [HighSchoolQuest]
GO
ALTER DATABASE [HighSchoolQuest] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HighSchoolQuest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HighSchoolQuest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET ARITHABORT OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HighSchoolQuest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HighSchoolQuest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HighSchoolQuest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HighSchoolQuest] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [HighSchoolQuest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET RECOVERY FULL 
GO
ALTER DATABASE [HighSchoolQuest] SET  MULTI_USER 
GO
ALTER DATABASE [HighSchoolQuest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HighSchoolQuest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HighSchoolQuest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HighSchoolQuest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HighSchoolQuest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HighSchoolQuest] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HighSchoolQuest', N'ON'
GO
ALTER DATABASE [HighSchoolQuest] SET QUERY_STORE = OFF
GO
USE [HighSchoolQuest]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttemptDetails]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttemptDetails](
	[AttemptId] [uniqueidentifier] NOT NULL,
	[ExaminationQuestionId] [uniqueidentifier] NOT NULL,
	[IsCorrect] [bit] NOT NULL,
	[UserAnswered] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AttemptDetails] PRIMARY KEY CLUSTERED 
(
	[AttemptId] ASC,
	[ExaminationQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attempts]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attempts](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
	[AttempType] [int] NOT NULL,
	[ExamDate] [datetime2](7) NOT NULL,
	[Score] [int] NULL,
	[Result] [nvarchar](max) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Attempts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[RequiredScore] [real] NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExaminationQuestions]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExaminationQuestions](
	[Id] [uniqueidentifier] NOT NULL,
	[ExaminationId] [uniqueidentifier] NOT NULL,
	[QuestionId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_ExaminationQuestions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examinations]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinations](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[TotalNumberOfQuestion] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Examinations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupDepartments]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupDepartments](
	[DepartmentId] [uniqueidentifier] NOT NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_GroupDepartments] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[Id] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Major]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Major](
	[Id] [uniqueidentifier] NOT NULL,
	[MajorName] [nvarchar](max) NOT NULL,
	[DepartmentId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Major] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MBTI]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MBTI](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MBTI] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MBTI_Department]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MBTI_Department](
	[MBTI_Id] [int] NOT NULL,
	[DepartmentId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_MBTI_Department] PRIMARY KEY CLUSTERED 
(
	[MBTI_Id] ASC,
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Id] [uniqueidentifier] NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[TopicId] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectGroup]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectGroup](
	[SubjectId] [uniqueidentifier] NOT NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SubjectGroup] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topics]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topics](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Index] [int] NOT NULL,
	[SubjectId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[University]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[University](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_University] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UniversityDepartments]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UniversityDepartments](
	[Id] [uniqueidentifier] NOT NULL,
	[UniversityId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
	[DepartmentId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UniversityDepartments] PRIMARY KEY CLUSTERED 
(
	[UniversityId] ASC,
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/28/2023 6:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[PasswordHash] [varbinary](max) NOT NULL,
	[PasswordSalt] [varbinary](max) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Role] [int] NOT NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsFirstLogin] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_AttemptDetails_ExaminationQuestionId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttemptDetails_ExaminationQuestionId] ON [dbo].[AttemptDetails]
(
	[ExaminationQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Attempts_UserId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_Attempts_UserId] ON [dbo].[Attempts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExaminationQuestions_ExaminationId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_ExaminationQuestions_ExaminationId] ON [dbo].[ExaminationQuestions]
(
	[ExaminationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExaminationQuestions_QuestionId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_ExaminationQuestions_QuestionId] ON [dbo].[ExaminationQuestions]
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GroupDepartments_GroupId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_GroupDepartments_GroupId] ON [dbo].[GroupDepartments]
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Major_DepartmentId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_Major_DepartmentId] ON [dbo].[Major]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_MBTI_Department_DepartmentId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_MBTI_Department_DepartmentId] ON [dbo].[MBTI_Department]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Questions_TopicId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_Questions_TopicId] ON [dbo].[Questions]
(
	[TopicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SubjectGroup_GroupId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_SubjectGroup_GroupId] ON [dbo].[SubjectGroup]
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Topics_SubjectId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_Topics_SubjectId] ON [dbo].[Topics]
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UniversityDepartments_DepartmentId]    Script Date: 10/28/2023 6:05:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_UniversityDepartments_DepartmentId] ON [dbo].[UniversityDepartments]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AttemptDetails] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsCorrect]
GO
ALTER TABLE [dbo].[AttemptDetails] ADD  DEFAULT (N'') FOR [UserAnswered]
GO
ALTER TABLE [dbo].[Attempts] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Attempts] ADD  DEFAULT ((0)) FOR [AttempType]
GO
ALTER TABLE [dbo].[Attempts] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ExamDate]
GO
ALTER TABLE [dbo].[Attempts] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [UserId]
GO
ALTER TABLE [dbo].[ExaminationQuestions] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Examinations] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Groups] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Major] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Major] ADD  DEFAULT (N'') FOR [Code]
GO
ALTER TABLE [dbo].[Major] ADD  DEFAULT (N'') FOR [Description]
GO
ALTER TABLE [dbo].[Questions] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Subjects] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Topics] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[University] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[University] ADD  DEFAULT (N'') FOR [Code]
GO
ALTER TABLE [dbo].[University] ADD  DEFAULT (N'') FOR [Description]
GO
ALTER TABLE [dbo].[UniversityDepartments] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[UniversityDepartments] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [DepartmentId]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[AttemptDetails]  WITH CHECK ADD  CONSTRAINT [FK_AttemptDetails_Attempts_AttemptId] FOREIGN KEY([AttemptId])
REFERENCES [dbo].[Attempts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttemptDetails] CHECK CONSTRAINT [FK_AttemptDetails_Attempts_AttemptId]
GO
ALTER TABLE [dbo].[AttemptDetails]  WITH CHECK ADD  CONSTRAINT [FK_AttemptDetails_ExaminationQuestions_ExaminationQuestionId] FOREIGN KEY([ExaminationQuestionId])
REFERENCES [dbo].[ExaminationQuestions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttemptDetails] CHECK CONSTRAINT [FK_AttemptDetails_ExaminationQuestions_ExaminationQuestionId]
GO
ALTER TABLE [dbo].[Attempts]  WITH CHECK ADD  CONSTRAINT [FK_Attempts_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attempts] CHECK CONSTRAINT [FK_Attempts_Users_UserId]
GO
ALTER TABLE [dbo].[ExaminationQuestions]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationQuestions_Examinations_ExaminationId] FOREIGN KEY([ExaminationId])
REFERENCES [dbo].[Examinations] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExaminationQuestions] CHECK CONSTRAINT [FK_ExaminationQuestions_Examinations_ExaminationId]
GO
ALTER TABLE [dbo].[ExaminationQuestions]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationQuestions_Questions_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExaminationQuestions] CHECK CONSTRAINT [FK_ExaminationQuestions_Questions_QuestionId]
GO
ALTER TABLE [dbo].[GroupDepartments]  WITH CHECK ADD  CONSTRAINT [FK_GroupDepartments_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupDepartments] CHECK CONSTRAINT [FK_GroupDepartments_Department_DepartmentId]
GO
ALTER TABLE [dbo].[GroupDepartments]  WITH CHECK ADD  CONSTRAINT [FK_GroupDepartments_Groups_GroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupDepartments] CHECK CONSTRAINT [FK_GroupDepartments_Groups_GroupId]
GO
ALTER TABLE [dbo].[Major]  WITH CHECK ADD  CONSTRAINT [FK_Major_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Major] CHECK CONSTRAINT [FK_Major_Department_DepartmentId]
GO
ALTER TABLE [dbo].[MBTI_Department]  WITH CHECK ADD  CONSTRAINT [FK_MBTI_Department_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MBTI_Department] CHECK CONSTRAINT [FK_MBTI_Department_Department_DepartmentId]
GO
ALTER TABLE [dbo].[MBTI_Department]  WITH CHECK ADD  CONSTRAINT [FK_MBTI_Department_MBTI_MBTI_Id] FOREIGN KEY([MBTI_Id])
REFERENCES [dbo].[MBTI] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MBTI_Department] CHECK CONSTRAINT [FK_MBTI_Department_MBTI_MBTI_Id]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Topics_TopicId] FOREIGN KEY([TopicId])
REFERENCES [dbo].[Topics] ([Id])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_Topics_TopicId]
GO
ALTER TABLE [dbo].[SubjectGroup]  WITH CHECK ADD  CONSTRAINT [FK_SubjectGroup_Groups_GroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectGroup] CHECK CONSTRAINT [FK_SubjectGroup_Groups_GroupId]
GO
ALTER TABLE [dbo].[SubjectGroup]  WITH CHECK ADD  CONSTRAINT [FK_SubjectGroup_Subjects_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectGroup] CHECK CONSTRAINT [FK_SubjectGroup_Subjects_SubjectId]
GO
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Subjects_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Subjects_SubjectId]
GO
ALTER TABLE [dbo].[UniversityDepartments]  WITH CHECK ADD  CONSTRAINT [FK_UniversityDepartments_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UniversityDepartments] CHECK CONSTRAINT [FK_UniversityDepartments_Department_DepartmentId]
GO
ALTER TABLE [dbo].[UniversityDepartments]  WITH CHECK ADD  CONSTRAINT [FK_UniversityDepartments_University_UniversityId] FOREIGN KEY([UniversityId])
REFERENCES [dbo].[University] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UniversityDepartments] CHECK CONSTRAINT [FK_UniversityDepartments_University_UniversityId]
GO
USE [master]
GO
ALTER DATABASE [HighSchoolQuest] SET  READ_WRITE 
GO
