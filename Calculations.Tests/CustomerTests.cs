using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckNameNotEmpty() { 
            var customer = new Customer();
            Assert.NotNull(customer.name);
            Assert.False(string.IsNullOrEmpty(customer.name));
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = new Customer();
            Assert.InRange<int>(customer.age, 25, 40);
        }

        [Fact]
        public void getOrdersBynameNotNull()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.Equal("No name given || Is null", exceptionDetails.Message);
        }
    }
}
