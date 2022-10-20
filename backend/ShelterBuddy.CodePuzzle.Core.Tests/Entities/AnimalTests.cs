﻿using ShelterBuddy.CodePuzzle.Core.Entities;
using Shouldly;
using Xunit;

namespace ShelterBuddy.CodePuzzle.Core.Tests.Entities;

public class AnimalTests
{
    [Theory]
    [InlineData(7, 3)]
    [InlineData(1, 2)]
    public void Animal_AgeText_IsValid(int ageYears, int ageWeeks)
    {
        var animal = new Animal
        {
            AgeYears = ageYears,
            AgeWeeks = ageWeeks
        };
        
        animal.AgeText.ShouldBe($"{ageYears} years {ageWeeks} weeks");
    }
}