using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Book.Entitis;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.Book.Configuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<BooktEntity>
    {
        public void Configure(EntityTypeBuilder<BooktEntity> builder)
        {
        

            builder.ConfigureByConvention();

            builder.Property(x => x.Name)
                  .IsRequired()
                  .HasMaxLength(128);
        }
    }
}
