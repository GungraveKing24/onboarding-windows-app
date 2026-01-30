using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WpfCalculator.ViewModels;

namespace TestingWPF.Tests
{
    [TestFixture]
    internal class CalculatorViewModelTests
    {
        [Test]
        public void Add_ReturnCorrecSum()
        {
            // Arrange
            var vm = new CalculatorViewModel();

            // Act
            var result = vm.Add(2, 3);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
