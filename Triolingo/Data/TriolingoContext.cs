﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Triolingo.Data;

namespace Triolingo.Data
{
    public class TriolingoContext(DbContextOptions<TriolingoContext> options) : IdentityDbContext<TriolingoUser>(options)
    {
        public DbSet<Triolingo.Domain.UserInfo> UserInfo { get; set; } = default!;
        public DbSet<Triolingo.Domain.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}