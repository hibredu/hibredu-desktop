using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hibredu.Data;

public class Context : DbContext
{
	public List<Student> StudentsData { get; set; }

	public Context()
    {
		StudentsData = new List<Student>()
        {
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Gustavo",
			Average = 9.12,
			Frequency = 0.92
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Pedro",
			Average = 9.21,
			Frequency = 0.83
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Ana",
			Average = 8.17,
			Frequency = 0.85
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Caio",
			Average = 7.07,
			Frequency = 0.86
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Maria",
			Average = 7.53,
			Frequency = 0.85
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Carlos",
			Average = 8.11,
			Frequency = 0.68
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Lucas",
			Average = 6.97,
			Frequency = 0.81
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Gabriel",
			Average = 9.48,
			Frequency = 0.9
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Iuri",
			Average = 7.14,
			Frequency = 0.78
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Marcos",
			Average = 7.08,
			Frequency = 0.76
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Victor",
			Average = 8.45,
			Frequency = 0.77
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Miguel",
			Average = 6.89,
			Frequency = 1
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Evandro",
			Average = 7.8,
			Frequency = 0.79
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Renato",
			Average = 7.2,
			Frequency = 0.93
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "Fernando",
			Average = 8.04,
			Frequency = 0.79
			},
			new Student
			{
			Id = Guid.NewGuid(),
			Name = "João",
			Average = 8.01,
			Frequency = 0.84
			}
		};
    }
	public Context(DbContextOptions<Context> options) : base(options)
	{
		Database.EnsureCreated();
		StudentsData = Students.ToList();
	}

	public DbSet<Student> Students { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Student>().HasData(GetProducts());
		base.OnModelCreating(modelBuilder);
	}

	private static Student[] GetProducts()
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