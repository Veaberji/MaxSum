using MaxSum;
using NUnit.Framework;

namespace MaxSumTests
{
    [TestFixture]
    public class CheckTests
    {
        [Test]
        public void UserPath_FileDoesNotExist_ThrowArgumentException()
        {

            Assert.That(() => Check.Path(""), Throws.ArgumentException);
        }

        [Test]
        public void Array_NullPassed_ThrowArgumentException()
        {
            Assert.That(() => Check.Array(null), Throws.ArgumentException);
        }
    }
}
