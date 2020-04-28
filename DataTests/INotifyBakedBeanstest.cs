using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyBakedBeanstest
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var bakedbeans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bakedbeans);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var bakedbeans = new BakedBeans();
            Assert.PropertyChanged(bakedbeans, "Price", () => {
                bakedbeans.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var bakedbeans = new BakedBeans();
            Assert.PropertyChanged(bakedbeans, "Calories", () => {
                bakedbeans.Size = Size.Large;
            });
        }
    }
}
