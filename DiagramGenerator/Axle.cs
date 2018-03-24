/* Benny Skogberg
 * 2010-06-25
 * Axle.cs
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DiagramGenerator
{
    class Axle
    {
        /// <summary>
        /// the xAxle points
        /// </summary>
        private List<Point> xAxle = new List<Point>();

        /// <summary>
        /// the yAxle points
        /// </summary>
        private List<Point> yAxle = new List<Point>();

        /// <summary>
        /// Origo point (x, y)
        /// </summary>
        private Point origo;

        /// <summary>
        /// The constructor adds the X and Y axle
        /// and their arrows
        /// </summary>
        public Axle()
        {
            yAxle.Add(new Point(350, 40));
            yAxle.Add(new Point(350, 550));
            yAxle.Add(new Point(345, 50));
            yAxle.Add(new Point(355, 50));

            xAxle.Add(new Point(850, 540));
            xAxle.Add(new Point(340, 540));
            xAxle.Add(new Point(840, 545));
            xAxle.Add(new Point(840, 535));

            origo = new Point(350, 540);
        }

        /// <summary>
        /// Property returning xAxle
        /// </summary>
        public List<Point> XAxle
        {
            get { return xAxle; }
        }

        /// <summary>
        /// Property returning yAxle
        /// </summary>
        public List<Point> YAxle
        {
            get { return yAxle; }
        }

        /// <summary>
        /// Property returning Origo
        /// </summary>
        public Point Origo
        {
            get { return origo; }
        }
    }
}
