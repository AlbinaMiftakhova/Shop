using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Shop.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ShopEntities>
    {
        protected override void Seed(ShopEntities context)
        {
            var Category = new List<Category>
            {
                new Category { Name = "Юбки" },
                new Category { Name = "Брюки" },
                new Category { Name = "Платья" },
                new Category { Name = "Рубашки" },
                new Category { Name = "Пиджаки" },
                new Category { Name = "Верхняя одежда" }
            };

            new List<Clothing>
            {
                new Clothing { Name = "Двухцветная юбка с пуговицами", Category = Category.Single(g => g.Name == "Юбки"), Price = 3500, Photo = "/Content/Images/Юбки/Двухцветная юбка с пуговицами.jpg",  Photo1 = "/Content/Images/Юбки/Двухцветная юбка с пуговицами1.jpg", },
                new Clothing { Name = "Короткая пышная юбка", Category = Category.Single(g => g.Name == "Юбки"), Price = 2400, Photo = "/Content/Images/Юбки/Короткая пышная юбка.jpg",  Photo1 = "/Content/Images/Юбки/Короткая пышная юбка1.jpg"},
                new Clothing { Name = "Миди-юбка с принтом", Category = Category.Single(g => g.Name == "Юбки"), Price = 5200, Photo = "/Content/Images/Юбки/Миди-юбка с принтом.jpg", Photo1 = "/Content/Images/Юбки/Миди-юбка с принтом1.jpg" },
                new Clothing { Name = "Плиссированная юбка с цветочным принтом", Category = Category.Single(g => g.Name == "Юбки"), Price = 2100, Photo = "/Content/Images/Юбки/Плиссированная юбка с цветочным принтом.jpg", Photo1 = "/Content/Images/Юбки/Плиссированная юбка с цветочным принтом1.jpg" },
                new Clothing { Name = "Юбка из модала", Category = Category.Single(g => g.Name == "Юбки"), Price = 4300, Photo = "/Content/Images/Юбки/Юбка из модала.jpg", Photo1 = "/Content/Images/Юбки/Юбка из модала1.jpg" },

                new Clothing { Name = "Брюки из лиоцелла с защипами", Category = Category.Single(g => g.Name == "Брюки"), Price = 5300, Photo = "/Content/Images/Брюки/Брюки из лиоцелла с защипами.jpg", Photo1 = "/Content/Images/Брюки/Брюки из лиоцелла с защипами1.jpg" },
                new Clothing { Name = "Брюки", Category = Category.Single(g => g.Name == "Брюки"), Price = 5500, Photo = "/Content/Images/Брюки/Брюки.jpg", Photo1 = "/Content/Images/Брюки/Брюки1.jpg" },
                new Clothing { Name = "Костюмные брюки с защипами", Category = Category.Single(g => g.Name == "Брюки"), Price = 5300, Photo = "/Content/Images/Брюки/Костюмные брюки с защипами.jpg", Photo1 = "/Content/Images/Брюки/Костюмные брюки с защипами1.jpg" },
                new Clothing { Name = "Костюмные брюки", Category = Category.Single(g => g.Name == "Брюки"), Price = 4200, Photo = "/Content/Images/Брюки/Костюмные брюки.jpg", Photo1 = "/Content/Images/Брюки/Костюмные брюки1.jpg" },
                new Clothing { Name = "Хлопковые брюки", Category = Category.Single(g => g.Name == "Брюки"), Price = 3500, Photo = "/Content/Images/Брюки/Хлопковые брюки.jpg",  Photo1 = "/Content/Images/Брюки/Хлопковые брюки1.jpg" },

                new Clothing { Name = "Длинное платье с металлизированными деталями", Category = Category.Single(g => g.Name == "Платья"), Price = 5600, Photo = "/Content/Images/Платья/Длинное платье с металлизированными деталями.jpg", Photo1 = "/Content/Images/Платья/Длинное платье с металлизированными деталями1.jpg"},
                new Clothing { Name = "Миди-платье с плиссировкой", Category = Category.Single(g => g.Name == "Платья"), Price = 6200, Photo = "/Content/Images/Платья/Миди-платье с плиссировкой.jpg",  Photo1 = "/Content/Images/Платья/Миди-платье с плиссировкой1.jpg" },
                new Clothing { Name = "Креповое платье на запáх", Category = Category.Single(g => g.Name == "Платья"), Price = 4600, Photo = "/Content/Images/Платья/Креповое платье на запáх.jpg", Photo1 = "/Content/Images/Платья/Креповое платье на запáх1.jpg"},
                new Clothing { Name = "Хлопковое платье с пуговицами", Category = Category.Single(g => g.Name == "Платья"), Price = 3900, Photo = "/Content/Images/Платья/Хлопковое платье с пуговицами.jpg", Photo1 = "/Content/Images/Платья/Хлопковое платье с пуговицами1.jpg"},
                new Clothing { Name = "Платье-рубашка с пуговицами", Category = Category.Single(g => g.Name == "Платья"), Price = 4500, Photo = "/Content/Images/Платья/Платье-рубашка с пуговицами.jpg", Photo1 = "/Content/Images/Платья/Платье-рубашка с пуговицами1.jpg"},

                new Clothing { Name = "Струящаяся рубашка с карманом", Category = Category.Single(g => g.Name == "Рубашки"), Price = 3500, Photo = "/Content/Images/Рубашки/Струящаяся рубашка с карманом.jpg", Photo1 = "/Content/Images/Рубашки/Струящаяся рубашка с карманом1.jpg" },
                new Clothing { Name = "Рубашка", Category = Category.Single(g => g.Name == "Рубашки"), Price = 2800, Photo = "/Content/Images/Рубашки/Рубашка.jpg", Photo1 = "/Content/Images/Рубашки/Рубашка1.jpg" },
                new Clothing { Name = "Рубашка с короткими рукавами", Category = Category.Single(g => g.Name == "Рубашки"), Price = 3200, Photo = "/Content/Images/Рубашки/Рубашка с короткими рукавами.jpg",  },
                new Clothing { Name = "Льняная рубашка", Category = Category.Single(g => g.Name == "Рубашки"), Price = 4100, Photo = "/Content/Images/Рубашки/Льняная рубашка.jpg", Photo1 = "/Content/Images/Рубашки/Льняная рубашка1.jpg" },
                new Clothing { Name = "Блузка с цветочным принтом", Category = Category.Single(g => g.Name == "Рубашки"), Price = 2200, Photo = "/Content/Images/Рубашки/Блузка с цветочным принтом.jpg", Photo1 = "/Content/Images/Рубашки/Блузка с цветочным принтом1.jpg" },

                new Clothing { Name = "Структурированный костюмный пиджак", Category = Category.Single(g => g.Name == "Пиджаки"), Price = 6900, Photo = "/Content/Images/Пиджаки/Структурированный костюмный пиджак.jpg", Photo1 = "/Content/Images/Пиджаки/Структурированный костюмный пиджак1.jpg" },
                new Clothing { Name = "Пиджак в клетку", Category = Category.Single(g => g.Name == "Пиджаки"), Price = 5800, Photo = "/Content/Images/Пиджаки/Пиджак в клетку.jpg", Photo1 = "/Content/Images/Пиджаки/Пиджак в клетку1.jpg" },
                new Clothing { Name = "Мягкий пиджак с пуговицами", Category = Category.Single(g => g.Name == "Пиджаки"), Price = 6200, Photo = "/Content/Images/Пиджаки/Мягкий пиджак с пуговицами.jpg", Photo1 = "/Content/Images/Пиджаки/Мягкий пиджак с пуговицами1.jpg" },
                new Clothing { Name = "Двубортный пиджак", Category = Category.Single(g => g.Name == "Пиджаки"), Price = 6500, Photo = "/Content/Images/Пиджаки/Двубортный пиджак.jpg", Photo1 = "/Content/Images/Пиджаки/Двубортный пиджак1.jpg" },
                new Clothing { Name = "Блейзер с декоративными пуговицами", Category = Category.Single(g => g.Name == "Пиджаки"), Price = 5900, Photo = "/Content/Images/Пиджаки/Блейзер с декоративными пуговицами.jpg", Photo1 = "/Content/Images/Пиджаки/Блейзер с декоративными пуговицами1.jpg" },

                new Clothing { Name = "Структурированное пальто с лацканами", Category = Category.Single(g => g.Name == "Верхняя одежда"), Price = 9000, Photo = "/Content/Images/Верхняя одежда/Структурированное пальто с лацканами.jpg", Photo1 = "/Content/Images/Верхняя одежда/Структурированное пальто с лацканами1.jpg", },
                new Clothing { Name = "Полушерстяное пальто с поясом", Category = Category.Single(g => g.Name == "Верхняя одежда"), Price = 10500, Photo = "/Content/Images/Верхняя одежда/Полушерстяное пальто с поясом.jpg", Photo1 = "/Content/Images/Верхняя одежда/Полушерстяное пальто с поясом1.jpg" },
                new Clothing { Name = "Куртка с высоким воротником", Category = Category.Single(g => g.Name == "Верхняя одежда"), Price = 7800, Photo = "/Content/Images/Верхняя одежда/Куртка с высоким воротником.jpg", Photo1 = "/Content/Images/Верхняя одежда/Куртка с высоким воротником1.jpg" },
                new Clothing { Name = "Длинный плащ", Category = Category.Single(g => g.Name == "Верхняя одежда"), Price = 7000, Photo = "/Content/Images/Верхняя одежда/Длинный плащ.jpg", Photo1 = "/Content/Images/Верхняя одежда/Длинный плащ1.jpg" },
                new Clothing { Name = "Ветровка с поясом", Category = Category.Single(g => g.Name == "Верхняя одежда"), Price = 5400, Photo = "/Content/Images/Верхняя одежда/Ветровка с поясом.jpg", Photo1 = "/Content/Images/Верхняя одежда/Ветровка с поясом1.jpg" },

            }.ForEach(a => context.Clothes.Add(a));
        }
    }
}