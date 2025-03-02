using Xunit;
using FisherYatesWebApp;  // Ensure the right namespace for your FisherYates class
using System;
using System.Linq;

namespace FisherYatesTests
{
    public class FisherYatesTests
    {
        private readonly FisherYates _fisherYates;

        public FisherYatesTests()
        {
            _fisherYates = new FisherYates();
        }

        // Test 1: Ensure that the shuffled result contains the same elements as the input
        [Fact]
        public void Shuffle_ShouldContainSameElements()
        {
            // Arrange
            string input = "A-B-C-D";

            // Act
            var result = _fisherYates.Shuffle(input);

            // Split input and result into arrays for comparison
            var inputElements = input.Split('-');
            var resultElements = result.Split('-');

            // Assert that all input elements are present in the result
            Assert.True(inputElements.All(e => resultElements.Contains(e)));
            Assert.True(resultElements.All(e => inputElements.Contains(e)));
        }

        // Test 2: Ensure that the shuffled result is not the same as the input
        [Fact]
        public void Shuffle_ShouldNotReturnSameOrder()
        {
            // Arrange
            string input = "A-B-C-D";

            // Act
            var result = _fisherYates.Shuffle(input);

            // Assert: The shuffled result should be different from the input
            Assert.NotEqual(input, result);
        }

        // Test 3: Ensure that there are no duplicate elements in the shuffled result
        [Fact]
        public void Shuffle_ShouldNotContainDuplicates()
        {
            // Arrange
            string input = "A-B-C-D";

            // Act
            var result = _fisherYates.Shuffle(input);

            // Split result into elements and check for duplicates
            var resultElements = result.Split('-');
            
            // Assert that no element is repeated in the result
            Assert.Equal(resultElements.Length, resultElements.Distinct().Count());
        }

        // Test 4: Ensure that the shuffled result contains the same number of elements as the input
        [Fact]
        public void Shuffle_ShouldHaveSameNumberOfElements()
        {
            // Arrange
            string input = "A-B-C-D";

            // Act
            var result = _fisherYates.Shuffle(input);

            // Split input and result into arrays for comparison
            var inputElements = input.Split('-');
            var resultElements = result.Split('-');

            // Assert that the length of the input and result arrays are the same
            Assert.Equal(inputElements.Length, resultElements.Length);
        }
    }
}
