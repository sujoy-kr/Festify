﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<Activity> Activities { get; set; }
    }
}
