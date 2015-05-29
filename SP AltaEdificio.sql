USE [Administracion_Sys]
GO
/****** Object:  StoredProcedure [dbo].[insupdEdif]    Script Date: 05/29/2015 02:48:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insupdEdif]

@cod_edif   int,
@edif_calle	varchar(100),
@edif_num	numeric(18),
@edif_cp	varchar(18),
@edif_country	numeric(4),
@edif_prov	numeric(4),
@edif_loc	numeric(4),
@estado	numeric(4),
@edif_nombre varchar(50)

as

declare @max_edif  int; 

set @max_edif = (select max(cod_edif) from vfm_edif) 

If exists(select 1 from vfm_edif where cod_edif = @cod_edif)
	begin
		update vfm_edif set 
		@edif_calle		= edif_calle,	
		@edif_num		= edif_num,
		@edif_cp		= edif_cp,
		@edif_country	= edif_country,
		@edif_prov		= edif_prov,
		@edif_loc		= edif_loc,
		@estado			= estado,
		@edif_nombre	= edif_nombre
		where cod_edif = @cod_edif
	end
else
	begin
		insert into vfm_edif values 
		(@max_edif + 1,
		@edif_calle,	
		@edif_num,
		@edif_cp,
		@edif_country,
		@edif_prov,
		@edif_loc,
		@estado,
		@edif_nombre)
	end