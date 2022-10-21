using ShelterBuddy.CodePuzzle.Core.DataAccess;
using Shouldly;
using Xunit;
using NSubstitute;
using ShelterBuddy.CodePuzzle.Core.Entities;
using ShelterBuddy.CodePuzzle.Core.Service;

namespace ShelterBuddy.CodePuzzle.Core.Tests.DataAccess
{
    public class AnimalServiceTests
    {
        [Fact]
        public void GetAll_ContainsData_IsValid()
        {
            var allAnimals = (
                new List<Animal>()
                {
                    new Animal() { AgeYears = 3, AgeWeeks = 1, Name = "Bob" },
                    new Animal() { AgeYears = 2, AgeWeeks = 5, Name = "Mary" },
                }).AsQueryable();
            
            var animalRepository = Substitute.For<IAnimalRepository>();
            animalRepository
                .GetAll()
                .ReturnsForAnyArgs(allAnimals);

            var sut = new AnimalService(animalRepository);

            var animals = sut.GetAll();
            animals.ShouldNotBeEmpty();
            animals.Count().ShouldBe(2);
            animals.ShouldContain(animal => animal.Name == "Bob");
        }

        [Fact]
        public void GetAll_HasNoData_IsValid()
        {
            var allAnimals = (new List<Animal>()).AsQueryable();

            var animalRepository = Substitute.For<IAnimalRepository>();
            animalRepository
                .GetAll()
                .ReturnsForAnyArgs(allAnimals);

            var sut = new AnimalService(animalRepository);

            var animals = sut.GetAll();
            animals.ShouldBeEmpty();
        }

    }
}
