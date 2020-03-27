using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyCowPokeChillitest
    {
        [Fact]
        public void CowPokeChilliImplementsINotifyPropertyChanged()
        {
            var cpc = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cpc);
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "Cheese", () => {
                cpc.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () => {
                cpc.Cheese = false;
            });
        }

        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SourCream", () => {
                cpc.SourCream = false;
            });
        }

        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () => {
                cpc.SourCream = false;
            });
        }

        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "GreenOnions", () => {
                cpc.GreenOnions = false;
            });
        }

        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () => {
                cpc.GreenOnions = false;
            });
        }

        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "TortillaStrips", () => {
                cpc.TortillaStrips = false;
            });
        }

        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () => {
                cpc.TortillaStrips = false;
            });
        }
    }
}
