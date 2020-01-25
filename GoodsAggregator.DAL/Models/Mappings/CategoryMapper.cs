using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsAggregator.DAL.Models.Mappings
{
	public class CategoryMapper : BaseMapper<Category>
	{
		public override void Map(EntityTypeBuilder<Category> entity)
		{
			entity.ToTable("Categories")
				.HasKey(x => x.Id);

			entity.Property(x => x.Id)
				.ValueGeneratedOnAdd()
				.UseSerialColumn();

			entity.HasIndex(x => x.Url)
				.IsUnique();

			entity.HasOne(x => x.Merchant)
				.WithMany(x => x.Categories)
				.HasForeignKey(x => x.MerchantId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
