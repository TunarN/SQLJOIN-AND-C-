using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFileStreamReader.Models
{
	public class ProductItem
	{
		public int Id { get; set; }
		public Product Product { get; set; }
		public double TotalPrice { get; set; }
	}
}
