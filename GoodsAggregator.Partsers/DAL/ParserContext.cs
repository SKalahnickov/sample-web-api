using GoodsAggregator.DAL;
using GoodsAggregator.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.Parsers.DAL
{
	public class ParserContext : BaseContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Good> Goods { get; set; }
		public DbSet<GoodInCategory> GoodsInCategories { get; set; }
		public DbSet<Merchant> Merchants { get; set; }
		public DbSet<PriceDynamics> Prices { get; set; }
	}
}
