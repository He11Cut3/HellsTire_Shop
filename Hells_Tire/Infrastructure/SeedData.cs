using Hells_Tire.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Hells_Tire.Models;

namespace ShoppingCart.Infrastructure
{
	public class SeedData
	{
		public static void SeedDatabase(DataContext context)
		{
			byte[] imageBytes = File.ReadAllBytes("C:\\Users\\kek13\\OneDrive\\Рабочий стол\\UP.png");
			byte[] imageBytes1 = File.ReadAllBytes("C:\\Users\\kek13\\OneDrive\\Рабочий стол\\OZ.png");
			byte[] imageBytes2 = File.ReadAllBytes("C:\\Users\\kek13\\OneDrive\\Рабочий стол\\Sup1.png");
			byte[] imageBytes3 = File.ReadAllBytes("C:\\Users\\kek13\\OneDrive\\Рабочий стол\\Body.png");

			context.Database.Migrate();

			if (!context.HellsTireProducts.Any())
			{
				HellsTireCategory tires = new HellsTireCategory { HellsTireCategoryName = "Wheels & Tires", HellsTireCategorySlug = "wheels_tires" };
				HellsTireCategory suspension = new HellsTireCategory { HellsTireCategoryName = "Suspension", HellsTireCategorySlug = "suspension" };
				HellsTireCategory BodyParts = new HellsTireCategory { HellsTireCategoryName = "Body Parts", HellsTireCategorySlug = "body" };

				context.HellsTireProducts.AddRange(
						new HellsTireProduct
						{
							HellsTireProductName = "Колесный диск Wheels UP Up105 17x7 PCD5x108 ET33 D60.1",
							HellsTireProductBrand = "Wheels UP",
							HellsTireProductDescriptions = "Диаметр, дюймы\r\n17\r\nШирина обода\r\n7\"\r\nКол-во крепежных отверстий\r\n5\r\nДиаметр расположения отверстий (PCD)\r\n108\r\nВылет, мм\r\n33\r\nДиаметр центр. отверстия, мм\r\n60.1",
							HellsTireProductPrice = 7020M,
							HellsTireProductSlug = "wheels-up",
							HellsTireCategory = tires,
							HellsTireProductImage = imageBytes,

						},
						new HellsTireProduct
						{
							HellsTireProductName = "Колесный диск OZ 20x12 PCD15x130 ET47 D84 Литой",
							HellsTireProductBrand = "OZ",
							HellsTireProductDescriptions = "Диаметр, дюймы\r\n20\r\nШирина обода\r\n12\"\r\nКол-во крепежных отверстий\r\n15\r\nДиаметр расположения отверстий (PCD)\r\n130\r\nВылет, мм\r\n47\r\nДиаметр центр. отверстия, мм\r\n84\r\nВид диска\r\nЛитой",
							HellsTireProductPrice = 73976M,
							HellsTireProductSlug = "oz",
							HellsTireCategory = tires,
							HellsTireProductImage = imageBytes1,

						},
						new HellsTireProduct
						{
							HellsTireProductName = "Амортизатор задний Toyota Land Cruiser Prado 120 / Lexus GX470",
							HellsTireProductBrand = "Toyota",
							HellsTireProductSlug = "toyota",
							HellsTireProductDescriptions = "Наличие товара во Владивостоке\r\nВ наличии\r\nСостояние\r\nНовый\r\nОригинальность\r\nАналог\r\nНомер запчасти\r\n4853069185\r\nНомера замен\r\nSK2813 4853069485 SA1691 7440002 741072\r\nСторона\r\nЛевая, Правая\r\nПоложение\r\nЗаднее",
							HellsTireProductPrice = 12000M,
							HellsTireCategory = suspension,
							HellsTireProductImage = imageBytes2,

						},
						new HellsTireProduct
						{
							HellsTireProductName = "Спойлер универсальный ver.4",
							HellsTireProductBrand = "Acura",
							HellsTireProductSlug = "acura",
							HellsTireProductDescriptions = "Спойлер изготовлен из высококачественного алюминия.\r\n\r\nПолный комплект без доработок. Подходит на любой автомобиль\r\nТовар универсальный\r\n\r\nКомплект состоит из:\r\n\r\n-Спойлер\r\n-Крепления\r\n-Ноги\r\n-Площадки на багажник\r\n-Регулируется угол атаки и посадочная высота",
							HellsTireProductPrice = 9900M,
							HellsTireCategory = BodyParts,
							HellsTireProductImage = imageBytes3,

						}
				);

				context.SaveChanges();
			}
		}
	}
}