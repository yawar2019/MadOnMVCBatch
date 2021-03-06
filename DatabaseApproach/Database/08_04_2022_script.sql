USE [Employee]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](max) NOT NULL,
	[EmpSalary] [int] NOT NULL,
	[DeptID] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (3, N'raghu', 200, 1)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (4, N'john cena', 30044, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (5, N'Dhoni', 400, 2)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (1004, N'devi', 200, 2)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (1005, N'devi2', 500, 3)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (1006, N'Chaitanya', 30000, 2)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (1007, N'Isha G', 290000, 2)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (1008, N'Radhika', 345000, 1)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (2006, N'Shiva', 45000, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (3006, N'Prashanth T Kumar', 780000, 34)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (3007, N'Gautham ', 390000, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (4006, N'OmPrakash', 323333, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (4007, N'shiba  k', 1006, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (4008, N'shiba  r', 100, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (4009, N'raghu g', 200333, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (4010, N'raghud', 2004, NULL)
INSERT [dbo].[Employees] ([Id], [EmpName], [EmpSalary], [DeptID]) VALUES (4011, N'Dhoni n', 4003, NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF
/****** Object:  StoredProcedure [dbo].[sp_CreateEmployee]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE Procedure [dbo].[sp_CreateEmployee]
  @EmpName varchar(50),
  @EmpSalary int
 
  As
  BEGIN
  insert into employeeDetails (EmpName,EmpSalary) values(@EmpName,@EmpSalary)
  
  END
GO
/****** Object:  StoredProcedure [dbo].[sp_employee]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_employee]
As
BEGIN

select EmpId,EmpName,EmpSalary from Employee.dbo.employeeDetails
END
GO
/****** Object:  StoredProcedure [dbo].[spr_deleteEmployeeDetails]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[spr_deleteEmployeeDetails]
  @empid int
  AS
  BEGIN
  Delete from employeeDetails  where empid=@empid
  END
GO
/****** Object:  StoredProcedure [dbo].[spr_insertEmployee]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE procedure [dbo].[spr_insertEmployee]
  @EmpName char(50) ,
  @EmpSalary int
  AS
  BEGIN
  Insert into employeeDetails(empname,empsalary)values(@EmpName,@EmpSalary)
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteEmployeeById]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteEmployeeById]
@EmpId int
AS
BEGIN
Delete from employeeDetails WHERE EmpId=@EmpId
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getEmployeesById]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_getEmployeesById]
@EmpId int
AS
BEGIN
SELECT * from employeeDetails where Empid=@EmpId
END
GO
/****** Object:  StoredProcedure [dbo].[usp_saveEmployee]    Script Date: 08-04-2022 09:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[usp_saveEmployee]
  @EmpName varchar(50),
  @EmpSalary int
As
BEGIN
INSERT INTO employeeDetails(EmpName,EmpSalary) values(@EmpName,@EmpSalary)
END
GO
