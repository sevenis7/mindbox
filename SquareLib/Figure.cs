namespace SquareLib
{
    /// <summary>
    /// Реализация интерфейса IFigure
    /// </summary>
    public abstract class Figure : IFigure
    {
        /// <summary>
        /// Поле площади фигуры
        /// </summary>
        protected double square;

        /// <summary>
        /// Свойство площади фигуры
        /// </summary>
        public double Square
        {
            get
            {
                if (square <= 0)
                {
                    throw new Exception("Были введены неправильные параметры при создании фигуры");
                }
                return square;
            }
        }

    }
}
