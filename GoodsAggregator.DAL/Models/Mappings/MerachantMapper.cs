using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models.Mappings
{
	public class MerachantMapper : BaseMapper<Merchant>
	{
		public override void Map(EntityTypeBuilder<Merchant> entity)
		{
			entity.ToTable("Merchants")
				.HasKey(x => x.Id);

			entity.Property(x => x.Id)
				.ValueGeneratedOnAdd()
				.UseSerialColumn();

			entity.HasIndex(x => x.Url)
				.IsUnique();
		}
	}
}
