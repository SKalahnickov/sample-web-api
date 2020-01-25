using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models
{
	public class Merchant
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
		public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
	}
}
