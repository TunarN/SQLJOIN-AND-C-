using DirectoryFileStreamReader.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Threading.Tasks.Sources;

namespace DirectoryFileStreamReader 
{ 
	class Program
	{
		static void Main(string[] args)
		{
			//Directory.CreateDirectory(@"C:\Users\lenovo\Desktop\Test");
			//Directory.CreateDirectory(@"C:\Users\lenovo\Desktop\Lorem");
			//Directory.CreateDirectory(@"C:\Users\lenovo\Desktop\Lorem\Tset");
			//Directory.Delete(@"C:\Users\lenovo\Desktop\Lorem",true);
			//if (Directory.Exists(@"C:\Users\lenovo\Desktop\Lorem\Tset"))
			//{
			//	Directory.Delete(@"C:\Users\lenovo\Desktop\Lorem\Tset");
			//}

			//Directory.GetDirectories(@"C:\Users\lenovo\Desktop\Test");

			//string [] arr = Directory.GetFiles(@"C:\Users\lenovo\Desktop\Test");
			//foreach (var item in arr)
			//{
			//	Console.WriteLine(item);
			//}
			//if (File.Exists(@"C:\Users\lenovo\Desktop\Test\blabla.txt"))
			//{
			//  //File.Create(@"C:\Users\lenovo\Desktop\Test\blabla.txt");
			//	File.Delete(@"C:\Users\lenovo\Desktop\Test\blabla.txt");

			//}

			//Directory.CreateDirectory(@"C:\Users\lenovo\Desktop\Test");
			//File.Create(@"C:\Users\lenovo\Desktop\Test\blabla.txt");
			//StreamWriter sw = new StreamWriter(@"C:\Users\lenovo\Desktop\Test\blabla.txt" , true);
			//sw.WriteLine("Nurlan");
			//sw.Close();

			//StreamReader sw1 = new StreamReader(@"C:\Users\lenovo\Desktop\Test\blabla.txt", true);
			//string result = sw1.ReadToEnd();
			//Console.WriteLine(result);
			//sw1.Close();

			//using (StreamWriter sw = new StreamWriter(@"C:\Users\lenovo\Desktop\Test\blabla.txt", true))
			//{
			//	sw.WriteLine("Nurlan");
			//}

			//using (StreamReader sw1 = new StreamReader(@"C:\Users\lenovo\Desktop\Test\blabla.txt", true))
			//{
			//	string result = sw1.ReadToEnd();
			//	Console.WriteLine(result);
			//}

			Product p1 = new Product { Id = 1, Name = "Iphone", Price = 1000 };
			Product p2 = new Product { Id = 2, Name = "Samsung", Price = 500 };

			ProductItem productItem = new ProductItem { Id = 1, TotalPrice = p1.Price, Product = p1 };
			ProductItem productItem1 = new ProductItem { Id = 2, TotalPrice = p2.Price, Product = p2 };

			List<ProductItem> list = new List<ProductItem>();
			list.Add(productItem);
			list.Add(productItem1);

			//ProductItems productItems = new ProductItems { Id = 1, productItems = list };
			//string result = JsonConvert.SerializeObject(productItems);

			//using (StreamWriter sw = new StreamWriter(@"C:\Users\lenovo\Desktop\BACK\DirectoryFileStreamReader\DirectoryFileStreamReader\Json\json1.json", true))
			//{
			//	sw.WriteLine(result);
			//}
			string result;
			using (StreamReader sw = new StreamReader(@"C:\Users\lenovo\Desktop\BACK\DirectoryFileStreamReader\DirectoryFileStreamReader\Json\json1.json", true))
			{
			    result = sw.ReadToEnd();
				Console.WriteLine(result);
			}
              var list1 = JsonConvert.DeserializeObject<ProductItems>(result);
			  Console.WriteLine(list.GetType());
		}
	}
}
