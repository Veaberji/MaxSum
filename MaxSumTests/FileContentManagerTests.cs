using MaxSum;
using NUnit.Framework;
using System.Collections.Generic;

namespace MaxSumTests
{
    [TestFixture]
    class FileContentManagerTests
    {
        [Test]
        public void GetMaxSumLine_ArrayWithStringOfNumbers_ReturnMaxSumLine()
        {
            var content = new string[]
            {
                "-1, 4, 7.54, 8",
                "2, 5.3, 8, 7",
                "3, -6, 9, 6",
                "4.2, 7, 0, -4",
            };
            int expected = 2;

            var manager = new FileContentManager(content);
            int result = manager.GetMaxSumLine();
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetMaxSumLine_EmptyArray_ReturnZero()
        {
            var content = new string[] { };
            int expected = 0;

            var manager = new FileContentManager(content);
            int result = manager.GetMaxSumLine();
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetDefectiveLines_WhenCalled_ReturnListOfDefectiveLines()
        {
            var content = new string[]
            {
                "-1, 4, 7.54, 8",
                "2, 5.#, 8, 7",
                "3, -6, !, 6",
                "4.2, 7, 0, -4",
            };
            var expected = new List<int> { 2, 3 };

            var manager = new FileContentManager(content);
            manager.GetMaxSumLine();
            var result = manager.GetDefectiveLines();
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetDefectiveLines_EmptyArray_ReturnAnEmptyList()
        {
            var content = new string[] { };
            var expected = new List<int>();

            var manager = new FileContentManager(content);
            manager.GetMaxSumLine();
            var result = manager.GetDefectiveLines();
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
