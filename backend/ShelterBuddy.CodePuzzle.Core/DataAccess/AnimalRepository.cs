using ShelterBuddy.CodePuzzle.Core.Entities;

namespace ShelterBuddy.CodePuzzle.Core.DataAccess;

public class AnimalRepository : BaseRepository<Animal, Guid>, IAnimalRepository
{
    public AnimalRepository() : base()
    {
        Load("ShelterBuddy.CodePuzzle.Core.DataAccess.Data.Animals.json");
    }
}