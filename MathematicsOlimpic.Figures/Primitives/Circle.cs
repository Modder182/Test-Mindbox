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

        // ������ �����
        public double Radius { get; }

        #endregion

        // ����
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("������ ����� �� ����� ����� �������������!!!");
            Radius = radius;
        }

        #region Function

        // ��������� ������� �����
        protected sealed override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        #endregion
    }
}