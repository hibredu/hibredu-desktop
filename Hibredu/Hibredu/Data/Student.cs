using System;

namespace Hibredu.Data;

public class Student
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public double Average { get; set; }

    public double Frequency { get; set; }
}