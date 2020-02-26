using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class OrderTest
    {
        //should be able to add items
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            Order order = new Order();
            IOrderItem food = new AngryChicken();
            order.Add(food);
            Assert.Contains<IOrderItem>(food, order.Items);
        }

        //should be able to remove items
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            Order order = new Order();
            IOrderItem food = new AngryChicken();
            order.Add(food);
            order.Remove(food);
            Assert.DoesNotContain<IOrderItem>(food, order.Items);
        }


        //should be able to get an inumeration of the items
        [Fact]
        public void ShouldGiveAnInumerationOfItems()
        {
            var order = new Order();
            order.Add(new AngryChicken());

        }


        //subtotal should be the sum of all item prices
        [Fact]
        public void ShouldHaveCorrectSubtotal()
        {

        }

        [Theory]
        [InlineData("Price")]
        [InlineData)"Items")]
        public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory]
        [InlineData("Price")]
        [InlineData)"Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }
    }
}
