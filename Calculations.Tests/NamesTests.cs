using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class NamesTests
    {
        [Fact]
        public void makeFullNameTest() { 
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karami");
            Assert.Equal("Aref Karami", result, ignoreCase: true);
            Assert.Contains("aref", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }
    }
}
