CREATE TABLE [dbo].[UserFavoriteRecipe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RecipeId] [int] NOT NULL,
 CONSTRAINT [PK_UserFavoriteRecipe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserFavoriteRecipe]  WITH CHECK ADD  CONSTRAINT [FK_UserFavoriteRecipe_Recipe] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipe] ([Id])
GO

ALTER TABLE [dbo].[UserFavoriteRecipe] CHECK CONSTRAINT [FK_UserFavoriteRecipe_Recipe]
GO
ALTER TABLE [dbo].[UserFavoriteRecipe]  WITH CHECK ADD  CONSTRAINT [FK_UserFavoriteRecipe_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO

ALTER TABLE [dbo].[UserFavoriteRecipe] CHECK CONSTRAINT [FK_UserFavoriteRecipe_User]