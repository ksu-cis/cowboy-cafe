using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyPanDeCampotest
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var pdc = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pdc);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Price", () => {
                pdc.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Calories", () => {
                pdc.Size = Size.Large;
            });
        }
    }
}
