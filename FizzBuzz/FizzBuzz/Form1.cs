using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Common interview question.
        /// 
        /// Write a program that prints the numbers from 1 to 100, but for
        /// multiples of three print "Fizz", instead of the number and for
        /// the multiples of five print "Buzz". For numbers which are multiples
        /// of both three and fize print "FizzBuzz".
        /// </summary>
        String fizz = "Fizz";
        String buzz = "Buzz";
        String fizzBuzz = "FizzBuzz";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Main function. Figures out if n is fizz, buzz or fizzBuzz.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private String fizzBuzzer(int n)
        {
            if ((n % 3 == 0) && (n % 5 == 0))
                return fizzBuzz;
            else if (n % 3 == 0)
                return fizz;
            else if (n % 5 == 0)
                return buzz;
            else
                return n.ToString();
        }

        /// <summary>
        /// Loop method.
        /// </summary>
        /// <param name="listBox"></param>
        private void runFizzBuzz(ListBox listBox)
        {
            for (int i = 1; i <= 100; i++)
                listBox.Items.Add(fizzBuzzer(i));
        }

        /// <summary>
        /// Trigger.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            runFizzBuzz(listBox1);
        }
    }
}
