namespace ShelterBuddy.CodePuzzle.Core.Entities;

public class Animal : BaseEntity<Guid>
{
    public string? Name { get; set; }
    public string? Colour { get; set; }
    public string? MicrochipNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime? DateInShelter { get; set; }
    public DateTime? DateLost { get; set; }
    public DateTime? DateFound { get; set; }
    public int? AgeYears { get; set; }
    public int? AgeMonths { get; set; }
    public int? AgeWeeks { get; set; }

    public Animal()
    {

    }

    public Animal(Guid id)
    {
        Id = id;
    }

    public string AgeText => (AgeYears == null || AgeWeeks == null)
        ? "Age Not Provided" 
        : $"{ AgeYears } years {AgeWeeks} weeks";
}