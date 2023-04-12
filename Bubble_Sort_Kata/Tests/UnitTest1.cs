using NUnit.Framework;
using BubbleSortKata;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class BubbleSort
        {
            [Test]
            public void GivenAnEmptyArrayReturnsEmptyArray()
            {
                //Arrange
                var testArray = new int[] { };

                //Act
                var output = KataSortClass.BubbleSort(testArray);

                //Assert
                Assert.That(output, Is.EqualTo(testArray));
            }

            [Test]

            public void GivenAnArrayWithNElements_ReturnsArrayWithSameLength()
            {
                var testArray = new int[] { 1, 2, 3 };
                var output = KataSortClass.BubbleSort(testArray).Length;
                Assert.That(output, Is.EqualTo(3));
            }

            [Test]

            public void GivenAnArrayWithNElements_ReturnsArrayWithSameArraySortedLowToHigh()
            {
                var testArray = new int[] { 5, 1, -3, 3, 6 };
                var output = KataSortClass.BubbleSort(testArray);
                Assert.That(output, Is.EqualTo(new int[] { -3, 1, 3, 5, 6}));
            }
        }
        [TestFixture]
        public class MergeSort
        {
            [Test]
            public void GivenEmptyArrays_ReturnEmptyArray()
            {
                var testArray1 = new int[] { };
                var testArray2 = new int[] { };
                var output = KataSortClass.MergeSort(testArray1, testArray2);
                Assert.That(output, Is.EqualTo(new int[] { }));
            }

            [Test]
            public void GivenTwoArrays_IfOneIsEmpty_ReturnsArrayWithLengthOfOther()
            {
                var testArray1 = new int[] {1, 2, 3 };
                var testArray2 = new int[] { };
                var output = KataSortClass.MergeSort(testArray1, testArray2).Length;
                Assert.That(output, Is.EqualTo(3));
            }

            [Test]
            public void GivenTwoArrays_ReturnArrayWithCombinedLengthOfTwoInputs()
            {
                var testArray1 = new int[] { 1, 2, 3 };
                var testArray2 = new int[] { 1};
                var output = KataSortClass.MergeSort(testArray1, testArray2).Length;
                Assert.That(output, Is.EqualTo(4));
            }

            [Test]
            public void GivenTwoArrays_ReturnMergedArraySortedInAscendingOrder()
            {
                var testArray1 = new int[] { -2, -1, 4 };
                var testArray2 = new int[] { -1, 4, 10 };
                var output = KataSortClass.MergeSort(testArray1, testArray2);
                Assert.That(output, Is.EqualTo(new int[] {-2, -1, -1, 4, 4, 10}));
            }
            [Test]
            public void GivenTwoArraysOfDifferentLength_ReturnMergedArraySorted()
            {
                var testArray1 = new int[] { -2, 5};
                var testArray2 = new int[] { -1, 4, 4, 10, 50 };
                var output = KataSortClass.MergeSort(testArray1, testArray2);
                Assert.That(output, Is.EqualTo(new int[] {-2, -1, 4, 4, 5, 10, 50 }));
            }
            [Test]
            public void GivenANullArray_ThrowsException()
            {
                var testArray1 = new int[] { 1, 2, 3 };
                Assert.That(() => KataSortClass.MergeSort(testArray1, null), Throws.TypeOf<ArgumentException>());
            }
        }

    }

}