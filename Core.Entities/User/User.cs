using Core.Entities.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class User : IdentityUser<Guid>, IEntity // BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string? UserImage { get; set; }

        [Required]
        [MaxLength(10)]
        public string NationalNumber { get; set; }

        [Required]
        [MaxLength(15)]
        public string PersonalCode { get; set; }
        public DateTime? BirthDayDate { get; set; }
        public GenderType Gender { get; set; }
        public UserType Type { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Change Table Name
            builder.ToTable("Users");

            builder.HasIndex(p => p.UserName).IsUnique();
            builder.Property(p => p.UserName).IsRequired().HasMaxLength(100);

            builder.Property(p => p.PhoneNumber).HasMaxLength(12).HasColumnType("varchar(12)");

            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            // builder.Property(p => p.CreatedDate).HasDefaultValueSql("GetDate()");
        }
    }

    public enum GenderType : byte
    {
        [Display(Name = "مرد")]
        Male = 1,

        [Display(Name = "زن")]
        Female = 2
    }

    public enum UserType : byte
    {
        [Display(Name = "مدیر سیستم")]
        Admin = 1,

        [Display(Name = "کاربر عادی")]
        User = 2
    }
}
