using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyTexasTripletest
    {
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var ttb = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ttb);
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Bun", () => {
                ttb.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Bun = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Cheese", () => {
                ttb.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Cheese = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Pickle", () => {
                ttb.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Pickle = false;
            });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Tomato", () => {
                ttb.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLetuce()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Lettuce", () => {
                ttb.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Ketchup", () => {
                ttb.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Mayo", () => {
                ttb.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Mustard", () => {
                ttb.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Mustard = false;
            });
        }

        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Bacon", () => {
                ttb.Bacon = false;
            });
        }

        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Egg", () => {
                ttb.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () => {
                ttb.Egg = false;
            });
        }
    }
}
