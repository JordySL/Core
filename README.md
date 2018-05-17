# Core
Select ul.Username,ul.Password,
	   up.Nombres,up.Apellidos,up.Direccion,
	   ur.IDRoleName
from UserLogin ul, UserProfile up, UserRole ur
Where ul.ID=up.ID and up.ID = ur.ID

# *Procedimiento Almacenado*
CREATE PROCEDURE [dbo].[AutenticacionUser]
	@username  varchar(100),
	@password varchar(100)
AS
	Select ul.Username,ul.Password,
		up.Nombres,up.Apellidos,up.Direccion,
		ur.IDRoleName, ur.IDRole
		from UserLogin ul, UserProfile up, UserRole ur
		Where ul.ID=up.ID and up.ID = ur.ID and 
		ul.Username = @username and ul.Password = @password
RETURN 0

# --*Tablas*
CREATE TABLE [dbo].[UserLogin] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (100) NULL,
    [Password] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

# --*Tablas*
CREATE TABLE [dbo].[UserProfile] (
    [ID]        INT           IDENTITY (1, 1) NOT NULL,
    [Nombres]   VARCHAR (100) NULL,
    [Apellidos] VARCHAR (100) NULL,
    [Direccion] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

# --*Tablas*
CREATE TABLE [dbo].[UserRole] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [IDRole]     INT           NULL,
    [IDRoleName] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
