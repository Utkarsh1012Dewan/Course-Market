USE [courseMarketDb]
GO

-- Turn IDENTITY_INSERT ON for Project table

-- Original CREATE TABLE statements remain unchanged
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
    [Id] [nvarchar](250) NOT NULL,
    [Name] [nvarchar](max) NOT NULL,
    [Author] [nvarchar](max) NOT NULL,
    [Category] [nvarchar](max) NOT NULL,
    [Thumbnail] [nvarchar](max) NOT NULL,
    [Videos] [nvarchar](max) NOT NULL,
    [Description] [nvarchar](max) NOT NULL,
    [createTime] [datetime2](7) NOT NULL,
    [updateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-- User table creation remains unchanged
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
    [Id] [nvarchar](250) NOT NULL,
    [Firstname] [nvarchar](max) NOT NULL,
    [Lastname] [nvarchar](max) NOT NULL,
    [Username] [nvarchar](max) NOT NULL,
    [Age] [nvarchar](max) NOT NULL,
    [EmailAddress] [nvarchar](max) NOT NULL,
    [Profession] [nvarchar](max) NOT NULL,
    [createTime] [datetime2](7) NOT NULL,
    [updateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
