/* Benny Skogberg
 * 2010-06-27
 * Axle.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagramGenerator
{
    class Validate
    {
        /// <summary>
        /// A constant determing the maximum range of intervals
        /// </summary>
        private const int intervalRange = 20;

        /// <summary>
        /// Determines wheter added value is within X-axle
        /// range or not
        /// </summary>
        /// <param name="xMax">the maximum value</param>
        /// <param name="xValue">the value to be checked</param>
        /// <returns>true if value is whitin range, false otherwise</returns>
        public Boolean InXRange(int xMax, int xValue)
        {
            if (xMax >= xValue)
                return true;
            else
            {
                MessageBox.Show("Your X-value exceeds X axle range!", "Out of Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Determines wheter added value is within Y-axle
        /// range or not
        /// </summary>
        /// <param name="xMax">the maximum value</param>
        /// <param name="xValue">the value to be checked</param>
        /// <returns>true if value is whitin range, false otherwise</returns>
        public Boolean InYRange(int yMax, int yValue)
        {
            if (yMax >= yValue)
                return true;
            else
            {
                MessageBox.Show("Your Y-value exceeds Y axle range!", "Out of Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Validates whether the value can be parsed as an integer
        /// </summary>
        /// <param name="text">the value to be parsed</param>
        /// <returns>true if numeric, false otherwise</returns>
        public Boolean IsInt(String text)
        {
            try
            {
                int.Parse(text);
                return true;
            }
            catch
            {
                MessageBox.Show("You can only use numbers without decimals!", "Not A Number",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Validates if the value is within interval range
        /// </summary>
        /// <param name="number">the interval to be checked</param>
        /// <returns>true if within range, false otherwise</returns>
        public Boolean IsInIntervalRange(int number)
        {
            if (number <= intervalRange)
                return true;
            else
            {
                MessageBox.Show("Please use interval equal to and less than 20.\n" +
                    "It will increase usability", "Interval Range Exceeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Validates if the value is over zero
        /// </summary>
        /// <param name="number">the value to be checked</param>
        /// <returns>true if value exceeds zero, false otherwise</returns>
        public Boolean IsNotZero(int number)
        {
            if (number > 0)
                return true;
            else
            {
                MessageBox.Show("Please use numbers exceeding zero.", "Number Can Not be Zero",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
