using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models
{
	public class PriceDynamics
	{
		public int Id { get; set; }
		public int GoodId { get; set; }
		public decimal InitialPrice { get; set; }
		public decimal PriceWithDiscount { get; set; }
		public decimal Discount { get; set; }

		public virtual Good Good { get; set; }
	}
}
