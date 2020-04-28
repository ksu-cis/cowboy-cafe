using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CornDodgersTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            CornDodgers cd = new CornDodgers();
            Assert.Equal(1.59, cd.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            CornDodgers cd = new CornDodgers();
            Assert.Equal<uint>(512, cd.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            CornDodgers cd = new CornDodgers();
            Assert.Equal<Size>(Size.Small, cd.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.59)]
        [InlineData(Size.Medium, 1.79)]
        [InlineData(Size.Large, 1.99)]
        public void ShouldUseCorrectPriceForSize(Size size, double price)
        {
            CornDodgers cd = new CornDodgers();
            cd.Size = Size.Medium;
            cd.Size = size;
            Assert.Equal(price, cd.Price);
        }

        [Theory]
        [InlineData(Size.Small, 512)]
        [InlineData(Size.Medium, 685)]
        [InlineData(Size.Large, 717)]
        public void ShouldUseCorrectCaloriesForSize(Size size, uint calories)
        {
            CornDodgers cd = new CornDodgers();
            cd.Size = Size.Medium;
            cd.Size = size;
            Assert.Equal<uint>(calories, cd.Calories);
        }
    }
}
