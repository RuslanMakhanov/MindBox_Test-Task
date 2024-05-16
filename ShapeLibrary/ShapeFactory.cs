namespace ShapeLibrary
{
    public static class ShapeFactory
    {
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

        public static IShape CreateRectangle(double width, double height)
        {
            return new Rectangle(width, height);
        }
    }
}
