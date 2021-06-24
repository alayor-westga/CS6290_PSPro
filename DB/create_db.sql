/****** Object:  Table [dbo].[Administrators]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Complaints]
DROP TABLE [dbo].[Citizens]
DROP TABLE [dbo].[Investigators] 
DROP TABLE [dbo].[Supervisors] 
DROP TABLE [dbo].[Officers] 
DROP TABLE [dbo].[Administrators] 
DROP TABLE [dbo].[Personnel] 

CREATE TABLE [dbo].[Administrators](
	[personnel_id] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Administrators_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citizens]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizens](
	[citizen_id] [int] IDENTITY(5000,1) NOT NULL,
	[first_name] [varchar](45) NOT NULL,
	[last_name] [varchar](45) NOT NULL,
	[address1] [varchar](45) NOT NULL,
	[address2] [varchar](45) NULL,
	[city] [varchar](45) NOT NULL,
	[state] [char](2) NOT NULL,
	[zipcode] [varchar](10) NOT NULL,
	[phone] [varchar](14) NOT NULL,
	[email] [varchar](45) NULL,
 CONSTRAINT [PK_Citizens] PRIMARY KEY CLUSTERED 
(
	[citizen_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Citizens_phone] UNIQUE NONCLUSTERED 
(
	[phone] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Complaints]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Complaints](
	[complaint_id] [int] IDENTITY(1,1) NOT NULL,
	[citizen_id] [int] NOT NULL,
	[officers_personnel_id] [int] NOT NULL,
	[supervisors_personnel_id] [int] NOT NULL,
	[investigators_personnel_id] [int] NULL,
	[administrators_personnel_id] [int] NULL,
	[date_created] [datetime] NOT NULL,
	[allegation_type] [varchar](45) NOT NULL,
	[complaint_notes] [text] NOT NULL,
	[disposition] [varchar](25) NULL,
	[disposition_date] [date] NULL,
	[discipline] [varchar](45) NULL,
 CONSTRAINT [PK_Complaints] PRIMARY KEY CLUSTERED 
(
	[complaint_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Investigators]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investigators](
	[personnel_id] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Investigators] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Investigators_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Officers]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Officers](
	[personnel_id] [int] NOT NULL,
 CONSTRAINT [PK_Officers] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnel]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnel](
	[personnel_id] [int] IDENTITY(1000,1) NOT NULL,
	[first_name] [varchar](45) NOT NULL,
	[last_name] [varchar](45) NOT NULL,
	[gender] [char](1) NOT NULL,
	[hire_date] [date] NOT NULL,
	[birthdate] [date] NOT NULL,
	[assignment] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Personnel] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supervisors]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supervisors](
	[personnel_id] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Supervisors] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Supervisors_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 6/18/2021 10:15:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [sysname] NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_principal_name] UNIQUE NONCLUSTERED 
(
	[principal_id] ASC,
	[name] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_Administrators_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_Administrators_Personnel]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Administrators] FOREIGN KEY([administrators_personnel_id])
REFERENCES [dbo].[Administrators] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Administrators]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Citizens] FOREIGN KEY([citizen_id])
REFERENCES [dbo].[Citizens] ([citizen_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Citizens]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Investigators] FOREIGN KEY([investigators_personnel_id])
REFERENCES [dbo].[Investigators] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Investigators]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Officers] FOREIGN KEY([officers_personnel_id])
REFERENCES [dbo].[Officers] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Officers]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Supervisors] FOREIGN KEY([supervisors_personnel_id])
REFERENCES [dbo].[Supervisors] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Supervisors]
GO
ALTER TABLE [dbo].[Investigators]  WITH CHECK ADD  CONSTRAINT [FK_Investigators_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Investigators] CHECK CONSTRAINT [FK_Investigators_Personnel]
GO
ALTER TABLE [dbo].[Officers]  WITH CHECK ADD  CONSTRAINT [FK_Officers_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Officers] CHECK CONSTRAINT [FK_Officers_Personnel]
GO
ALTER TABLE [dbo].[Supervisors]  WITH CHECK ADD  CONSTRAINT [FK_Supervisors_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Supervisors] CHECK CONSTRAINT [FK_Supervisors_Personnel]
GO
EXEC sys.sp_addextendedproperty @name=N'microsoft_database_tools_support', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sysdiagrams'
GO

