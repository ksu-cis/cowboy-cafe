using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests
{
    public class OrderTest
    {
        /// <summary>
        /// generic order item for testing purposes
        /// </summary>
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialInstructions { get; set; }
        }

        /// <summary>
        /// should be able to add items to the order
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            Order order = new Order(0);
            IOrderItem food = new MockOrderItem();
            order.Add(food);
            Assert.Contains<IOrderItem>(food, order.Items);
        }

        /// <summary>
        /// should be able to remove items from order
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            Order order = new Order(0);
            IOrderItem food = new MockOrderItem();
            order.Add(food);
            Assert.Contains<IOrderItem>(food, order.Items);
            order.Remove(food);
            Assert.DoesNotContain<IOrderItem>(food, order.Items);
        }


        /// <summary>
        /// should give inumeration of all items in order
        /// </summary>
        [Fact]
        public void ShouldGiveAnInumerationOfItems()
        {
            var order = new Order(0);
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


        /// <summary>
        /// Should give correct subtotal of prices
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSubtotal()
        {
            var order = new Order(0);

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

        /// <summary>
        /// Adding an item should trigger property change events
        /// </summary>
        /// <param name="propertyName"></param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order(0);
            var item = new MockOrderItem();
            item.Price = 1;
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        /// <summary>
        /// adding an items hould trigger property change events
        /// </summary>
        /// <param name="propertyName"></param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order(0);
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }
    }
}
