using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsOlimpic.Figures.Primitives
{
    public class Circle : Figure
    {
        #region Properties

        // Радиус круга
        public double Radius { get; }

        #endregion

        // Крус
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус круга не может иметь отрицательным!!!");
            Radius = radius;
        }

        #region Function

        // Вычисляем площадь круга
        protected sealed override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        #endregion
    }
}