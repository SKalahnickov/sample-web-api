using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models
{
	public class Good
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsPresent { get; set; }
		public string UrlInfo { get; set; }
		public string UrlImage { get; set; }
		public virtual IReadOnlyCollection<GoodInCategory> GoodsInCategory { get; set; } = new HashSet<GoodInCategory>();
		public virtual IReadOnlyCollection<PriceDynamics> PriceDynamics { get; set; } = new HashSet<PriceDynamics>();
	}
}
