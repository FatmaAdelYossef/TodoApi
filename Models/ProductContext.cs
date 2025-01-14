﻿using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options)
        : base(options)
    {
    }

    public DbSet<Product> products { get; set; } = null!;
}