using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Square
    {
        #region Field
        private double sideA;

        #endregion



        #region Proberties
        public double SideA
        {
            get { return this.sideA; }
            set { this.sideA = value; }
        }

        #endregion


        #region Constructor
        public Square(double sideA)
        {
            this.sideA = sideA;
            // return sideA;
        }
        #endregion


        #region Method
        public double CalcSides()
        {
            double sidesTotal = sideA * 4;
            return sidesTotal;
        }

        #endregion

        #region Method
        public double CalcArea()
        {
            double area = sideA * sideA;
            return area;
        }

        #endregion

    }
}
