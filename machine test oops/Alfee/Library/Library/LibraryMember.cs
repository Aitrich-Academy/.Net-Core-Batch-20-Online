using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    public abstract class LibraryMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }

        public LibraryMember(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }
        public abstract double CalculateFine(int overdueDays);
    }
}

public class StudentMember : LibraryMember
{
    public StudentMember(int memberId, string name) : base(memberId,name)
    {
    }
    private double CalculateStudentFine(int overdueDys)
    {
        return overdueDys * 1.0;
    }
    public override double CalculateFine(int overdueDays)
    {
        return CalculateStudentFine(overdueDays);
    }
}

public class FacultyMember : LibraryMember
{
    public FacultyMember(int memberId, string name) : base(memberId, name)
    {
    }
    public double CalculateFacultyFine(int overdueDays)
    {
        return overdueDays * 0.5;
    }
    public override double CalculateFine(int overdueDays)
    {
        return CalculateFacultyFine(overdueDays);
    }
}