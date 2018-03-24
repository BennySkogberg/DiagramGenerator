/* Benny Skogberg
 * 2010-06-26
 * GraphEditor.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiagramGenerator
{
    public partial class GraphEditor : Form
    {
        #region items to disable quit-button
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);
        #endregion

        /// <summary>
        /// The constructor
        /// </summary>
        public GraphEditor()
        {
            InitializeComponent();
            this.graphTableAdapter.Fill(this.diagramDBDataSet.Graph);
            this.intervalTableAdapter.Fill(this.diagramDBDataSet.Interval);
        }

        /// <summary>
        /// The binding source navigator save item
        /// </summary>
        /// <param name="sender">the object</param>
        /// <param name="e">the eventArgs</param>
        private void graphBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.graphBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagramDBDataSet);
        }

        /// <summary>
        /// Loading the database and filling the dataGridView
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void DatabaseEditor_Load(object sender, EventArgs e)
        {
            this.graphTableAdapter.Fill(this.diagramDBDataSet.Graph);
            this.intervalTableAdapter.Fill(this.diagramDBDataSet.Interval);

            // Disable quit-button on load
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }

        /// <summary>
        /// Method to add a row to the graph table in the database
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="point">point</param>
        public void AddGraphRow(int index, Point point)
        {
            DiagramDBDataSet.GraphRow graphRow;
            graphRow = diagramDBDataSet.Graph.NewGraphRow();
            graphRow.graphID = index;
            graphRow.xPoint = point.X;
            graphRow.yPoint = point.Y;
            this.diagramDBDataSet.Graph.Rows.Add(graphRow);
            UpdateGridView();
        }

        /// <summary>
        /// Method to discard the old interval and add a new one
        /// </summary>
        /// <param name="xInterval">the X interval</param>
        /// <param name="xStep">the number of X staps</param>
        /// <param name="yInterval">the Y interval</param>
        /// <param name="yStep">the number of Y steps</param>
        public void NewInterval(int xInterval, int xStep, int yInterval, int yStep)
        {
            if (diagramDBDataSet.Interval.Count != 0)
            {
                DiagramDBDataSet.IntervalRow oldIntervalRow;
                oldIntervalRow = diagramDBDataSet.Interval.FindByIntervalID(0);
                oldIntervalRow.Delete();
            }
            DiagramDBDataSet.IntervalRow intervalRow;
            intervalRow = diagramDBDataSet.Interval.NewIntervalRow();
            intervalRow.IntervalID = 0;
            intervalRow.xInterval = xInterval;
            intervalRow.xStep = xStep;
            intervalRow.yInterval = yInterval;
            intervalRow.yStep = yStep;
            this.diagramDBDataSet.Interval.Rows.Add(intervalRow);
            UpdateGridView();
        }

        /// <summary>
        /// Method to update the GridView and database
        /// </summary>
        private void UpdateGridView()
        {
            this.Validate();
            this.graphBindingSource.EndEdit();
            this.intervalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagramDBDataSet);
        }

        /// <summary>
        /// Delete table rows in graph and interval tables
        /// </summary>
        public void ClearTableRows()
        {
            int size = diagramDBDataSet.Graph.Count;
            for (int i = size; i > 0; i--)
            {
                DiagramDBDataSet.GraphRow oldGraphRow;
                oldGraphRow = diagramDBDataSet.Graph.FindBygraphID(i);
                oldGraphRow.Delete();
            }

            if (diagramDBDataSet.Interval.Count != 0)
            {
                DiagramDBDataSet.IntervalRow oldIntervalRow;
                oldIntervalRow = diagramDBDataSet.Interval.FindByIntervalID(0);
                oldIntervalRow.Delete();
            }

            UpdateGridView();
        }

        /// <summary>
        /// Method to clear the graph table for random
        /// </summary>
        public void ClearForRandom()
        {
            int size = diagramDBDataSet.Graph.Count;
            for (int i = size; i > 0; i--)
            {
                DiagramDBDataSet.GraphRow oldGraphRow;
                oldGraphRow = diagramDBDataSet.Graph.FindBygraphID(i);
                oldGraphRow.Delete();
            }
            UpdateGridView();
        }

        /// <summary>
        /// Method to get the interval from the database
        /// </summary>
        /// <returns>the interval</returns>
        public List<int> IntervalFromDB()
        {
            List<int> interval = new List<int>();
            int size = diagramDBDataSet.Interval.Count;

            // This isn't necessary at this stage, however it might come in
            // handy in the future saving more than one Interval
            for (int i = 0; i < size; i++)
            {
                DiagramDBDataSet.IntervalRow intervalRow;
                intervalRow = diagramDBDataSet.Interval.FindByIntervalID(i);
                interval.Add(intervalRow.xInterval);
                interval.Add(intervalRow.xStep);
                interval.Add(intervalRow.yInterval);
                interval.Add(intervalRow.yStep);
            }
            return interval;
        }

        /// <summary>
        /// Method to load graph from database
        /// </summary>
        /// <returns>the graph</returns>
        public List<int> GraphFromDB()
        {
            List<int> graph = new List<int>();
            int size = diagramDBDataSet.Graph.Count;

            for (int i = 1; i <= size; i++)
            {
                DiagramDBDataSet.GraphRow graphRow;
                graphRow = diagramDBDataSet.Graph.FindBygraphID(i);
                graph.Add(graphRow.xPoint);
                graph.Add(graphRow.yPoint);
            }
            return graph;
        }
    }
}
