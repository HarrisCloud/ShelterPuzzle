using Microsoft.AspNetCore.Mvc;
using ShelterBuddy.CodePuzzle.Api.Models;
using ShelterBuddy.CodePuzzle.Core.Service;

namespace ShelterBuddy.CodePuzzle.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    private readonly IAnimalService animalService;

    public AnimalController(IAnimalService animalService)
    {
        this.animalService = animalService;
    }

    [HttpGet]
    public IEnumerable<AnimalModel> Get() => animalService
        .GetAll()
        .Select(animal => new AnimalModel
        {
            Id = $"{animal.Id}",
            Name = animal.Name,
            Colour = animal.Colour,
            DateFound = animal.DateFound,
            DateLost = animal.DateLost,
            MicrochipNumber = animal.MicrochipNumber,
            DateInShelter = animal.DateInShelter,
            DateOfBirth = animal.DateOfBirth,
            AgeText = animal.AgeText,
            AgeMonths = animal.AgeMonths,
            AgeWeeks = animal.AgeWeeks,
            AgeYears = animal.AgeYears
        });

    [HttpPost]
    public void Post(AnimalModel newAnimal)
    {
        throw new NotImplementedException();
    }
}