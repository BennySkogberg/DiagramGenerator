/* Benny Skogberg
 * 2010-06-25
 * Compare.cs
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DiagramGenerator
{
    class Compare: IComparable
    {
        /// <summary>
        /// A method to decide which value is grater than
        /// the other.
        /// </summary>
        /// <param name="point1">point 1 (X or Y)</param>
        /// <param name="point2">point 2 (X or Y)</param>
        /// <returns>true if point 1 is grater than point 2, false otherwise</returns>
        public Boolean CompareTo(int point1, int point2)
        {
            if (point1 > point2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Implement IComparable interface, not used in this
        /// version of the application
        /// </summary>
        /// <param name="obj">Takes any object</param>
        /// <returns>throw exception as this point</returns>
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
