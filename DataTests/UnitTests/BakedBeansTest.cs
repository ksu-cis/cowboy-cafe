using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
/*
namespace CowboyCafe.DataTests
{
    public class BakedBeansTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            BakedBeans beans = new BakedBeans();
            Assert.Equal(1.59, beans.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            BakedBeans beans = new BakedBeans();
            Assert.Equal<uint>(312, beans.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            BakedBeans beans = new BakedBeans();
            Assert.Equal<Size>(Size.Small, beans.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.59)]
        [InlineData(Size.Medium, 1.79)]
        [InlineData(Size.Large, 1.99)]
        public void ShouldUseCorrectPriceForSize(Size size, double price)
        {
            BakedBeans beans = new BakedBeans();
            beans.Size = Size.Medium;
            beans.Size = size;
            Assert.Equal(price, beans.Price);
        }

        [Theory]
        [InlineData(Size.Small, 312)]
        [InlineData(Size.Medium, 378)]
        [InlineData(Size.Large, 410)]
        public void ShouldUseCorrectCaloriesForSize(Size size, uint calories)
        {
            BakedBeans beans = new BakedBeans();
            beans.Size = Size.Medium;
            beans.Size = size;
            Assert.Equal<uint>(calories, beans.Calories);
        }
    }
}
*/