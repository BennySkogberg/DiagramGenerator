/* Benny Skogberg
 * 2010-06-25
 * Interval.cs
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DiagramGenerator
{
    class Interval
    {
        #region Fields
        /// <summary>
        /// List of points in interval x
        /// </summary>
        private List<Point> xInterval = new List<Point>();

        /// <summary>
        /// List of points in interval y
        /// </summary>
        private List<Point> yInterval = new List<Point>();

        /// <summary>
        /// List of strings of X value (the text)
        /// </summary>
        private List<String> xValue = new List<String>();

        /// <summary>
        /// List of strings of Y value (the text)
        /// </summary>
        private List<String> yValue = new List<String>();

        /// <summary>
        /// A constant to scale diagram correct
        /// </summary>
        private const Double scale = 480.0;

        /// <summary>
        /// The scale of x intervals
        /// </summary>
        private Double xScale;

        /// <summary>
        /// The scale of y intervals
        /// </summary>
        private Double yScale;

        /// <summary>
        /// The maximum value of X
        /// </summary>
        private int xMax;

        /// <summary>
        /// The maximum value of Y
        /// </summary>
        private int yMax;
        #endregion

        /// <summary>
        /// Constructor for setting up the interval
        /// </summary>
        /// <param name="xInterval">parameter for X interval</param>
        /// <param name="xStep">parameter for number of X steps</param>
        /// <param name="yInterval">parameter for Y interval</param>
        /// <param name="yStep">parameter for number of Y steps</param>
        /// <param name="origo">parameter for Origo</param>
        public Interval(int xInterval, int xStep, int yInterval, int yStep, Point origo)
        {
            SetUpIntervals(xInterval, xStep, yInterval, yStep, origo);
            XValue.Add("0");
            YValue.Add("0");
            this.xMax = xInterval * xStep;
            this.yMax = yInterval * yStep;
        }

        /// <summary>
        /// No arguments constructor
        /// </summary>
        public Interval() { }

        #region Properties
        /// <summary>
        /// Property of XInterval
        /// </summary>
        public List<Point> XInterval
        {
            get { return this.xInterval; }
            set { this.xInterval = value; }
        }

        /// <summary>
        /// Property of YInterval
        /// </summary>
        public List<Point> YInterval
        {
            get { return this.yInterval; }
            set { this.yInterval = value; }
        }

        /// <summary>
        /// Property of XValue
        /// </summary>
        public List<String> XValue
        {
            get { return this.xValue; }
            set { this.xValue = value; }
        }

        /// <summary>
        /// Property of YValues
        /// </summary>
        public List<String> YValue
        {
            get { return this.yValue; }
            set { this.yValue = value; }
        }

        /// <summary>
        /// Property of XScale
        /// </summary>
        public Double XScale
        {
            get { return this.xScale; }
            private set { this.xScale = value; }
        }

        /// <summary>
        /// Property of YScale
        /// </summary>
        public Double YScale
        {
            get { return this.yScale; }
            private set { this.yScale = value; }
        }

        /// <summary>
        /// Property of XMax
        /// </summary>
        public int XMax
        {
            get { return this.xMax; }
        }

        /// <summary>
        /// Property of YMax
        /// </summary>
        public int YMax
        {
            get { return this.yMax; }
        }
        #endregion

        /// <summary>
        /// Method to set up the interval
        /// </summary>
        /// <param name="xInter">the X interval</param>
        /// <param name="xStep">the number of X staps</param>
        /// <param name="yInter">the Y interval</param>
        /// <param name="yStep">the number of Y steps</param>
        /// <param name="origo">Origo of the graph</param>
        private void SetUpIntervals(int xInter, int xStep, int yInter, int yStep, Point origo)
        {
            int xI = xInter;
            int xS = xStep * (int)scale / (xStep * xInter);
            int yI = yInter;
            int yS = yStep * (int)scale / (yStep * yInter);
            Double dScale = scale;
            Double dxInter = xInter;
            Double dxStep = xStep;
            Double dyInter = yInter;
            Double dyStep = yStep;
            XScale = dScale / (dxStep * dxInter);
            YScale = dScale / (dyStep * dyInter);

            for (int x = 1; x <= xI; x++)
            {
                this.xInterval.Add(new Point(origo.X + xS * x, origo.Y - 5));
                this.xInterval.Add(new Point(origo.X + xS * x, origo.Y + 5));
                SetUpValue("x", xStep * x);
            }

            for (int y = 1; y <= yInter; y++)
            {
                this.yInterval.Add(new Point(origo.X - 5, origo.Y - yS * y));
                this.yInterval.Add(new Point(origo.X + 5, origo.Y - yS * y));
                SetUpValue("y", yStep * y);
            }
        }

        /// <summary>
        /// Method to Set up interval text
        /// </summary>
        /// <param name="axle">axle x or y</param>
        /// <param name="text">the text</param>
        private void SetUpValue(String axle, int text)
        {
            if (axle == "x")
                this.xValue.Add(text.ToString());
            else
                this.yValue.Add(text.ToString());
        }
    }
}
