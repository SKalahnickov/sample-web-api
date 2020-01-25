using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models.Mappings
{
	public class GoodInCategoryMapper : BaseMapper<GoodInCategory>
	{
		public override void Map(EntityTypeBuilder<GoodInCategory> entity)
		{
			entity.ToTable("GoodsInCategories")
				.HasKey(x => new { x.GoodId, x.CategoryId });

			entity.HasOne(x => x.Category)
				.WithMany(x => x.GoodInCategory)
				.HasForeignKey(x => x.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			entity.HasOne(x => x.Good)
				.WithMany(x => x.GoodsInCategory)
				.HasForeignKey(x => x.GoodId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
