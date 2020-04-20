using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsOlimpic
{
    public abstract class Figure
    {
        #region Fields

        private readonly Lazy<double> _area;

        #endregion

        #region Properties
        // Площадь фигуры
        public double Area => _area.Value;

        #endregion

        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        #region Functions
        // Вычислить площадь фигуры
        protected abstract double CalculateArea();

        #endregion
    }
}