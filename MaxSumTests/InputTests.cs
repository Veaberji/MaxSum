using MaxSum;
using NUnit.Framework;
using System;
using System.IO;

namespace MaxSumTests
{
    [TestFixture]
    class InputTests
    {
        [Test]
        public void UserPath_PathEntered_ReturnPath()
        {
            string path = "abc";

            using (var sr = new StringReader(path))
            {
                Console.SetIn(sr);
                var result = Input.UserPath();

                Assert.AreEqual(path, result);
            }
        }
    }
}
