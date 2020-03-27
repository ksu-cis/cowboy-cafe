using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyAngryChickentest
    {
        [Fact]
        public void AngryChickenImplementsINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () => {
                chicken.Bread = false;
            });
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => {
                chicken.Bread = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () => {
                chicken.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => {
                chicken.Pickle = false;
            });
        }
    }
}
