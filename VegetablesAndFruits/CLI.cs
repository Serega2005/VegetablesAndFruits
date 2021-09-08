using DZ_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VegetablesAndFruits
{
    public class CLI
    {
        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Выберите режим работы");
            Console.WriteLine("1. Показать все данные из таблицы");
            Console.WriteLine("2. Показать все названия овощей и фруктов");
            Console.WriteLine("3. Показать все цвета");
            Console.WriteLine("4. Показать максимальную калорийность");
            Console.WriteLine("5. Показать минимальную калорийность");
            Console.WriteLine("5. Показать среднюю калорийность");
            Console.WriteLine("0. Выход");
            Console.ResetColor();
        }

        public static void ShowVegFrus(List<VegFru> vegfrus)
        {
            foreach (var vegfru in vegfrus)
            {
                ShowVegFru(vegfru);
            }
        }
        public static void NameVegFrus(List<VegFru> vegfrus)
        {
            foreach (var vegfru in vegfrus)
            {
                NameVegFru(vegfru);
            }
        }
        public static void ColorVegFrus(List<VegFru> vegfrus)
        {
            foreach (var vegfru in vegfrus)
            {
                ColorVegFru(vegfru);
            }
        }
        public static void MaxCalorieVegFrus(List<VegFru> vegfrus)
        {
            foreach (var vegfru in vegfrus)
            {
                MaxCalorieVegFru(vegfru);
            }
        }
        public static void MinCalorieVegFrus(List<VegFru> vegfrus)
        {
            foreach (var vegfru in vegfrus)
            {
                MinCalorieVegFru(vegfru);
            }
        }

        private static void ShowVegFru(VegFru vegfru)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*** *** ***");
            Console.WriteLine($"{vegfru.Id}: {vegfru.Name}, {vegfru.Type}, {vegfru.Calorie}, {vegfru.Сalorie}");
            Console.WriteLine("*** *** ***");
            Console.WriteLine();
            Console.ResetColor();
        }
        //public static VegFru InputVegFru()
        //{
        //    var vegfru = new VegFru { Id = 0 };

        //    Console.ForegroundColor = ConsoleColor.DarkGreen;
        //    Console.WriteLine("Ввод данных о овоще или фрукте");
        //    Console.WriteLine("Введите название: ");
        //    var name = Console.ReadLine();
        //    Console.WriteLine("Введите тип: ");
        //    var type = Console.ReadLine();
        //    Console.WriteLine("Введите цвет: ");
        //    var color = Console.ReadLine();
        //    Console.WriteLine("Введите количество калорий: ");
        //    var calorie = Console.ReadLine();

        //    vegfru.Name = name;
        //    vegfru.Type = type;
        //    vegfru.Color = color;
        //    vegfru.Сalorie = calorie;

        //    return vegfru;
        //}

        private static void NameVegFru(VegFru vegfru)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*** *** ***");
            Console.WriteLine($"{vegfru.Id}: {vegfru.Name}");
            Console.WriteLine("*** *** ***");
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void ColorVegFru(VegFru vegfru)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*** *** ***");
            Console.WriteLine($"{vegfru.Id}: {vegfru.Calorie}");
            Console.WriteLine("*** *** ***");
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void MaxCalorieVegFru(VegFru vegfru)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*** *** ***");
            Console.WriteLine($"{vegfru.Id}: {vegfru.Calorie}");
            Console.WriteLine("*** *** ***");
            Console.WriteLine();
            Console.ResetColor();
        }
        private static void MinCalorieVegFru(VegFru vegfru)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*** *** ***");
            Console.WriteLine($"{vegfru.Id}: {vegfru.Calorie}");
            Console.WriteLine("*** *** ***");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
