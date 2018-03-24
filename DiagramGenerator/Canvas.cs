/* Benny Skogberg
 * 2010-06-25
 * Canvas.cs
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DiagramGenerator
{
    class Canvas
    {
        /// <summary>
        /// The border in terms of list of points
        /// </summary>
        private List<Point> border = new List<Point>();

        /// <summary>
        /// Constructor who sets the border
        /// </summary>
        public Canvas()
        {
            border.Add(new Point(250, 30));
            border.Add(new Point(870, 30));
            border.Add(new Point(870, 30));
            border.Add(new Point(870, 595));
            border.Add(new Point(870, 595));
            border.Add(new Point(250, 595));
            border.Add(new Point(250, 595));
            border.Add(new Point(250, 30));
        }

        /// <summary>
        /// Property returning the border
        /// </summary>
        public List<Point> Border
        {
            get { return border; }
        }
    }
}
