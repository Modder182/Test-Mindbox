using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsOlimpic.Figures.Primitives
{
    public class Triangle : Figure
    {
        #region Fields

        private readonly Lazy<bool> _isRightAngle;

        #endregion

        #region Properties

        // Первая сторона
        public double OneSide { get; }
        // Вторая сторона
        public double TwoSide { get; }
        // Третья сторона
        public double ThreeSide { get; }

        // Является ли треугольник прямоугольным.
        public bool IsRightAngle => _isRightAngle.Value;

        #endregion

        // Сам Треугольник
        public Triangle(double oneSide, double twoSide, double threeSide)
        {
            if (oneSide < 0 || twoSide < 0 || threeSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может иметь отрицательное значение");

            OneSide = oneSide;
            TwoSide = twoSide;
            ThreeSide = threeSide;

            _isRightAngle = new Lazy<bool>(CheckIsRightAngle);
        }

        #region Functions
        // Проверить, является ли треугольник прямоугольным
        private bool CheckIsRightAngle()
        {
            var SideMax = new[] { OneSide, TwoSide, ThreeSide }.Max();
            var maxSideArea = SideMax * SideMax;
            return maxSideArea + maxSideArea == OneSide * OneSide + TwoSide * TwoSide + ThreeSide * ThreeSide;
        }

        // Вычислить площадь треугольника
        protected sealed override double CalculateArea()
        {
            var semiPerimeter = (OneSide + TwoSide + ThreeSide) / 2;

            var oneSideValue = semiPerimeter - OneSide;
            var twoSideValue = semiPerimeter - TwoSide;
            var threeSideValue = semiPerimeter - ThreeSide;

            return Math.Sqrt(semiPerimeter * oneSideValue * twoSideValue * threeSideValue);
        }

        #endregion
    }
}