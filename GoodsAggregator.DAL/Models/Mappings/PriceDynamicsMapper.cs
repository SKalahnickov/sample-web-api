using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models.Mappings
{
	public class PriceDynamicsMapper : BaseMapper<PriceDynamics>
	{
		public override void Map(EntityTypeBuilder<PriceDynamics> entity)
		{
			entity.ToTable("PriceDynamics")
				.HasKey(x => x.Id);

			entity.Property(x => x.Id)
				.ValueGeneratedOnAdd()
				.UseSerialColumn();

			entity.HasOne(x => x.Good)
				.WithMany(x => x.PriceDynamics)
				.HasForeignKey(x => x.GoodId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
