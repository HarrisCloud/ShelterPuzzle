using ShelterBuddy.CodePuzzle.Core.DataAccess;
using Shouldly;
using Xunit;
using ShelterBuddy.CodePuzzle.Core.Entities;

namespace ShelterBuddy.CodePuzzle.Core.Tests.DataAccess;

public class AnimalRepositoryTests
{
    [Fact]
    public void GetAll_CanLoadData_IsValid()
    {
        var sut = new AnimalRepository();
        var animals = sut.GetAll();
        animals.ShouldNotBeEmpty();
    }

    [Fact]
    public void Add_CanAddData_IsValid()
    {
        var sut = new AnimalRepository();
        var id = Guid.NewGuid();
        var animal = new Animal(id);

        sut.Add(animal);
        
        var result = sut.GetEntity(id);
        result.ShouldNotBeNull();
        result.Id.ShouldBe(id);
    }

    [Fact]
    public void Delete_CanDeleteData_IsValid()
    {
        var sut = new AnimalRepository();
        var id = Guid.NewGuid();
        var animal = new Animal(id);
        sut.Add(animal);
        
        sut.Delete(animal);

        var result = sut.GetEntity(id);
        result.ShouldNotBeNull();
        result.Id.ShouldBe(id);
        result.IsDeleted.ShouldBe(true);
    }

}