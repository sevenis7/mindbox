namespace SquareLib
{

    /// <summary>
    /// Статический класс для создания фигур
    /// </summary>
    public static class FigureCreator
    {
        /// <summary>
        /// Метод создания фигур
        /// </summary>
        /// <param name="parameteres">Массив параметров, если параметр один - создается окружность, если параметра 3 - создается треугольник,
        /// в других случаях создается NullFigure</param>
        /// <returns>Получаемая фигура</returns>
        public static Figure GetFigure(params double[] parameteres)
        {
            for(int i = 0; i < parameteres.Length; i++)
            {
                if (parameteres[i] <= 0) return new NullFigure();
            }
            if (parameteres.Length == 1) return new Circle(parameteres[0]);
            if (parameteres.Length == 3) return new Triangle(parameteres[0], parameteres[1], parameteres[2]);
            else return new NullFigure();
        }
    }
}
