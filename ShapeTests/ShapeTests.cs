namespace ShapeTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.CalculateArea(), 1);
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea(), 1);
        }

        [Test]
        public void TestTriangleIsRightAngled()
        {
            var rightTriangle = new Triangle(3, 4, 5);
            Assert.IsTrue(rightTriangle.IsRightAngled());

            var notRightTriangle = new Triangle(3, 4, 6);
            Assert.IsFalse(notRightTriangle.IsRightAngled());
        }
    }
}