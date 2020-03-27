using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyChilliCheeseFriestest
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var ccf = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ccf);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var ccf = new ChiliCheeseFries();
            Assert.PropertyChanged(ccf, "Price", () => {
                ccf.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var ccf = new ChiliCheeseFries();
            Assert.PropertyChanged(ccf, "Calories", () => {
                ccf.Size = Size.Large;
            });
        }
    }
}
