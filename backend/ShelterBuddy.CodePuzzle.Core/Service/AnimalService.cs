using ShelterBuddy.CodePuzzle.Core.DataAccess;
using ShelterBuddy.CodePuzzle.Core.Entities;

namespace ShelterBuddy.CodePuzzle.Core.Service
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            this.animalRepository = animalRepository;
        }

        public IList<Animal> GetAll()
        {
            return animalRepository
                .GetAll()
                .OrderBy(animal => animal.Name)
                .Select(animal => animal)
                .ToArray();
        }
    }
}
