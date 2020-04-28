using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyCornDodgertest
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var cd = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cd);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Price", () => {
                cd.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Calories", () => {
                cd.Size = Size.Large;
            });
        }
    }
}
