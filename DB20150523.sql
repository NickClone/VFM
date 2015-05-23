USE [master]
GO
/****** Object:  Database [Administracion_Sys]    Script Date: 05/23/2015 16:42:17 ******/
CREATE DATABASE [Administracion_Sys] ON  PRIMARY 
( NAME = N'Administracion_Sys', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Administracion_Sys.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Administracion_Sys_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Administracion_Sys_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Administracion_Sys] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Administracion_Sys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Administracion_Sys] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Administracion_Sys] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Administracion_Sys] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Administracion_Sys] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Administracion_Sys] SET ARITHABORT OFF
GO
ALTER DATABASE [Administracion_Sys] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Administracion_Sys] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Administracion_Sys] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Administracion_Sys] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Administracion_Sys] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Administracion_Sys] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Administracion_Sys] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Administracion_Sys] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Administracion_Sys] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Administracion_Sys] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Administracion_Sys] SET  DISABLE_BROKER
GO
ALTER DATABASE [Administracion_Sys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Administracion_Sys] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Administracion_Sys] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Administracion_Sys] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Administracion_Sys] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Administracion_Sys] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Administracion_Sys] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Administracion_Sys] SET  READ_WRITE
GO
ALTER DATABASE [Administracion_Sys] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Administracion_Sys] SET  MULTI_USER
GO
ALTER DATABASE [Administracion_Sys] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Administracion_Sys] SET DB_CHAINING OFF
GO
USE [Administracion_Sys]
GO
/****** Object:  Table [dbo].[vfm_tablas]    Script Date: 05/23/2015 16:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_tablas](
	[tab_id] [int] NULL,
	[tab_cod] [varchar](10) NULL,
	[tab_descrip] [varchar](75) NULL,
	[tab_rel] [int] NULL,
	[estado] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vfm_edif]    Script Date: 05/23/2015 16:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_edif](
	[cod_edif] [int] NOT NULL,
	[edif_calle] [varchar](100) NULL,
	[edif_num] [numeric](18, 0) NULL,
	[edif_cp] [varchar](18) NULL,
	[edif_country] [numeric](4, 0) NULL,
	[edif_prov] [numeric](4, 0) NULL,
	[edif_loc] [numeric](4, 0) NULL,
	[estado] [numeric](4, 0) NULL,
 CONSTRAINT [PK_vfm_edif] PRIMARY KEY CLUSTERED 
(
	[cod_edif] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user_test]    Script Date: 05/23/2015 16:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user_test](
	[id] [int] NULL,
	[name] [varchar](55) NULL,
	[ape] [varchar](55) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sys_usuarios]    Script Date: 05/23/2015 16:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sys_usuarios](
	[cod_usu] [int] NOT NULL,
	[usu_acc] [varchar](75) NOT NULL,
	[usu_pass] [varchar](55) NULL,
	[Nombre] [varchar](75) NULL,
	[Apellido] [varchar](75) NULL,
	[usu_fec_nac] [datetime] NULL,
	[usu_tel] [varchar](max) NULL,
	[sexo] [char](1) NULL,
	[estado] [numeric](18, 0) NULL,
	[fec_alta] [datetime] NOT NULL,
	[fec_modif] [datetime] NULL,
 CONSTRAINT [PK_Sys_usuarios] PRIMARY KEY CLUSTERED 
(
	[cod_usu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Sys_usuarios] UNIQUE NONCLUSTERED 
(
	[usu_acc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[insupdUser]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insupdUser]

	@cod_usu		int,
	@usu_acc		varchar(75),
	@usu_pass		varchar(55),
	@Nombre			varchar(75),
	@Apellido		varchar(75),
	@usu_fec_nac	datetime,
	@usu_tel		varchar(max),
	@sexo			char(1),
	@estado			numeric(18,0),
	@fec_alta		datetime,
	@fec_modif		datetime

as

declare @max_usu  int; 

set @max_usu = (select max(cod_usu)+1 from sys_usuarios) 

If exists(select 1 from sys_usuarios where cod_usu = @cod_usu)
	begin
		update sys_usuarios set      	
			usu_acc		=	@usu_acc,	
			usu_pass	=	@usu_pass,	
			Nombre		=	@Nombre,		
			Apellido	=	@Apellido,	
			usu_fec_nac	=	@usu_fec_nac,
			usu_tel		=	@usu_tel,	
			sexo		=	@sexo,		
			estado		=	@estado,		
			fec_alta	=	@fec_alta,	
			fec_modif	=	getdate()
		where cod_usu   = @cod_usu
		
		select cod_usu from sys_usuarios where cod_usu = @cod_usu
		
	end
else
	begin
		insert into sys_usuarios values 
		(@max_usu,    
		 @usu_acc,	
		 @usu_pass,	
		 @Nombre,	
		 @Apellido,	
		 @usu_fec_nac,
		 @usu_tel,	
		 @sexo,		
		 @estado,	
		 getdate(),	
		 getdate())
		 
		select @max_usu
	end
GO
/****** Object:  Table [dbo].[vfm_encargado]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vfm_encargado](
	[cod_usu] [int] NOT NULL,
	[cod_edif] [int] NOT NULL,
	[enc_sueldo] [numeric](18, 2) NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_vfm_encargado] PRIMARY KEY CLUSTERED 
(
	[cod_usu] ASC,
	[cod_edif] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vfm_amenities]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_amenities](
	[cod_edif] [int] NOT NULL,
	[cod_amenity] [int] NOT NULL,
	[amen_descrip] [varchar](100) NULL,
 CONSTRAINT [PK_vfm_amenities] PRIMARY KEY CLUSTERED 
(
	[cod_edif] ASC,
	[cod_amenity] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vfm_departamento]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_departamento](
	[cod_edif] [int] NOT NULL,
	[dpto_piso] [int] NOT NULL,
	[dpto_dpto] [varchar](30) NOT NULL,
 CONSTRAINT [PK_vfm_departamento] PRIMARY KEY CLUSTERED 
(
	[cod_edif] ASC,
	[dpto_piso] ASC,
	[dpto_dpto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vfm_habit]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_habit](
	[cod_edif] [int] NOT NULL,
	[cod_usu] [int] NOT NULL,
	[habit_rol] [int] NULL,
	[dpto_piso] [varchar](50) NOT NULL,
	[dpto_dpto] [varchar](50) NOT NULL,
	[fec_alta] [datetime] NOT NULL,
 CONSTRAINT [PK_vfm_habit] PRIMARY KEY CLUSTERED 
(
	[cod_edif] ASC,
	[cod_usu] ASC,
	[dpto_piso] ASC,
	[dpto_dpto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vfm_expensa]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_expensa](
	[id_exp] [numeric](18, 0) NOT NULL,
	[titulo] [varchar](50) NULL,
	[ruta] [varchar](75) NULL,
	[cod_exp] [varchar](20) NULL,
	[cod_edif] [int] NULL,
	[cod_usu] [int] NULL,
	[dpto_piso] [varchar](50) NULL,
	[dpto_dpto] [varchar](50) NULL,
 CONSTRAINT [PK_vfm_expensa] PRIMARY KEY CLUSTERED 
(
	[id_exp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vfm_encargado_dias]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_encargado_dias](
	[cod_usu] [int] NOT NULL,
	[cod_edif] [int] NOT NULL,
	[dia_lab] [int] NULL,
	[hor_desde] [varchar](5) NULL,
	[hor_hasta] [varchar](5) NULL,
 CONSTRAINT [PK_vfm_encargado_dias] PRIMARY KEY CLUSTERED 
(
	[cod_usu] ASC,
	[cod_edif] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vfm_amenity_res]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vfm_amenity_res](
	[cod_amenity] [int] NOT NULL,
	[cod_edif] [int] NOT NULL,
	[cod_usu] [int] NOT NULL,
	[dia_lab] [int] NULL,
	[hor_desde] [varchar](5) NULL,
	[hor_hasta] [varchar](5) NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_vfm_amenity_res] PRIMARY KEY CLUSTERED 
(
	[cod_amenity] ASC,
	[cod_edif] ASC,
	[cod_usu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[insupdHabit]    Script Date: 05/23/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insupdHabit]

	@cod_edif int,
    @cod_usu int,
    @habit_rol int,
    @dpto_piso varchar,
    @dpto_dpto varchar

as

If exists(select 1 from vfm_habit where cod_usu = @cod_usu  and cod_edif = @cod_edif and dpto_piso = @dpto_piso and dpto_dpto = @dpto_dpto)
	begin
		update vfm_habit set      	
			cod_edif	= 	@cod_edif ,
			cod_usu 	=     @cod_usu  ,
			habit_rol	=     @habit_rol,
			dpto_piso 	=     @dpto_piso,
			dpto_dpto 	=     @dpto_dpto
		where cod_usu   = @cod_usu
		
	end
else
	begin
	
insert into vfm_habit values 
		(@cod_edif ,
		   @cod_usu  ,
           @habit_rol,
           @dpto_piso,
           @dpto_dpto,
		   getdate())
		 
	end
GO
/****** Object:  ForeignKey [FK_vfm_encargado_Sys_usuarios]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_encargado]  WITH CHECK ADD  CONSTRAINT [FK_vfm_encargado_Sys_usuarios] FOREIGN KEY([cod_usu])
REFERENCES [dbo].[Sys_usuarios] ([cod_usu])
GO
ALTER TABLE [dbo].[vfm_encargado] CHECK CONSTRAINT [FK_vfm_encargado_Sys_usuarios]
GO
/****** Object:  ForeignKey [FK_vfm_amenities_vfm_edif]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_amenities]  WITH CHECK ADD  CONSTRAINT [FK_vfm_amenities_vfm_edif] FOREIGN KEY([cod_edif])
REFERENCES [dbo].[vfm_edif] ([cod_edif])
GO
ALTER TABLE [dbo].[vfm_amenities] CHECK CONSTRAINT [FK_vfm_amenities_vfm_edif]
GO
/****** Object:  ForeignKey [FK_vfm_departamento_vfm_edif]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_departamento]  WITH CHECK ADD  CONSTRAINT [FK_vfm_departamento_vfm_edif] FOREIGN KEY([cod_edif])
REFERENCES [dbo].[vfm_edif] ([cod_edif])
GO
ALTER TABLE [dbo].[vfm_departamento] CHECK CONSTRAINT [FK_vfm_departamento_vfm_edif]
GO
/****** Object:  ForeignKey [FK_vfm_habit_Sys_usuarios]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_habit]  WITH CHECK ADD  CONSTRAINT [FK_vfm_habit_Sys_usuarios] FOREIGN KEY([cod_usu])
REFERENCES [dbo].[Sys_usuarios] ([cod_usu])
GO
ALTER TABLE [dbo].[vfm_habit] CHECK CONSTRAINT [FK_vfm_habit_Sys_usuarios]
GO
/****** Object:  ForeignKey [FK_vfm_habit_vfm_edif]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_habit]  WITH CHECK ADD  CONSTRAINT [FK_vfm_habit_vfm_edif] FOREIGN KEY([cod_edif])
REFERENCES [dbo].[vfm_edif] ([cod_edif])
GO
ALTER TABLE [dbo].[vfm_habit] CHECK CONSTRAINT [FK_vfm_habit_vfm_edif]
GO
/****** Object:  ForeignKey [FK_vfm_expensa_vfm_habit]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_expensa]  WITH CHECK ADD  CONSTRAINT [FK_vfm_expensa_vfm_habit] FOREIGN KEY([cod_edif], [cod_usu], [dpto_piso], [dpto_dpto])
REFERENCES [dbo].[vfm_habit] ([cod_edif], [cod_usu], [dpto_piso], [dpto_dpto])
GO
ALTER TABLE [dbo].[vfm_expensa] CHECK CONSTRAINT [FK_vfm_expensa_vfm_habit]
GO
/****** Object:  ForeignKey [FK_vfm_encargado_dias_vfm_encargado]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_encargado_dias]  WITH CHECK ADD  CONSTRAINT [FK_vfm_encargado_dias_vfm_encargado] FOREIGN KEY([cod_usu], [cod_edif])
REFERENCES [dbo].[vfm_encargado] ([cod_usu], [cod_edif])
GO
ALTER TABLE [dbo].[vfm_encargado_dias] CHECK CONSTRAINT [FK_vfm_encargado_dias_vfm_encargado]
GO
/****** Object:  ForeignKey [FK_vfm_amenity_res_Sys_usuarios]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_amenity_res]  WITH CHECK ADD  CONSTRAINT [FK_vfm_amenity_res_Sys_usuarios] FOREIGN KEY([cod_usu])
REFERENCES [dbo].[Sys_usuarios] ([cod_usu])
GO
ALTER TABLE [dbo].[vfm_amenity_res] CHECK CONSTRAINT [FK_vfm_amenity_res_Sys_usuarios]
GO
/****** Object:  ForeignKey [FK_vfm_amenity_res_vfm_amenities]    Script Date: 05/23/2015 16:42:32 ******/
ALTER TABLE [dbo].[vfm_amenity_res]  WITH CHECK ADD  CONSTRAINT [FK_vfm_amenity_res_vfm_amenities] FOREIGN KEY([cod_edif], [cod_amenity])
REFERENCES [dbo].[vfm_amenities] ([cod_edif], [cod_amenity])
GO
ALTER TABLE [dbo].[vfm_amenity_res] CHECK CONSTRAINT [FK_vfm_amenity_res_vfm_amenities]
GO
