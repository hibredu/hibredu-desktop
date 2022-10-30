using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hibredu.Data;

public class Context : DbContext
{
	public Context()
    {
    }

	public Context(DbContextOptions<Context> options) : base(options)
	{
		Database.EnsureCreated();
	}

	public DbSet<Student> Students { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Student>().HasData(GetStudents());
		base.OnModelCreating(modelBuilder);
	}

	private static Student[] GetStudents()
	{
		return new Student[]
		{
			new Student
			{
				Id = Guid.NewGuid(),
				Name = "João Pedro",
				Average = 8.5,
				Frequency = 0.9
			},
			new Student
			{
				Id = Guid.NewGuid(),
				Name = "Ana vitória",
				Average = 9.5,
				Frequency = 1.0
			},
			new Student
			{
				Id = Guid.NewGuid(),
				Name = "Pedro de Alcântara João Carlos Leopoldo Salvador Bibiano Francisco Xavier de Paula Leocádio Miguel Gabriel Rafael Gonzaga ",
				Average = 9.4,
				Frequency = 0.8
			},
		};
	}
}