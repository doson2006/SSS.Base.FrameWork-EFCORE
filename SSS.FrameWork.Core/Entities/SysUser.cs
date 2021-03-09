// -----------------------------------------------------------------------------
// Generate By Furion Tools v1.6.0                            
// -----------------------------------------------------------------------------

using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SSS.FrameWork.Core
{
    public partial class SysUser : IEntity<MasterDbContextLocator>, IEntityTypeBuilder<SysUser, MasterDbContextLocator>
    {
        [Key]
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TrueName { get; set; }
        public string Tel { get; set; }
        public string SecretKey { get; set; }
        public byte? State { get; set; }
        public IsSystemEnum IsSystem { get; set; }
        public string Remark { get; set; }
        public long? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateTime { get; set; }

        public void Configure(EntityTypeBuilder<SysUser> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(e => e.UserId)
                .HasName("PK_USER_ID");

            entityBuilder.ToTable("SYS_USER");

            entityBuilder.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .UseIdentityColumn();

            entityBuilder.Property(e => e.CreateTime)
                .HasColumnType("DATE")
                .HasColumnName("CREATE_TIME");

            entityBuilder.Property(e => e.CreateUserId)
                .HasPrecision(19)
                .HasColumnName("CREATE_USER_ID");

            entityBuilder.Property(e => e.CreateUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATE_USER_NAME");

            entityBuilder.Property(e => e.IsSystem)
                .HasPrecision(2)
                .HasColumnName("IS_SYSTEM")
                .HasConversion(
                    v => v,
                    v => (IsSystemEnum)Enum.Parse(typeof(IsSystemEnum), v.ToString()));

            entityBuilder.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");

            entityBuilder.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REMARK");

            entityBuilder.Property(e => e.SecretKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECRET_KEY");

            entityBuilder.Property(e => e.State)
                .HasPrecision(2)
                .HasColumnName("STATE")
                .HasDefaultValueSql("1\n");

            entityBuilder.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL");

            entityBuilder.Property(e => e.TrueName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRUE_NAME");

            entityBuilder.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        }

    }
}

