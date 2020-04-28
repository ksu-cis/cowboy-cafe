using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyPecosPulledPorktest
    {
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var pecospp = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pecospp);
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pecospp = new PecosPulledPork();
            Assert.PropertyChanged(pecospp, "Bread", () => {
                pecospp.Bread = false;
            });
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecospp = new PecosPulledPork();
            Assert.PropertyChanged(pecospp, "SpecialInstructions", () => {
                pecospp.Bread = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pecospp = new PecosPulledPork();
            Assert.PropertyChanged(pecospp, "Pickle", () => {
                pecospp.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecospp = new PecosPulledPork();
            Assert.PropertyChanged(pecospp, "SpecialInstructions", () => {
                pecospp.Pickle = false;
            });
        }
    }
}
