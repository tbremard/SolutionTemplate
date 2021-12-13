using NUnit.Framework;

namespace Core.UnitTest
{
    public class ClassCoreTest
    {
        [Test]
        public void Hello_WhenCalled_ThenOk()
        {
            var sut = new ClassCore();

            var actual = sut.Hello();

            string expected = "blabla"; 
            Assert.AreEqual(expected, actual);
        }
    }
}
