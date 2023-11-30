global using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TriangleMethods.Tests
{
    [TestClass]
    public class TriangleMethodsTest
    {
        [TestMethod]
        public void RightTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            TriangleType result = TriangleMethods.GetType(a, b, c);
            Assert.AreEqual(TriangleType.Right, result);
        }

        [TestMethod]
        public void ObtuseTriangleTest()
        {
            double a = 8;
            double b = 15;
            double c = 18;
            TriangleType result = TriangleMethods.GetType(a, b, c);
            Assert.AreEqual(TriangleType.Obtuse, result);
        }

        [TestMethod]
        public void AcuteTriangleTest()
        {
            double a = 5;
            double b = 7;
            double c = 8;
            TriangleType result = TriangleMethods.GetType(a, b, c);
            Assert.AreEqual(TriangleType.Acute, result);
        }

        [TestMethod]
        public void NotTriangleTest()
        {
            double a = 1;
            double b = 2;
            double c = 4;
            Assert.ThrowsException<ArgumentException>(() => TriangleMethods.GetType(a, b, c));
        }
    }
}