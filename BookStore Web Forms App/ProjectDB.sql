/****** Object:  ForeignKey [FK_City_Country]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_City_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[City]'))
ALTER TABLE [dbo].[City] DROP CONSTRAINT [FK_City_Country]
GO
/****** Object:  StoredProcedure [dbo].[SPDelAuthor]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPDelAuthor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPDelAuthor]
GO
/****** Object:  StoredProcedure [dbo].[SPDelBook]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPDelBook]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPDelBook]
GO
/****** Object:  StoredProcedure [dbo].[SPDelQuotation]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPDelQuotation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPDelQuotation]
GO
/****** Object:  StoredProcedure [dbo].[SpDelTopic]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpDelTopic]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpDelTopic]
GO
/****** Object:  StoredProcedure [dbo].[SPInsertAuthor]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertAuthor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPInsertAuthor]
GO
/****** Object:  StoredProcedure [dbo].[SPInsertBook]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertBook]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPInsertBook]
GO
/****** Object:  StoredProcedure [dbo].[SPInsertQuotation]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertQuotation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPInsertQuotation]
GO
/****** Object:  StoredProcedure [dbo].[SPInsertTopic]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertTopic]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPInsertTopic]
GO
/****** Object:  StoredProcedure [dbo].[SPPptTitleByAuthor]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPPptTitleByAuthor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPPptTitleByAuthor]
GO
/****** Object:  StoredProcedure [dbo].[SPRptAllAuthors]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPRptAllAuthors]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPRptAllAuthors]
GO
/****** Object:  StoredProcedure [dbo].[SPRptQuoteByAuthor]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPRptQuoteByAuthor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPRptQuoteByAuthor]
GO
/****** Object:  StoredProcedure [dbo].[SPRptTitleByTopic]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPRptTitleByTopic]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPRptTitleByTopic]
GO
/****** Object:  StoredProcedure [dbo].[SpTopicUpdate]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpTopicUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpTopicUpdate]
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateAuthor]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPUpdateAuthor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPUpdateAuthor]
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateBook]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPUpdateBook]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPUpdateBook]
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateQuotation]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPUpdateQuotation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPUpdateQuotation]
GO
/****** Object:  StoredProcedure [dbo].[InsertTopic]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTopic]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertTopic]
GO
/****** Object:  StoredProcedure [dbo].[ViewAuthor]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewAuthor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ViewAuthor]
GO
/****** Object:  StoredProcedure [dbo].[ViewBooks]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewBooks]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ViewBooks]
GO
/****** Object:  StoredProcedure [dbo].[ViewQuotations]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewQuotations]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ViewQuotations]
GO
/****** Object:  StoredProcedure [dbo].[ViewRegisteredUsers]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewRegisteredUsers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ViewRegisteredUsers]
GO
/****** Object:  StoredProcedure [dbo].[ViewTopic]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewTopic]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ViewTopic]
GO
/****** Object:  Table [dbo].[City]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
DROP TABLE [dbo].[City]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
DROP TABLE [dbo].[Country]
GO
/****** Object:  Table [dbo].[Quotations]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Quotations]') AND type in (N'U'))
DROP TABLE [dbo].[Quotations]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Registration]') AND type in (N'U'))
DROP TABLE [dbo].[Registration]
GO
/****** Object:  Table [dbo].[Topic]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Topic]') AND type in (N'U'))
DROP TABLE [dbo].[Topic]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 12/30/2012 20:26:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Authors]') AND type in (N'U'))
DROP TABLE [dbo].[Authors]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 12/30/2012 20:26:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Books]') AND type in (N'U'))
DROP TABLE [dbo].[Books]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Books]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[Tittle] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Topic] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[PublisherName] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[CoverType] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Notes] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[PurchasedPrice] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Author] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[EditionNumber] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[CopyrightYear] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[DatePurchased] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Pages] [int] NOT NULL,
	[ShelfNumber] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Books] ON
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (10, N'Requirement Engineering', N'6', N'Wrox Press', N'Hard', N'Good Requirement Engineering Book', N'Rs.2500', N'2', N'4', N'2012', N'3-12-2012', 400, N'1')
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (11, N'Web Game Programming', N'16', N'Wox Press', N'hard', N'Good Game Programming Book', N'Rs1500', N'5', N'3', N'2011', N'2-11-2012', 525, N'2')
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (12, N'Software Engineering', N'6', N'APress', N'Soft', N'Introduction to Software Development', N'500Rs', N'4', N'9', N'2011', N'4-5-2012', 400, N'5')
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (13, N'Advanced Software Development', N'6', N'Dean John Press', N'Hard', N'Advanced Software Engineering', N'75$', N'2', N'1', N'2009', N'2-3-2011', 550, N'6')
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (14, N'Game Progrmming in c++', N'16', N'McGraw Hill', N'Soft', N'C++ Enhance Game Programming World', N'Rs2400', N'5', N'3', N'2012', N'22-5-2010', 480, N'15')
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (15, N'Islam and Science', N'18', N'ShahG Publications', N'Soft', N'Islam and Science', N'RS.2100', N'3', N'1', N'1998', N'5-5-2005', 500, N'2')
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (16, N'J2EE Complete Reference', N'20', N'McGill Press', N'Hard', N'Java Book', N'1500Rs', N'8', N'4', N'2011', N'24-12-2010', 550, N'5')
INSERT [dbo].[Books] ([BookID], [Tittle], [Topic], [PublisherName], [CoverType], [Notes], [PurchasedPrice], [Author], [EditionNumber], [CopyrightYear], [DatePurchased], [Pages], [ShelfNumber]) VALUES (17, N'Islam: Guide to Living', N'18', N'Qadri Publications,India', N'Hard', N'Islam Guide How to Live', N'1500Rs', N'3', N'1', N'2012', N'21-12-2012', 675, N'5')
SET IDENTITY_INSERT [dbo].[Books] OFF
/****** Object:  Table [dbo].[Authors]    Script Date: 12/30/2012 20:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Authors]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[LastName] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Nationality] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[BirthDate] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[BirthPlace] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[TrainingLocation] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[MajorInfluences] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Notes] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Authors] ON
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (1, N'jamal', N'ahmed', N'Pakistan', N'12-11-1987', N'Muree', N'IIUI', N'Programming', N'Expert Web Developer')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (2, N'Robert John', N'Lafore', N'American', N'23-8-1960', N'Los Angles', N'Oxford University', N'Programming', N'Author of many Programming Language Books')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (3, N'Manzoor', N'Khan', N'Indian', N'3-2-1974', N'Mumbai', N'University of Mumbai', N'.Net Developer', N'Software Manager')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (4, N'Jaffery', N'Hoffer', N'British', N'2-3-1968', N'London', N'Cambridge', N'Data Base Management Systems', N'Author of many Books on DBMS')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (5, N' Shahid', N'Mehmmod', N'Pakistan', N'2-2-1964', N'Lahore', N'UET Lahore', N'OOP in Java', N'Associate Professor in UET Lahore')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (6, N'shoaib', N'ahmed', N'Indian', N'2-8-1982', N'Dehli', N'Dehli College', N'Software Engineering', N'Lecturer in Dehli College')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (8, N'Deitel', N'Paul Deitel', N'American', N'5-9-1968', N'New york', N'State University', N'Programming in Different Languages', N'Author of How to Program  Programming Books Series')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Nationality], [BirthDate], [BirthPlace], [TrainingLocation], [MajorInfluences], [Notes]) VALUES (10, N'Shah Zaman', N'Johnson', N'British', N'13-11-1972', N'London', N'Surrey University', N'Data Mining', N'Data Base Administrator')
SET IDENTITY_INSERT [dbo].[Authors] OFF
/****** Object:  Table [dbo].[Topic]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Topic]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Topic](
	[TopicID] [int] IDENTITY(1,1) NOT NULL,
	[Topic] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
 CONSTRAINT [PK_Topic] PRIMARY KEY CLUSTERED 
(
	[TopicID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Topic] ON
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (1, N'Software Development Technologies')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (5, N'Software Project Management')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (6, N'Software Enginnering')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (16, N'Game Programming')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (17, N'Enterprise System Engineering')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (18, N'Islam and Science')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (19, N'Computer Graphics')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (20, N'Programming')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (21, N'Operating Systems')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (23, N'Quran and Hadith Books')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (24, N'Computer Architecture')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (25, N'Science of Arts')
INSERT [dbo].[Topic] ([TopicID], [Topic]) VALUES (26, N'Internet The World Wide Web')
SET IDENTITY_INSERT [dbo].[Topic] OFF
/****** Object:  Table [dbo].[Registration]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Registration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Registration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [char](50) COLLATE Arabic_CI_AS NOT NULL,
	[Gender] [char](50) COLLATE Arabic_CI_AS NOT NULL,
	[BirthDay] [date] NOT NULL,
	[Country] [char](50) COLLATE Arabic_CI_AS NOT NULL,
	[Language] [char](50) COLLATE Arabic_CI_AS NOT NULL,
	[Email] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Password] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[AlternateEmail] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[SecretQuestion] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[YourAnswer] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Registration] ON
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (1, N'abdul bari                                        ', N'Male                                              ', CAST(0xE3150B00 AS Date), N'1                                                 ', N'Urdu                                              ', N'ABMmadni@gmail.com', N'1234', N'abc@ymail.com', N'What is your Phone Number?', N'1234')
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (2, N'jamal                                             ', N'Male                                              ', CAST(0x9B110B00 AS Date), N'2                                                 ', N'English                                           ', N'jamal@gmail.com', N'12345', N'jimmy@ymail.com', N'What is your PC Password?', N'12345')
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (3, N'shah shams                                        ', N'Male                                              ', CAST(0xE3150B00 AS Date), N'3                                                 ', N'Select One                                        ', N'shahg@gmail.com', N'shah', N'shah@ymail.com', N'What is your best Friend Name?', N'shah')
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (4, N'student                                           ', N'Male                                              ', CAST(0x6B170B00 AS Date), N'1                                                 ', N'Select One                                        ', N'student@iiu.edu.pk', N'iiui', N'student@gmail.com', N'What is your PC Password?', N'iiui')
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (5, N'ali                                               ', N'Male                                              ', CAST(0xBE180B00 AS Date), N'3                                                 ', N'English                                           ', N'alig@ymail.com', N'0000', N'ali@gmail.com', N'What is your PC Password?', N'0000')
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (6, N'john                                              ', N'Male                                              ', CAST(0x78F90A00 AS Date), N'5                                                 ', N'English                                           ', N'john@yahoo.com', N'1970', N'john@live.com', N'What is your PC Password?', N'1970')
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (7, N'abdul baqi                                        ', N'Male                                              ', CAST(0x7B200B00 AS Date), N'1                                                 ', N'Urdu                                              ', N'abdulbaqi@gmail.com', N'123456', N'abdulbaqi@yahoo.com', N'What is your Phone Number?', N'123456')
INSERT [dbo].[Registration] ([ID], [Name], [Gender], [BirthDay], [Country], [Language], [Email], [Password], [AlternateEmail], [SecretQuestion], [YourAnswer]) VALUES (8, N'shahg                                             ', N'Male                                              ', CAST(0x6A210B00 AS Date), N'2                                                 ', N'Urdu                                              ', N'shahg@ymail.com', N'12345', N'shahg@ymail.com', N'What is your Phone Number?', N'12345')
SET IDENTITY_INSERT [dbo].[Registration] OFF
/****** Object:  Table [dbo].[Quotations]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Quotations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Quotations](
	[QuoteID] [int] IDENTITY(1,1) NOT NULL,
	[Book] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Author] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[PageNumber] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Quote] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
 CONSTRAINT [PK_Quotations] PRIMARY KEY CLUSTERED 
(
	[QuoteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Quotations] ON
INSERT [dbo].[Quotations] ([QuoteID], [Book], [Author], [PageNumber], [Quote]) VALUES (7, N'6', N'1', N'3', N'ASP.Net')
INSERT [dbo].[Quotations] ([QuoteID], [Book], [Author], [PageNumber], [Quote]) VALUES (8, N'10', N'6', N'6', N'Requirement Elicitation')
INSERT [dbo].[Quotations] ([QuoteID], [Book], [Author], [PageNumber], [Quote]) VALUES (9, N'15', N'5', N'2', N'Islam is the Complete Code of Life.... and give hu')
SET IDENTITY_INSERT [dbo].[Quotations] OFF
/****** Object:  Table [dbo].[Country]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Country](
	[CID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Country] ON
INSERT [dbo].[Country] ([CID], [CountryName]) VALUES (1, N'Pakistan')
INSERT [dbo].[Country] ([CID], [CountryName]) VALUES (2, N'India')
INSERT [dbo].[Country] ([CID], [CountryName]) VALUES (3, N'UK')
INSERT [dbo].[Country] ([CID], [CountryName]) VALUES (4, N'USA')
INSERT [dbo].[Country] ([CID], [CountryName]) VALUES (5, N'Australia')
INSERT [dbo].[Country] ([CID], [CountryName]) VALUES (6, N'Srilanka')
SET IDENTITY_INSERT [dbo].[Country] OFF
/****** Object:  Table [dbo].[City]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CountryID] [int] NOT NULL,
	[CityName] [varchar](50) COLLATE Arabic_CI_AS NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[City] ON
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (1, 1, N'Islamabad')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (2, 1, N'Lahore')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (7, 1, N'Karachi')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (8, 1, N'Peshawar')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (9, 1, N'Quetta')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (10, 2, N'Mumbai')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (11, 2, N'Dehli')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (12, 2, N'Madras')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (13, 3, N'London')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (14, 3, N'Barminghum')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (15, 3, N'Manchestar')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (16, 4, N'Los Angles')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (17, 4, N'Washington D.C')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (18, 5, N'Sydney')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (19, 5, N'Brisbane')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (20, 5, N'Perth')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (21, 5, N'Melbourne')
INSERT [dbo].[City] ([CityID], [CountryID], [CityName]) VALUES (22, 6, N'Colombo')
SET IDENTITY_INSERT [dbo].[City] OFF
/****** Object:  StoredProcedure [dbo].[ViewTopic]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewTopic]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[ViewTopic]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Topic; 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ViewRegisteredUsers]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewRegisteredUsers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[ViewRegisteredUsers] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Registration;
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[ViewQuotations]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewQuotations]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[ViewQuotations]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Quotations;
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ViewBooks]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewBooks]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE[dbo].[ViewBooks]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Books;
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ViewAuthor]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewAuthor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[ViewAuthor]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Authors;
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTopic]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTopic]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[InsertTopic](@name varchar(50)) 
	-- Add the parameters for the stored procedure here
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Topic ([Topic]) values(@name)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateQuotation]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPUpdateQuotation]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- ================================================

CREATE PROCEDURE[dbo].[SPUpdateQuotation]
	@qtid int,
    @book varchar(50),
    @author varchar(50),
    @pno varchar(50),
    @quote varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Quotations set [Book]=@book,[Author]=@author,[PageNumber]=@pno,[Quote]=@quote 
	where [QuoteID]=@qtid
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateBook]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPUpdateBook]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPUpdateBook]
	@bid int,
	@title varchar(50),
      @topic varchar(50),
      @pname varchar(50),
      @ctype varchar(50),
      @notes varchar(50),
      @pprice varchar(50),
      @author varchar(50),
      @enum  varchar(50),
      @cyear varchar(50),
      @dpur  varchar(50),
      @page  varchar(50),
      @sno   varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Books set [Tittle]=@title,[Topic]=@topic,[PublisherName]=@pname,
	[CoverType]=@ctype,[Notes]=@notes,[PurchasedPrice]=@pprice,[Author]=@author,
	[EditionNumber]=@enum,[CopyrightYear]=@cyear,[DatePurchased]=@dpur,
	[Pages]=@page,[ShelfNumber]=@sno
	where [BookID]=@bid
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateAuthor]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPUpdateAuthor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPUpdateAuthor]
      @aid int,
	 @fname varchar(50),
	 @lname varchar(50),
	 @nat varchar(50),
	 @bdate varchar (50),
	 @bplace varchar(50),
	 @tloc varchar(50),
	 @minf varchar(50),
	 @notes varchar (50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Authors set [FirstName]=@fname,[LastName]=@lname,[Nationality]=@nat,
    [BirthDate]=@bdate,[BirthPlace]=@bplace,[TrainingLocation]=@tloc,[MajorInfluences]=@minf,
    [Notes]=@notes

where [AuthorID]=@aid
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpTopicUpdate]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpTopicUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SpTopicUpdate](@id as int,@name as varchar(50)) 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Topic set [Topic]=@name where [TopicID]=@id

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPRptTitleByTopic]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPRptTitleByTopic]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPRptTitleByTopic]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select Topic.Topic,Books.Tittle,Authors.FirstName,Books.PublisherName
From  Topic,Books,Authors
Where
Books.Topic=Topic.TopicID
AND
Books.Author=Authors.AuthorID
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPRptQuoteByAuthor]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPRptQuoteByAuthor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPRptQuoteByAuthor] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select Authors.FirstName,
Quotations.Quote, Quotations.PageNumber,Books.Tittle
From Authors,Books,Quotations
Where
Quotations.Author = Authors.AuthorID
AND
Quotations.Book = Books.BookID
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPRptAllAuthors]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPRptAllAuthors]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SPRptAllAuthors]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * From Authors
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPPptTitleByAuthor]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPPptTitleByAuthor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPPptTitleByAuthor]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select Authors.FirstName,
Books.Tittle,Books.PublisherName,Books.PurchasedPrice,Books.DatePurchased
From Authors,Books
Where
Books.Author = Authors.AuthorID
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPInsertTopic]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertTopic]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPInsertTopic] (@name varchar(50))
AS
	-- Add the parameters for the stored procedure here
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 insert into Topic ([Topic]) values(@name)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPInsertQuotation]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertQuotation]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPInsertQuotation]
   
    @book varchar(50),
    @author varchar(50),
    @pno varchar(50),
    @quote varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Quotations([Book],[Author],[PageNumber],[Quote]) 
	values(@book,@author,@pno,@quote)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPInsertBook]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertBook]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPInsertBook]
     
     @title varchar(50),
      @topic varchar(50),
      @pname varchar(50),
      @ctype varchar(50),
      @notes varchar(50),
      @pprice varchar(50),
      @author varchar(50),
      @enum  varchar(50),
      @cyear varchar(50),
      @dpur  varchar(50),
      @page  varchar(50),
      @sno   varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Books(Tittle,Topic,PublisherName,CoverType,Notes,PurchasedPrice,Author,EditionNumber,
 CopyrightYear,DatePurchased,Pages,ShelfNumber) values(@title,@topic,@pname,@ctype,
 @notes,@pprice,@author,@enum,@cyear,@dpur,@page,@sno)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPInsertAuthor]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPInsertAuthor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPInsertAuthor]
	 
	 @fname varchar(50),
	 @lname varchar(50),
	 @nat varchar(50),
	 @bdate varchar (50),
	 @bplace varchar(50),
	 @tloc varchar(50),
	 @minf varchar(50),
	 @notes varchar (50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 insert into Authors(FirstName,LastName,Nationality,BirthDate,BirthPlace
   ,TrainingLocation,MajorInfluences,Notes)values (@fname,@lname,@nat,@bdate,@bplace,@tloc,@minf,@notes)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpDelTopic]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpDelTopic]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SpDelTopic](@id as int) 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Topic where TopicID=@id
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPDelQuotation]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPDelQuotation]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPDelQuotation]
      @qtid as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Quotations where QuoteID=@qtid 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPDelBook]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPDelBook]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPDelBook]
	@bid as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Books where BookID=@bid

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SPDelAuthor]    Script Date: 12/30/2012 20:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPDelAuthor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SPDelAuthor]
  ( @aid as int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Authors where AuthorID=@aid
END
' 
END
GO
/****** Object:  ForeignKey [FK_City_Country]    Script Date: 12/30/2012 20:26:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_City_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[City]'))
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([CID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_City_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[City]'))
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Country]
GO
