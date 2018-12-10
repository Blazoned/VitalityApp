CREATE TABLE [dbo].[RecipeAllergene](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecipeId] [int] NOT NULL,
	[AllergeneId] [int] NOT NULL,
 CONSTRAINT [PK_RecipeAllergene] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RecipeAllergene]  WITH CHECK ADD  CONSTRAINT [FK_RecipeAllergene_Allergenes] FOREIGN KEY([AllergeneId])
REFERENCES [dbo].[Allergenes] ([Id])
GO

ALTER TABLE [dbo].[RecipeAllergene] CHECK CONSTRAINT [FK_RecipeAllergene_Allergenes]
GO
ALTER TABLE [dbo].[RecipeAllergene]  WITH CHECK ADD  CONSTRAINT [FK_RecipeAllergene_Recipe] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipe] ([Id])
GO

ALTER TABLE [dbo].[RecipeAllergene] CHECK CONSTRAINT [FK_RecipeAllergene_Recipe]