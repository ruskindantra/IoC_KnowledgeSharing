﻿using System;
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
        
        [Fact]
        public void accerlating_car_should_return_correct_speed()
        {
            var familyCar = new FamilyCar();
            familyCar.Accelerate().Should().Be(1);
            familyCar.Accelerate().Should().Be(2);
        }

        [Fact]
        public void decerlating_car_should_return_correct_speed()
        {
            var familyCar = new FamilyCar();
            familyCar.Accelerate();
            familyCar.Accelerate();

            familyCar.Decelerate().Should().Be(1);
        }
    }
}
