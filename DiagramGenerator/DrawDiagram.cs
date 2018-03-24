/* Benny Skogberg
 * 2010-06-25
 * DrawDiagram.cs
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DiagramGenerator
{
    class DrawDiagram
    {
        #region Fields
        /// <summary>
        /// the axle
        /// </summary>
        private Axle axle = new Axle();

        /// <summary>
        /// the interval
        /// </summary>
        private Interval interval = new Interval();

        /// <summary>
        /// the graph
        /// </summary>
        private Graph graph = new Graph();

        /// <summary>
        /// the helptext
        /// </summary>
        private Boolean helpText = false;

        /// <summary>
        /// validate instance
        /// </summary>
        private Validate validate = new Validate();

        /// <summary>
        /// compare instance
        /// </summary>
        private Compare compare = new Compare();

        /// <summary>
        /// the graphEditor
        /// </summary>
        private GraphEditor graphEditor = new GraphEditor();
        #endregion

        #region Properties
        /// <summary>
        /// the Property of axle
        /// </summary>
        public Axle Axle
        {
            get { return this.axle; }
            set { this.axle = value; }
        }

        /// <summary>
        /// the Property of interval
        /// </summary>
        public Interval Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        /// <summary>
        /// the Property of graph
        /// </summary>
        public Graph Graph
        {
            get { return this.graph; }
            set { this.graph = value; }
        }

        /// <summary>
        /// the Property of helpText
        /// </summary>
        public Boolean HelpText
        {
            get { return this.helpText; }
            set { this.helpText = value; }
        }
        #endregion

        /// <summary>
        /// Validates if X is in range of axle
        /// </summary>
        /// <param name="x">the x value</param>
        /// <returns>true if x is in range, false otherwise</returns>
        public Boolean InXRange(int x)
        {
            if (validate.InXRange(interval.XMax, x))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validates if Y is in range of axle
        /// </summary>
        /// <param name="y">the y value</param>
        /// <returns>true if y is in range, false otherwise</returns>
        public Boolean InYRange(int y)
        {
            if (validate.InYRange(interval.YMax, y))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validates if string can be parsed to int
        /// </summary>
        /// <param name="text">the string</param>
        /// <returns>true if string can be parsed, false otherwise</returns>
        public Boolean IsInt(String text)
        {
            if (validate.IsInt(text))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validates if interval is in range
        /// </summary>
        /// <param name="number">the number</param>
        /// <returns>true if interval is in range, false otherwise</returns>
        public Boolean IsInIntervalRange(int number)
        {
            if (validate.IsInIntervalRange(number))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validates if number is not zero
        /// </summary>
        /// <param name="number">the number</param>
        /// <returns>true if the number is not zero, false otherwise</returns>
        public Boolean IsNotZero(int number)
        {
            if (validate.IsNotZero(number))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Sort values in list in x-axle
        /// using insertion sort
        /// </summary>
        public void SortX()
        {
            int l = graph.LineGraph.Count;
            // implementing Insertion Sort
            for (int j = 0; j <= l; j++)
            {
                for (int i = 0; i < l-1; i++)
                {
                    if (compare.CompareTo(graph.LineGraph[i].X, graph.LineGraph[i + 1].X))
                    {
                        Point pointToMove = graph.LineGraph[i];
                        graph.LineGraph.RemoveAt(i);
                        graph.LineGraph.Insert(i + 1, pointToMove);
                    }
                }
            }
        }

        /// <summary>
        /// Sort values in list in y-axle
        /// using insertion sort
        /// </summary>
        public void SortY()
        {
            int l = graph.LineGraph.Count;
            // implementing Insertion Sort
            for (int j = 0; j <= l; j++)
            {
                for (int i = 0; i < l - 1; i++)
                {
                    if (compare.CompareTo(graph.LineGraph[i].Y, graph.LineGraph[i + 1].Y))
                    {
                        Point pointToMove = graph.LineGraph[i];
                        graph.LineGraph.RemoveAt(i);
                        graph.LineGraph.Insert(i + 1, pointToMove);
                    }
                }
            }
        }

        /// <summary>
        /// Displays the Graph Editor
        /// </summary>
        public void ShowGraphEditor()
        {
            graphEditor.Show();
        }

        /// <summary>
        /// Add current point to database
        /// </summary>
        public void AddPointToDB()
        {
            graphEditor.AddGraphRow(graph.LineGraph.Count, graph.LineGraph[graph.LineGraph.Count - 1]);
        }

        /// <summary>
        /// Method to set up a new interval
        /// </summary>
        /// <param name="xInterval">the x interval</param>
        /// <param name="xStep">the number of x steps</param>
        /// <param name="yInterval">the y interval</param>
        /// <param name="yStep">the number of y steps</param>
        public void NewInterval(int xInterval, int xStep, int yInterval, int yStep)
        {
            this.interval = new Interval(xInterval, xStep, yInterval, yStep, Axle.Origo);
            graphEditor.NewInterval(xInterval, xStep, yInterval, yStep);
        }

        /// <summary>
        /// Method to load interval from database
        /// </summary>
        /// <returns>true if load was possible, false otherwise</returns>
        public Boolean LoadInterval()
        {
            List<int> interval = graphEditor.IntervalFromDB();
            if (interval.Count > 0)
            {
                Interval = new Interval(interval[0], interval[1], interval[2], interval[3], Axle.Origo);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Method to load graph from database
        /// </summary>
        /// <returns>true if load was possible, false otherwise</returns>
        public Boolean LoadGraph()
        {
            List<int> graphDB = graphEditor.GraphFromDB();
            if (graphDB.Count > 0)
            {
                for (int i = 0; i < graphDB.Count; i = i + 2)
                {
                    graph.LineGraph.Add(new Point(graphDB[i], graphDB[i + 1]));
                }
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Clear the table rows of Graph Editor
        /// </summary>
        public void ClearTableRows()
        {
            graphEditor.ClearTableRows();
        }

        /// <summary>
        /// Method to make a random graph
        /// </summary>
        /// <param name="points">the number of points</param>
        public void Random(int points)
        {
            graphEditor.ClearForRandom();
            graph = new Graph();
            Random random = new System.Random();
            for (int i = 0; i < points; i++)
            {
                int x = random.Next(0, Interval.XMax + 1);
                int y = random.Next(0, Interval.YMax + 1);
                graph.LineGraph.Add(new Point(
                    axle.Origo.X + Convert.ToInt16(x * Interval.XScale), 
                    axle.Origo.Y - Convert.ToInt16(y * Interval.YScale)) );
                AddPointToDB();
            }
        }
    }
}
