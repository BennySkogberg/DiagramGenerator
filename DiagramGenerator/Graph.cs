/* Benny Skogberg
 * 2010-06-25
 * Graph.cs
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DiagramGenerator
{
    class Graph
    {
        /// <summary>
        /// A field of the Graph by list of points
        /// </summary>
        private List<Point> lineGraph = new List<Point>();

        /// <summary>
        /// A Property to get and set the Graph
        /// </summary>
        public List<Point> LineGraph
        {
            get { return this.lineGraph; }
            set { this.lineGraph = value; }
        }
    }
}
