using NUnit.Framework;
using TriangleApp;
namespace TriangleAppTest
{
    [TestFixture]
    public class UnitTest
    {

        string triangle;

        [Test]
        public void Equilateral_Threesides_Five()
        {
            int a = 5, b = 5, c = 5;
            triangle = "This is an Equilateral Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a,b,c));
        }

        [Test]
        public void Equilateral_ThreeSides_Ten()
        {
            int a = 10, b = 10, c = 10;
            triangle = "This is an Equilateral Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a, b, c));
        }

        [Test]
        public void Isocelues_sideA_and_SideB_five()
        {
            int a = 5, b = 5, c = 4;
            triangle = "This is an Isoceles Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a, b, c));
        }

        [Test]
        public void Isocelues_sideA_and_SideC_Ten()
        {
            int a = 10, b = 15, c = 10;
            triangle = "This is an Isoceles Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a, b, c));
        }

        [Test]
        public void Isocelues_sideB_and_SideC_Eight()
        {
            int a = 15, b = 8, c = 8;
            triangle = "This is an Isoceles Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a, b, c));
        }

        [Test]
        public void Scalene_Five_Eight_Ten()
        {
            int a = 5, b = 8, c = 10;
            triangle = "This is a Scalene Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a, b, c));
        }

        [Test]
        public void Scalene_Ten_Fifteen_Twenty()
        {
            int a = 10, b = 15, c = 20;
            triangle = "This is a Scalene Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a, b, c));
        }

        [Test]
        public void Scalene_Ten_Twenty_Twentyfive()
        {
            int a = 10, b = 20, c = 25;
            triangle = "This is a Scalene Triangle";
            Assert.AreEqual(triangle, TriangleSolver.Analyze(a, b, c));
        }
    }
}