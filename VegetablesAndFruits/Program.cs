using DZ_Lib;
using System;

namespace VegetablesAndFruits
{
    public class Program
    {
        static void Main()
        {
            
            var dz_db = new DZ_DataBase();

            var exit = false;
            do
            {
                CLI.ShowMenu();
                var select = Console.ReadLine();
                switch (select)
                {
                    case "1"://Отображение всей информации из таблицы с овощами и фруктами
                        dz_db.Open();
                        CLI.ShowVegFrus(dz_db.GetVegFru());
                        dz_db.Close();
                        break;
                    case "2"://Отображение всех названий овощей и фруктов
                        dz_db.Open();
                        CLI.NameVegFrus(dz_db.GetVegFru());
                        dz_db.Close();
                        break;
                    case "3"://Отображение всех цветов
                        dz_db.Open();
                        CLI.ColorVegFrus(dz_db.GetVegFru());
                        dz_db.Close();
                        break;
                    case "4"://Максимальная калорийность
                        dz_db.Open();
                        CLI.MaxCalorieVegFrus(dz_db.MaxCalorieVegFru());
                        dz_db.Close();
                        break;
                    case "5"://Минимальная калорийность
                        dz_db.Open();
                        CLI.MinCalorieVegFrus(dz_db.MinCalorieVegFru());
                        dz_db.Close();
                        break;
                        //Среднее значения я попытался сделать, но не получилось
                    case "0":
                        exit = true;
                        break;
                }
            } while (!exit);
        }
    }
}
