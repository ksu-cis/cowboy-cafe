using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyDakotaDoubleBurgertest
    {
        [Fact]
        public void DakotaDoubleBurgerImplementsINotifyPropertyChanged()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ddb);
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Bun", () => {
                ddb.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Bun = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Cheese", () => {
                ddb.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Cheese = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Pickle", () => {
                ddb.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Pickle = false;
            });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Tomato", () => {
                ddb.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLetuce()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Lettuce", () => {
                ddb.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Ketchup", () => {
                ddb.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Mayo", () => {
                ddb.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Mustard", () => {
                ddb.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () => {
                ddb.Mustard = false;
            });
        }
    }
}
