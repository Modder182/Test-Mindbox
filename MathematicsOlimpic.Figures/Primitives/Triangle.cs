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

        // ������ �������
        public double OneSide { get; }
        // ������ �������
        public double TwoSide { get; }
        // ������ �������
        public double ThreeSide { get; }

        // �������� �� ����������� �������������.
        public bool IsRightAngle => _isRightAngle.Value;

        #endregion

        // ��� �����������
        public Triangle(double oneSide, double twoSide, double threeSide)
        {
            if (oneSide < 0 || twoSide < 0 || threeSide < 0)
                throw new ArgumentOutOfRangeException("������� �� ����� ����� ������������� ��������");

            OneSide = oneSide;
            TwoSide = twoSide;
            ThreeSide = threeSide;

            _isRightAngle = new Lazy<bool>(CheckIsRightAngle);
        }

        #region Functions
        // ���������, �������� �� ����������� �������������
        private bool CheckIsRightAngle()
        {
            var SideMax = new[] { OneSide, TwoSide, ThreeSide }.Max();
            var maxSideArea = SideMax * SideMax;
            return maxSideArea + maxSideArea == OneSide * OneSide + TwoSide * TwoSide + ThreeSide * ThreeSide;
        }

        // ��������� ������� ������������
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