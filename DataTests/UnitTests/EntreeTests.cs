using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class EntreeTests
    {
        [Theory]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(AngryChicken))]
        public void TypeShouldBeAnEntree(Type type)
        {
            var entree = Activator.CreateInstance(type);
            Assert.IsAssignableFrom<Entree>(entree);
        }
    }
}
