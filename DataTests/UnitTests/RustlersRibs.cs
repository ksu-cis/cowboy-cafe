using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class RustlersRibsTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var ribs = new RustlersRibs();
            Assert.Equal(7.50, ribs.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var ribs = new RustlersRibs();
            Assert.Equal<uint>(894, ribs.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var ribs = new RustlersRibs();
            Assert.Empty(ribs.SpecialInstructions);
        }
    }
}
