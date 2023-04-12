using NUnit.Framework;
using BubbleSortKata;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void GivenAnEmptyArrayReturnsEmptyArray()
        {
            //Arrange
            var testArray = new int[] { };

            //Act
            var output = BubbleSortClass.BubbleSort(testArray);

            //Assert
            Assert.That(output, Is.EqualTo(testArray));
        }
    }
}