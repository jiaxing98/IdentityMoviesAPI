using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data;

public partial class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options) 
    {
    
    }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderMovie> OrderMovies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("movies_pkey");

            entity.ToTable("movies");

            entity.Property(e => e.MovieId).HasColumnName("movie_id");
            entity.Property(e => e.Genre)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("genre");
            entity.Property(e => e.Rating)
                .HasPrecision(2, 1)
                .HasColumnName("rating");
            entity.Property(e => e.ReleaseDate).HasColumnName("release_date");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.TotalPrice)
                .HasPrecision(5, 1)
                .HasColumnName("total_price");
        });

        modelBuilder.Entity<OrderMovie>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.MovieId }).HasName("order_movie_pkey");

            entity.ToTable("order_movie");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.MovieId).HasColumnName("movie_id");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");

            entity.HasOne(d => d.Movie).WithMany(p => p.OrderMovies)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_movie_movie_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderMovies)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_movie_order_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
