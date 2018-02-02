USE [SKSStandard]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_SKS_PGM](
	[PGM_ID] [nvarchar](50) COLLATE Korean_Wansung_CI_AS NOT NULL,
	[PGM_PATH] [nvarchar](200) COLLATE Korean_Wansung_CI_AS NULL,
	[PGM_NM] [nvarchar](100) COLLATE Korean_Wansung_CI_AS NULL,
	[PGM_TYPE] [nvarchar](10) COLLATE Korean_Wansung_CI_AS NULL,
	[PGM_DESC] [nvarchar](200) COLLATE Korean_Wansung_CI_AS NULL,
	[REG_ID] [nvarchar](10) COLLATE Korean_Wansung_CI_AS NULL,
	[REG_TIME] [datetime] NULL DEFAULT (getdate()),
	[MOD_ID] [nvarchar](10) COLLATE Korean_Wansung_CI_AS NULL,
	[MOD_TIME]  AS (getdate()),
 CONSTRAINT [PK__T_SKS_PGM__778AC167] PRIMARY KEY CLUSTERED 
(
	[PGM_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
