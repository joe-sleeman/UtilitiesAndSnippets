using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectBoxSwapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generateSeedItems();
        }

        /// <summary>
        /// Will add an item to added items list.
        /// </summary>
        private void addItems()
        {
            // Find our checked items, and add them to added items list.
            foreach (int i in clbItems.CheckedIndices)
                clbAddedItems.Items.Add(clbItems.Items[i]);

            // Now lets remove them from the original item list.
            foreach (var item in clbItems.CheckedItems.OfType<string>().ToList())
                clbItems.Items.Remove(item);
        }

        /// <summary>
        /// Will remove an item from added items list.
        /// </summary>
        private void removeItems()
        {
            foreach (int i in clbAddedItems.CheckedIndices)
                clbItems.Items.Add(clbAddedItems.Items[i]);

            foreach (var item in clbAddedItems.CheckedItems.OfType<string>().ToList())
                clbAddedItems.Items.Remove(item);
        }

        private void removeAllItems()
        {
            foreach (var item in clbAddedItems.CheckedItems.OfType<string>().ToList())
                clbAddedItems.Items.Remove(item);
            foreach (var item in clbItems.CheckedItems.OfType<string>().ToList())
                clbItems.Items.Remove(item);
        }

        /// <summary>
        /// Generate a bunch of seed items for when the application starts.
        /// </summary>
        private void generateSeedItems()
        {
            clbItems.Items.Add("When hungry, eat your rice.");
            clbItems.Items.Add("When tired, close your eyes.");
            clbItems.Items.Add("Fools may laugh at me");
            clbItems.Items.Add("but wise men");
            clbItems.Items.Add("will know");
            clbItems.Items.Add("what I mean.");
            clbItems.Items.Add("-Lin-Chi");
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            addItems();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeItems();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            string item = txtNewItem.Text;
            if (item.Length > 0)
                clbItems.Items.Add(item);
            else
                MessageBox.Show("Please enter a string in to the provided text box.", 
                    "No String Error");
        }

        private void btnPurge_Click(object sender, EventArgs e)
        {
            removeAllItems();
        }

    }
}
