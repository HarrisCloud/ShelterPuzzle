using ShelterBuddy.CodePuzzle.Core.Entities;

namespace ShelterBuddy.CodePuzzle.Core.DataAccess
{
    public interface IAnimalRepository : IRepository<Animal, Guid>
    {
    }
}
