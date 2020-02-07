using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class ChilliCheeseFriesTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            ChilliCheeseFries fries = new ChilliCheeseFries();
            Assert.Equal(1.99, fries.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            ChilliCheeseFries fries = new ChilliCheeseFries();
            Assert.Equal<uint>(433, fries.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            ChilliCheeseFries fries = new ChilliCheeseFries();
            Assert.Equal<Size>(Size.Small, fries.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.99)]
        [InlineData(Size.Medium, 2.99)]
        [InlineData(Size.Large, 3.99)]
        public void ShouldUseCorrectPriceForSize(Size size, double price)
        {
            ChilliCheeseFries fries = new ChilliCheeseFries();
            fries.Size = Size.Medium;
            fries.Size = size;
            Assert.Equal(price, fries.Price);
        }

        [Theory]
        [InlineData(Size.Small, 433)]
        [InlineData(Size.Medium, 524)]
        [InlineData(Size.Large, 610)]
        public void ShouldUseCorrectCaloriesForSize(Size size, uint calories)
        {
            ChilliCheeseFries fries = new ChilliCheeseFries();
            fries.Size = Size.Medium;
            fries.Size = size;
            Assert.Equal<uint>(calories, fries.Calories);
        }
    }
}
