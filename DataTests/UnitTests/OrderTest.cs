using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class OrderTest
    {
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecailInstructions { get; set; }
        }

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
            IOrderItem item0 = new MockOrderItem();
            IOrderItem item1 = new MockOrderItem();
            IOrderItem item2 = new MockOrderItem();
            IOrderItem item3 = new MockOrderItem();
            IOrderItem item4 = new MockOrderItem();

            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);
            order.Add(item4);

            Assert.Contains<IOrderItem>(item0, order.Items);
            Assert.Contains<IOrderItem>(item1, order.Items);
            Assert.Contains<IOrderItem>(item2, order.Items);
            Assert.Contains<IOrderItem>(item3, order.Items);
            Assert.Contains<IOrderItem>(item4, order.Items);
        }


        //subtotal should be the sum of all item prices
        [Fact]
        public void ShouldHaveCorrectSubtotal()
        {
            var order = new Order();

            MockOrderItem item0 = new MockOrderItem();
            item0.Price = 0;
            order.Add(item0);
            MockOrderItem item1 = new MockOrderItem();
            item1.Price = 1.5;
            order.Add(item1);
            MockOrderItem item2 = new MockOrderItem();
            item2.Price = 69;
            order.Add(item2);
            MockOrderItem item3 = new MockOrderItem();
            item3.Price = 420;
            order.Add(item3);
            MockOrderItem item4 = new MockOrderItem();
            item0.Price = 0;
            order.Add(item4);

            Assert.Equal(420 + 69 + 1.5, order.Subtotal);
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
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
        [InlineData("Items")]
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
