/* Benny Skogberg
 * 2010-06-25
 * MainForm.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagramGenerator
{
    public partial class MainForm : Form
    {
        #region Fields
        /// <summary>
        /// Instance of DrawDiagram, the diagram manager
        /// </summary>
        private DrawDiagram draw = new DrawDiagram();
        
        /// <summary>
        /// the position of the pointer
        /// </summary>
        private Point mousePosition = new Point();

        /// <summary>
        /// a boolean field indicating if interval is present
        /// </summary>
        private Boolean isInterval = false;

        /// <summary>
        /// a constant to adjust pointer i X
        /// </summary>
        private const Double xoff = 0.729;

        /// <summary>
        /// a constant to adjust constant in Y
        /// </summary>
        private const Double yoff = 0.125;

        /// <summary>
        /// a scaling constant
        /// </summary>
        private const Double scale = 480.0;
        #endregion
        
        /// <summary>
        /// The constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initializing method
        /// </summary>
        private void InitializeGUI()
        {
            gbxAddPoint.Enabled = false;
            gbxSettings.Enabled = false;
            gbxRandom.Enabled = false;
        }

        /// <summary>
        /// Paint the form
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">PaintEventArgs</param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        /// <summary>
        /// the Onpaint method
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawCanvas(e);
            DrawAxles(e);
            DrawInterval(e);
            DrawGraph(e);
            if (isInterval)
                DrawMouse(e);
            
            if (draw.HelpText)
                DrawHelpText(e);
        }

        /// <summary>
        /// Draw the mouse position
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void DrawMouse(PaintEventArgs e)
        {
            Font font = new Font("Verdana", 9);
            SolidBrush solidBrush = new SolidBrush(Color.DarkRed);
            Graphics g = e.Graphics;
            int x = 0;
            int y = 0;
            try
            {
                x = (int)(mousePosition.X * draw.Interval.XMax / scale) - (int)(draw.Interval.XMax * xoff);
                y = draw.Interval.YMax - (int)(mousePosition.Y * draw.Interval.YMax / scale) + (int)(draw.Interval.YMax * yoff);
            }
            catch
            {
                x = 0;
                y = 0;
            }
            g.DrawString("(" + x.ToString() + ", " + y.ToString() +")", font, solidBrush, 270, 35);
        }

        /// <summary>
        /// Draw the graph
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void DrawGraph(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen graphPen = new Pen(Color.Blue);
            for (int i = 0; i < draw.Graph.LineGraph.Count-1; i++)
            {
                g.DrawLine(graphPen, draw.Graph.LineGraph[i], draw.Graph.LineGraph[i + 1]);
            }
        }

        /// <summary>
        /// Write the help text
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void DrawHelpText(PaintEventArgs e)
        {
            Font font = new Font("Verdana", 10);
            Graphics g = e.Graphics;
            Help help = new Help();
            g.DrawString(help.HelpText, font, new SolidBrush(Color.Blue), 360, 40);
        }

        /// <summary>
        /// Draw the axles
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void DrawAxles(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen axlePen = new Pen(Color.Black, 1);
            for (int i = 1; i < 4; i++)
            {
                g.DrawLine(axlePen, draw.Axle.XAxle[0], draw.Axle.XAxle[i]);
                g.DrawLine(axlePen, draw.Axle.YAxle[0], draw.Axle.YAxle[i]);
            }
        }

        /// <summary>
        /// Draw the canvas (border)
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void DrawCanvas(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Canvas canvas = new Canvas();
            Pen pen = new Pen(Color.Gray, 1);
            for (int pt = 0; pt < canvas.Border.Count; pt = pt + 2)
            {
                g.DrawLine(pen, canvas.Border[pt], canvas.Border[pt + 1]);
            }
        }

        /// <summary>
        /// Draw the interval
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void DrawInterval(PaintEventArgs e)
        {
            if (draw.Interval.XInterval.Count > 1 || draw.Interval.YInterval.Count > 1)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Green, 1);

                int textPos = 0;
                int xl = draw.Interval.XInterval.Count - 1;
                for (int i = 0; i < xl; i = i + 2)
                {
                    g.DrawLine(pen, draw.Interval.XInterval[i], draw.Interval.XInterval[i + 1]);
                    DrawIntervalScale(e, draw.Interval.XInterval[i].X - 10, 555, textPos, "x");
                    textPos++;
                }

                int yl = draw.Interval.YInterval.Count - 1;
                textPos = 0;
                for (int i = 0; i < yl; i = i + 2)
                {
                    g.DrawLine(pen, draw.Interval.YInterval[i], draw.Interval.YInterval[i + 1]);
                    DrawIntervalScale(e, 300, draw.Interval.YInterval[i].Y-7, textPos, "y");
                    textPos++;
                }
            }
        }

        /// <summary>
        /// Draw the scale
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        /// <param name="x">value of x</param>
        /// <param name="y">value of y</param>
        /// <param name="textPos">the position of the text</param>
        /// <param name="axle">x or y axle</param>
        private void DrawIntervalScale(PaintEventArgs e, int x, int y, int textPos, String axle)
        {
            Font font = new Font("Verdana", 8);
            Graphics g = e.Graphics;
            SolidBrush type = new SolidBrush(Color.Green);
            if (axle == "y")
                g.DrawString(draw.Interval.YValue[textPos] , font, type, x, y);
            else
                g.DrawString(draw.Interval.XValue[textPos], font, type, x, y);
        }

        /// <summary>
        /// Set up a new interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (draw.IsInt(tbxXInterval.Text) && draw.IsInt(tbxXStep.Text) &&
                draw.IsInt(tbxYInterval.Text) && draw.IsInt(tbxYStep.Text))
            {
                int xInterval = int.Parse(tbxXInterval.Text);
                int xStep = int.Parse(tbxXStep.Text);
                int yInterval = int.Parse(tbxYInterval.Text);
                int yStep = int.Parse(tbxYStep.Text);
                if (draw.IsInIntervalRange(xInterval) && draw.IsInIntervalRange(yInterval) &&
                    draw.IsNotZero(xStep) && draw.IsNotZero(yStep) &&
                    draw.IsNotZero(xInterval) && draw.IsNotZero(yInterval) )
                {
                    gbxAddPoint.Enabled = true;
                    gbxSettings.Enabled = false;
                    gbxRandom.Enabled = true;
                    draw.NewInterval(xInterval, xStep, yInterval, yStep);
                    this.Refresh();
                    tbxXValue.Focus();
                }
            }
            isInterval = true;
        }

        /// <summary>
        /// Reset the interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Enable reset of interval
        /// </summary>
        private void Reset()
        {
            draw.ClearTableRows();
            gbxAddPoint.Enabled = false;
            gbxSettings.Enabled = true;
            gbxRandom.Enabled = false;
            draw.Graph = new Graph();
            isInterval = false;
            this.Refresh();
            tbxXInterval.Focus();
        }

        /// <summary>
        /// Add new value to graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddValue_Click(object sender, EventArgs e)
        {
            if (draw.IsInt(tbxXValue.Text) && draw.IsInt(tbxYValue.Text))
            {
                int x = int.Parse(tbxXValue.Text);
                int y = int.Parse(tbxYValue.Text);
                if (draw.InXRange(x) && draw.InYRange(y))
                {
                    draw.Graph.LineGraph.Add(new Point(draw.Axle.Origo.X +
                        (Convert.ToInt16(x * draw.Interval.XScale)),
                        draw.Axle.Origo.Y - Convert.ToInt16(y * draw.Interval.YScale)));
                    this.Refresh();
                    draw.AddPointToDB();
                    tbxXValue.Text = "";
                    tbxYValue.Text = "";
                    tbxXValue.Focus();
                }
            }
        }

        /// <summary>
        /// Displays help text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw.HelpText = true;
            this.Refresh();
            draw.HelpText = false;
        }

        /// <summary>
        /// Sort values of X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortXValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw.SortX();
            this.Refresh();
        }

        /// <summary>
        /// Sorts value of Y
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortYValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw.SortY();
            this.Refresh();
        }

        /// <summary>
        /// Show the graph editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void databaseEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw.ShowGraphEditor();
        }

        /// <summary>
        /// Show about box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        /// <summary>
        /// Set up for new interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Load values from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!draw.LoadInterval())
                MessageBox.Show(
                    "No interval in Database",
                    "Database Empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            if (!draw.LoadGraph())
            {
                MessageBox.Show(
                    "No graph in Database",
                    "No Graph Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                gbxAddPoint.Enabled = true;

            isInterval = true;
            this.Refresh();
        }

        /// <summary>
        /// Listen to position change of the mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition.X = e.X;
            mousePosition.Y = e.Y;
            int x = mousePosition.X - draw.Axle.Origo.X;
            int y = draw.Axle.Origo.Y - mousePosition.Y;
            if (x >= 0 && y >= 0)
            {
                this.Refresh();
            }
        }

        /// <summary>
        /// Random graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int random = (int)numUpDownRandom.Value;
            draw.Random(random);
            this.Refresh();
        }
    }
}
