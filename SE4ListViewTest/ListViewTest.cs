using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace SE4ListViewTest
{
    public partial class ListViewTest : Form
    {
        public ListViewTest()
        {
            InitializeComponent();

            var teachers = new List<string>
            {
                "Dominic", "Tim", "Rob", "Arno", "Vincent", "Jorien", "Dominic", "Hani"
            };

            teachers.ForEach(i => listView1.Items.Add(i));

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                listView1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedListViewItemCollection items = listView1.SelectedItems;

            foreach (ListViewItem item in items)
            {
                listView1.Items.Remove(item);
            }
        }
    }
}
