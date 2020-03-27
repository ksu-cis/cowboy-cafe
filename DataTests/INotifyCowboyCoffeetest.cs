using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyCowboyCoffeetest
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () => {
                coffee.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () => {
                coffee.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () => {
                coffee.Decaf = true;
            });
        }

        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.Decaf = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () => {
                coffee.RoomForCream = true;
            });
        }

        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () => {
                coffee.Ice = true;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.Ice = false;
            });
        }
    }
}
