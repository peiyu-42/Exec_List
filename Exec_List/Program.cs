using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
	// 宣告一個 List<Product> 變數, 存放多筆購買商品
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Product> items = new List<Product>()
			{ new Product{ Name="滑鼠",Price=180},
			new Product{ Name="鍵盤",Price=700},
			new Product{ Name="喇叭",Price=450},
			new Product{ Price=123,Name="耳機"},

			};
			Console.WriteLine("商品和價格");
			foreach (var item in items)
			{
				Console.WriteLine($"名稱: {item.Name}, $ {item.Price}");
			}
		}
	}
	class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
	}
}
