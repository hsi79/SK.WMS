-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_SKS_PGM_SELECTALL
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	   [PGM_ID]
      ,[PGM_PATH]
      ,[PGM_NM]
      ,[PGM_TYPE]
      ,[PGM_DESC]
      ,[REG_ID]
      ,[REG_TIME]
      ,[MOD_ID]
      ,[MOD_TIME]
	FROM 
	   [T_SKS_PGM]
		
END
GO
