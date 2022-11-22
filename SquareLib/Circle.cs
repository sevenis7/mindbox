namespace SquareLib
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : Figure
    {
        double _radius;

        /// <summary>
        /// Конструктор, создающий конкретную фигуру - окружность
        /// </summary>
        /// <param name="radius">Длина радиуса</param>
        public Circle(double radius)
        {
            _radius = radius;
            square = Math.PI * Math.Pow(radius, 2); 
        }
    }
}
