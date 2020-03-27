using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class INotifyTexasTeatest
    {
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () => {
                tea.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () => {
                tea.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () => {
                tea.Sweet = false;
            });
        }

        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => {
                tea.Sweet = false;
            });
        }

        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () => {
                tea.Lemon = true;
            });
        }

        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => {
                tea.Lemon = true;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () => {
                tea.Ice = true;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => {
                tea.Ice = false;
            });
        }
    }
}
