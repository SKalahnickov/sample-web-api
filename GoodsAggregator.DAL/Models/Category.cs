using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public string Name { get; set; }
		public int MerchantId { get; set; }
		public virtual Merchant Merchant { get; set; }
		public virtual IReadOnlyCollection<GoodInCategory> GoodInCategory { get; set; } = new HashSet<GoodInCategory>();
	}
}
