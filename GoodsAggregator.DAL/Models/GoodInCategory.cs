using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models
{
	public class GoodInCategory
	{
		public int GoodId { get; set; }
		public int CategoryId { get; set; }

		public virtual Good Good { get; set; }
		public virtual Category Category { get; set; }
	}
}
