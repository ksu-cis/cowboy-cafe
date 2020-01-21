using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var chili = new CowpokeChili();
            Assert.Equal(6.10, chili.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var chili = new CowpokeChili();
            Assert.Equal<uint>(171, chili.Calories);
        }

        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            var ingredients = new List<string>()
            {
                "beef",
                "pinto beans",
                "vegetable stock",
                "tomato sauce",
                "onion",
                "spices",
                "cheese",
                "sour cream",
                "green onions",
                "tortilla strips"
            };
            var chili = new CowpokeChili();
            Assert.Equal(ingredients, chili.Ingredients);
        }

        [Fact]
        public void HoldingCheeseShouldNotListAsIngredient()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            Assert.DoesNotContain("cheese", chili.Ingredients);
        }

        [Fact]
        public void HoldingSourCreamShouldNotListAsIngredient()
        {
            var chili = new CowpokeChili();
            chili.SourCream = false;
            Assert.DoesNotContain("sour cream", chili.Ingredients);
        }

        [Fact]
        public void HoldingGreenOnionsShouldNotListAsIngredient()
        {
            var chili = new CowpokeChili();
            chili.GreenOnions = false;
            Assert.DoesNotContain("green onions", chili.Ingredients);
        }

        [Fact]
        public void HoldingTortillaStripsShouldNotListAsIngredient()
        {
            var chili = new CowpokeChili();
            chili.TortillaStrips = false;
            Assert.DoesNotContain("tortilla strips", chili.Ingredients);
        }
    }
}