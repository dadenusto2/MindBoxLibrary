/* 
[dbo].[Product] -  Таблица с продуктами
[dbo].[[Category] -  Таблица с категориями
[dbo].[Product and Category] Таблица связи [dbo].[Product] и [dbo].[[Category] по id
*/
select [dbo].[Product].[name] as Продукт, [dbo].[Category].[name] as Категория from
	[dbo].[Product]
	left join [dbo].[Product and Category] on /*Выбираем все имена продуктов по id из Product and Category и имена, которыъ там нет*/
		[dbo].[Product].[id] = [dbo].[Product and Category].[id_product]
	left join [dbo].[Category] on [dbo].[Category].[id]=[dbo].[Product and Category].[id_category]; /*Выбираем все имена категорий по id, которые есть Product and Category*/
