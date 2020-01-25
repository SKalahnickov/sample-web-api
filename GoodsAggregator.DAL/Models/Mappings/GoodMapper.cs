using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models.Mappings
{
	public class GoodMapper : BaseMapper<Good>
	{
		public override void Map(EntityTypeBuilder<Good> entity)
		{
			entity.ToTable("Goods")
				.HasKey(x => x.Id);

			entity.Property(x => x.Id)
				.ValueGeneratedOnAdd()
				.UseSerialColumn();

			entity.HasIndex(x => x.UrlInfo)
				.IsUnique();
		}
	}
}
