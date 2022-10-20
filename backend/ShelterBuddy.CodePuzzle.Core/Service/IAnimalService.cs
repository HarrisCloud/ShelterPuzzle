using ShelterBuddy.CodePuzzle.Core.Entities;

namespace ShelterBuddy.CodePuzzle.Core.Service
{
    public interface IAnimalService
    {
        IList<Animal> GetAll();
    }
}
