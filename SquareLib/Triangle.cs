namespace SquareLib
{
    /// <summary>
    /// Труегольник
    /// </summary>
    public class Triangle : Figure
    {
        double a;
        double b;
        double c;
        double perimeter;
        double halfPerimeter;
        bool rightTriangle;

        public bool IsRightTriangle => rightTriangle;

        /// <summary>
        /// Конструктор, создающий конкретную фигуру - треугольник
        /// </summary>
        /// <param name="side1">Длина стороны треугольника</param>
        /// <param name="side2">Длина стороны треугольника</param>
        /// <param name="side3">Длина стороны треугольника</param>
        public Triangle(double side1, double side2, double side3)
        {
            rightTriangle = false;
            a = side1;
            b = side2;
            c = side3;
            perimeter = a + b + c;
            halfPerimeter = perimeter / 2;
            square = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            rightTriangle = CheckForRight();
        }

        /// <summary>
        /// Метод проверки треугольника, прямоугольный он или нет
        /// </summary>
        /// <returns></returns>
        private bool CheckForRight()
        {
            double A = a;
            double B = b;
            double C = c;
            double maxval;
            if (a > b)
            {
                maxval = a;
                A = 0;
                if (a < c)
                {
                    maxval = c;
                    A = a;
                    C = 0;
                }
            }
            else
            {
                maxval = b;
                B = 0;
                if (b < c)
                {
                    maxval = c;
                    B = b;
                    C = 0;
                }
            }
            if (Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(maxval, 2))
            {
                return true;
            }
            return false;
        }
    }
}
