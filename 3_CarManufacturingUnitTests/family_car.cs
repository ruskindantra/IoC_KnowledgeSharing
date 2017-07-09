using System;
using CarManufacturing.Cars;
using CarManufacturing.Components;
using FluentAssertions;
using Xunit;

namespace CarManufacturingUnitTests
{
    public class family_car
    {
        [Fact]
        public void to_string_should_print_correct_value()
        {
            var familyCar = new FamilyCar();
            familyCar.ToString().Should().Be("FamilyCar");
        }

        /// <summary>
        /// Is this a valid unit test?
        /// </summary>
        [Fact]
        public void starting_car_twice_should_throw_exception()
        {
            var familyCar = new FamilyCar();
            Action startAction = () => familyCar.Start();

            startAction.ShouldNotThrow<EngineAlreadyStartedException>();
            startAction.ShouldThrow<EngineAlreadyStartedException>();
        }
    }
}
