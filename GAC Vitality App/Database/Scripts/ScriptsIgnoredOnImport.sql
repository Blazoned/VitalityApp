
USE [vitalityapplocal]
GO

/****** Object:  Table [dbo].[Allergenes]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Image]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Ingredients]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[MiniRecipe]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Reaction]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Recipe]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[RecipeAllergene]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[User]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[UserCalorieCounterRecipe]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[UserFavoriteRecipe]    Script Date: 12/6/2018 11:11:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[Allergenes] ON
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (1, N'Melk')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (2, N'Eieren')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (3, N'Vis')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (4, N'Pinda')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (5, N'Soja')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (6, N'Mosterd')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (7, N'Selderij')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (8, N'Sesamzaad')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (9, N'Lupine')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (10, N'Walnoten')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (11, N'Hazelnoten')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (12, N'Pecannoten')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (13, N'Paranoten')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (14, N'Pistachenoten')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (15, N'Sulfiet')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (16, N'Gluten')
GO

INSERT [dbo].[Allergenes] ([Id], [Name]) VALUES (17, N'Schaaldieren')
GO

SET IDENTITY_INSERT [dbo].[Allergenes] OFF
GO

SET IDENTITY_INSERT [dbo].[Image] ON
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (1, 1, N'FotoMooi')
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (2, 2, N'FotoJo')
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (3, 5, N'FotoYo')
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (4, 7, N'FotoLelijk')
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (5, 8, N'FotoZwart')
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (6, 9, N'FotoPng')
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (7, 10, N'FotoBlij')
GO

INSERT [dbo].[Image] ([Id], [RecipeId], [FilePath]) VALUES (8, 11, N'FotoBos')
GO

SET IDENTITY_INSERT [dbo].[Image] OFF
GO

SET IDENTITY_INSERT [dbo].[Ingredients] ON
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (1, 1, N'Tomaat 3x')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (2, 1, N'Deeg 100 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (3, 1, N'Kaas half blok')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (4, 1, N'Salami 5 plakjes')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (5, 2, N'Slagroom ')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (6, 2, N'Appel 5x')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (7, 2, N'Smarties 100 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (8, 2, N'Chocola 2 repen')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (15, 5, N'Burger 1x')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (16, 5, N'Sla 200 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (17, 5, N'Tomaat 5x')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (18, 5, N'Pesto 1 kilo')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (19, 7, N'Deeg 50 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (20, 7, N'Pepernoot 5 kilo')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (21, 7, N'Chocola 50 repen')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (22, 7, N'Guinness 10 liter')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (23, 8, N'Mi 20 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (24, 8, N'Tauge 300 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (25, 8, N'Peper snufje')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (26, 8, N'Knoflook 54 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (27, 9, N'Ketchup 200 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (29, 9, N'Noten handje vol')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (30, 9, N'Bonen 20 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (31, 9, N'Eieren 4x')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (32, 10, N'Water 500 liter')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (33, 10, N'Vis 400 kilo')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (36, 10, N'Zout mespuntje')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (37, 10, N'Paksoi 1 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (38, 11, N'Pecorini kaas 40 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (39, 11, N'Boter 50 gram')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (40, 11, N'Peper lijntje')
GO

INSERT [dbo].[Ingredients] ([Id], [RecipeId], [Name]) VALUES (41, 11, N'Zout 60 gram')
GO

SET IDENTITY_INSERT [dbo].[Ingredients] OFF
GO

SET IDENTITY_INSERT [dbo].[MiniRecipe] ON
GO

INSERT [dbo].[MiniRecipe] ([Id], [UserId], [Name], [CalorieAmount]) VALUES (1, 1, N'Appel', 50)
GO

INSERT [dbo].[MiniRecipe] ([Id], [UserId], [Name], [CalorieAmount]) VALUES (2, 2, N'Peer', 40)
GO

INSERT [dbo].[MiniRecipe] ([Id], [UserId], [Name], [CalorieAmount]) VALUES (3, 3, N'Banaan', 30)
GO

INSERT [dbo].[MiniRecipe] ([Id], [UserId], [Name], [CalorieAmount]) VALUES (4, 4, N'Frikandel', 100)
GO

SET IDENTITY_INSERT [dbo].[MiniRecipe] OFF
GO

SET IDENTITY_INSERT [dbo].[Reaction] ON
GO

INSERT [dbo].[Reaction] ([Id], [RecipeId], [Username], [Desciption]) VALUES (1, 10, N'Martijn', N'Lekkerhoor')
GO

INSERT [dbo].[Reaction] ([Id], [RecipeId], [Username], [Desciption]) VALUES (2, 9, N'Mart', N'Vies')
GO

INSERT [dbo].[Reaction] ([Id], [RecipeId], [Username], [Desciption]) VALUES (3, 2, N'Henk', N'Niet te eten')
GO

INSERT [dbo].[Reaction] ([Id], [RecipeId], [Username], [Desciption]) VALUES (4, 1, N'Tom', N'Heel Vies')
GO

SET IDENTITY_INSERT [dbo].[Reaction] OFF
GO

SET IDENTITY_INSERT [dbo].[Recipe] ON
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (1, 1, N'Pizza', N'Pizza is kek', 100, 5, 300)
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (2, 2, N'Taart', N'Lekkere taart', 5, 10, 2)
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (5, 3, N'Burger', N'Lekkere Burger', 56, 50, 4)
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (7, 4, N'Cake', N'CakeLekker', 54, 300, 2)
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (8, 1, N'Bami', N'BamiJonge', 44, 567, 7)
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (9, 2, N'Pad Thai', N'Mooi weer', 32, 100, 45)
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (10, 3, N'Vissoep', N'Zee is koud', 20, 45, 3)
GO

INSERT [dbo].[Recipe] ([Id], [UserCreatorId], [Name], [Description], [PreperationTime], [TotalCalorieAmount], [TotalPersonAmount]) VALUES (11, 4, N'Spaghetti Carbonara', N'Italia ', 3009, 23, 1)
GO

SET IDENTITY_INSERT [dbo].[Recipe] OFF
GO

SET IDENTITY_INSERT [dbo].[RecipeAllergene] ON
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (1, 1, 4)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (2, 1, 2)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (3, 1, 5)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (4, 2, 1)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (5, 2, 6)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (6, 2, 14)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (7, 5, 5)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (8, 5, 8)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (9, 7, 5)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (10, 7, 2)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (11, 8, 16)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (12, 8, 14)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (13, 8, 12)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (14, 10, 1)
GO

INSERT [dbo].[RecipeAllergene] ([Id], [RecipeId], [AllergeneId]) VALUES (15, 11, 2)
GO

SET IDENTITY_INSERT [dbo].[RecipeAllergene] OFF
GO

SET IDENTITY_INSERT [dbo].[User] ON
GO

INSERT [dbo].[User] ([Id], [Name], [Password], [CalorieGoal]) VALUES (1, N'Martijn', N'peer', 100)
GO

INSERT [dbo].[User] ([Id], [Name], [Password], [CalorieGoal]) VALUES (2, N'Mart', N'appel', 200)
GO

INSERT [dbo].[User] ([Id], [Name], [Password], [CalorieGoal]) VALUES (3, N'Henk', N'citroen', 5000)
GO

INSERT [dbo].[User] ([Id], [Name], [Password], [CalorieGoal]) VALUES (4, N'Tom', N'fortniteboi69', 1337)
GO

SET IDENTITY_INSERT [dbo].[User] OFF
GO

SET IDENTITY_INSERT [dbo].[UserCalorieCounterRecipe] ON
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (1, 1, 11)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (2, 2, 10)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (3, 3, 11)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (4, 4, 7)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (5, 1, 9)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (6, 2, 9)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (7, 3, 1)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (8, 4, 2)
GO

INSERT [dbo].[UserCalorieCounterRecipe] ([Id], [UserId], [RecipeId]) VALUES (9, 4, 5)
GO

SET IDENTITY_INSERT [dbo].[UserCalorieCounterRecipe] OFF
GO

SET IDENTITY_INSERT [dbo].[UserFavoriteRecipe] ON
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (1, 1, 5)
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (2, 1, 7)
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (3, 2, 11)
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (4, 2, 10)
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (5, 3, 2)
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (6, 3, 9)
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (7, 4, 9)
GO

INSERT [dbo].[UserFavoriteRecipe] ([Id], [UserId], [RecipeId]) VALUES (8, 4, 1)
GO

SET IDENTITY_INSERT [dbo].[UserFavoriteRecipe] OFF
GO
