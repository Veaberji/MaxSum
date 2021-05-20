using MaxSum;
using NUnit.Framework;
using System;
using System.IO;

namespace MaxSumTests
{
    [TestFixture]
    class UserInteractionTests
    {
        [Test]
        public void InputPath_PathEntered_ReturnPath()
        {
            string path = "abc";

            using (var sr = new StringReader(path))
            {
                Console.SetIn(sr);
                var result = UserInteraction.InputPath();

                Assert.AreEqual(path, result);
            }
        }

        [Test]
        public void SelectPath_PathArgumentProvided_ReturnPath()
        {
            string[] args = { "abc", "d" };

            UserInteraction.SelectPath(args);
            string expected = "abc";
            Assert.AreEqual(args[0], expected);
        }

        [Test]
        public void SelectPath_NoArguments_ReturnAPathFromTheConsole()
        {
            string[] args = { };
            string path = "abc";

            using (var sr = new StringReader(path))
            {
                Console.SetIn(sr);
                var result = UserInteraction.SelectPath(args);

                Assert.AreEqual(path, result);
            }
        }
    }
}
