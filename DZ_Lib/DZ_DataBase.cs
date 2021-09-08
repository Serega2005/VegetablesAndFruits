using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DZ_Lib
{
    public class DZ_DataBase
    {
        //подключение к базе данных
        private readonly MySqlConnection _db;
        private MySqlCommand _command;

        public DZ_DataBase()
        {
            _db = new MySqlConnection(CONN_STR);
            _command = new MySqlCommand { Connection = _db };
        }

        public void Open()
        {
            _db.Open();
        }

        public void Close()
        {
            _db.Close();
        }

        public List<VegFru> GetVegFru()
        {
            var list = new List<VegFru>();

            var sql = "SELECT * FROM table_vegfru";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                var id = result.GetInt32("id");
                var name = result.GetString("name");
                var type = result.GetString("type");
                var color = result.GetString("color");
                var calorie = result.GetString("calorie");

                list.Add(new VegFru { Id = id, Name = name, Type = type, Calorie= color, Сalorie= calorie });
            }
            return list;
        }
        public List<VegFru> MaxCalorieVegFru()
        {
            var list = new List<VegFru>();

            var sql = "SELECT MAX(calorie)as max FROM table_vegfru";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                var id = result.GetInt32("id");
                var calorie = result.GetString("calorie");

                list.Add(new VegFru { Id = id, Сalorie = calorie });
            }
            return list;
        }
        public List<VegFru> MinCalorieVegFru()
        {
            var list = new List<VegFru>();

            var sql = "SELECT MIN(calorie)as min FROM table_vegfru";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                var id = result.GetInt32("id");
                var calorie = result.GetString("calorie");

                list.Add(new VegFru { Id = id, Сalorie = calorie });
            }
            return list;
        }

        public bool InsertVegFru(VegFru vegfru)
        {
            var sql = $"INSERT INTO table_verfru (id, name, type, color, calorie) Values('{vegfru.Id}', '{vegfru.Name}', '{vegfru.Type}', '{vegfru.Calorie}', '{vegfru.Сalorie}')";
            _command.CommandText = sql;

            var result = _command.ExecuteNonQuery();

            return result > 0;

        }
    }
}
