using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("A284B809-7240-48DF-87AB-9A9ADFB36131"),
                RoleId = Guid.Parse("48F7C933-95B0-4E8F-9EC5-7BC247AB332A")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("C30EDAB8-CBB1-4A6B-810C-013456C7D076"),
                RoleId = Guid.Parse("887FA261-9CA8-4C9B-B34E-CDE27C6399A8")
            });
            
        }
    }
}

