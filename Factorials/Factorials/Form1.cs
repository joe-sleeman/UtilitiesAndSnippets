using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recursive version of factorial.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int recursiveFactorial(int n)
        {
            // If we are 1, simply return 1.
            if (n <= 1)
                return 1;
            // Otherwise, we want to call ourself, decrementing n.
            return n * recursiveFactorial(n - 1);
        }

        /// <summary>
        /// Iterative version of factorial.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int iterativeFactorial(int n)
        {
            // If we are 1 simply return 1.
            if (n <= 1)
                return 1;
            // Otherwise, instantiate result set to 1.
            int result = 1;
            // Loop until we get to n multiplying result by previous result.
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        /// <summary>
        /// Parse text from a text box.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        private int parseText(TextBox textBox)
        {
            try
            {
               return Int32.Parse(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Factorial only works on numbers!");
                return 0;
            }
        }

        private void btnIterative_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox1.Text);
            label1.Text = iterativeFactorial(n).ToString();
        }

        private void btnRecursive_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox1.Text);
            label1.Text = recursiveFactorial(n).ToString();
        }
    }
}
