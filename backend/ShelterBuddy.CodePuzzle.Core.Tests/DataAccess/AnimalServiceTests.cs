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
        public class Init
        {
            public IAnimalRepository animalRepository { get; set; }

            public Init()
            {
                animalRepository = Substitute.For<IAnimalRepository>();
            }

            public AnimalService GetSut()
            {
                return new AnimalService(animalRepository);
            }
        }

        [Fact]
        public void New_CanLoadData_IsValid()
        {
            var init = new Init();
            var result = (
                new List<Animal>() 
                { 
                    new Animal() { AgeYears = 2, AgeWeeks = 5, Name = "Bob" } 
                }).AsQueryable();

            init.animalRepository
                .GetAll()
                .ReturnsForAnyArgs(result);
            
            var sut = init.GetSut();

            var animals = sut.GetAll();
            animals.ShouldNotBeEmpty();
            animals.Count().ShouldBe(1);
            animals.ShouldContain(animal => animal.Name == "Bob");
        }
    }
}
