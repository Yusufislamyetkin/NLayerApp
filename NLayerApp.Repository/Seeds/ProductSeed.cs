using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        //Migration Sırasında Örnek Data Oluşturma

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kalem1",
                Price = 50,
                Stock = 30,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Kalem2",
                Price = 150,
                Stock = 70,
                CreatedDate = DateTime.Now
            });


        }
    }
}
