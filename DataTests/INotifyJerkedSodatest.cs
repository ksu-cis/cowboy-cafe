using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyJerkedSodatest
    {
        [Fact]
        public void JerkedSodaImplementsINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () => {
                soda.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () => {
                soda.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSodaFlavorPropertyShouldInvokePropertyChangedForSodaFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => {
                soda.Flavor = SodaFlavor.BirchBeer;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () => {
                soda.Ice = true;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => {
                soda.Ice = false;
            });
        }
    }
}
