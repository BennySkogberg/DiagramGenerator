/* Benny Skogberg
 * 2010-06-25
 * Help.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramGenerator
{
    class Help
    {
        /// <summary>
        /// A text to help the user know what to do.
        /// </summary>
        private String helptext =
            "Instructions\n" +
            "Start by clicking Reset-button or using the\n" +
            "menu File > New. Choose the number of intervals\n" + 
            "and steps of the diagram, and klick Done-button.\n" +
            "The no of X interval determines how many lines ends\n" +
            "up on the X axle.\n" +
            "X interval Step is the distance between the lines\n" +
            "on the X axle.\n\n" + 
            "The Y axle works in the same way as the X axle.\n\n" +
            "You can also randomize a graph using the Numeric\n" +
            "Up-Down control.\n\n" +
            "On the menu Data you can choose to sort the Graph by\n" +
            "X-values or by Y-values.\n\n" + 
            "Keep track (and edit) values of the database using the\n" +
            "Graph Editor on tha Data menu.";

        /// <summary>
        /// Property to return the helpText variable
        /// </summary>
        public String HelpText
        {
            get { return helptext; }
        }
    }
}
