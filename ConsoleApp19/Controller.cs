using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Controller
    {
        public static List<Good> Goods = new List<Good>();  
        public void AddGood(float index, string title, float price, float sale, string desc)
        {
            Good goood = new Good()
            {
                Index = (int)index,
                Title = title,
                Price = price,
                Sale = sale,
                Description = desc
            };
            Goods.Add(goood);
        } 
        public string GetGoods()
        {
            

            string text = "";
            foreach (var item in Goods)
            {
                text += $"номер товара - {item.Index} {item.Title} цена - {item.Price}  цена со скидкой - {item.Price - (item.Price * (item.Sale / 100))}\n";

            }
            return text;
           
        }

        public void SaveList()
        {
            var json = JsonSerializer.Serialize<List<Good>>(Goods);
            File.WriteAllText("db.json", json);

        }
        public void OpenList()
        {
            if (!File.Exists("db.json"))
                return;
            var json = File.ReadAllText("db.json");
            Goods = JsonSerializer.Deserialize<List<Good>>(json);
        }

        public void Udalenie()
        {
            Console.WriteLine("введите индекс товара, который хотите удалить");

            int k = Convert.ToInt32(Console.ReadLine());
            Goods.RemoveAt (k);
            Console.WriteLine("товар удален");
        }
    }
}
