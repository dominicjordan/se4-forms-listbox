using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace SE4ListViewTest
{
    public partial class ListBoxTest : Form
    {
        public ListBoxTest()
        {
            InitializeComponent();

            var cars = new List<Car>
            {
                new Car("BMW", "X5"),
                new Car("BMW", "330i"),
                new Car("Audi", "A5"),
                new Car("Audi", "Q5"),
                new Car("VW", "Golf GTI")
            };

            cars.ForEach(x=>listBox1.Items.Add(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                listBox1.Items.Add(new Car(textBox1.Text, textBox2.Text));
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedObjectCollection items = listBox1.SelectedItems;
            for (int i = 0; i < items.Count; i++)
            {
                listBox1.Items.Remove(items[i]);
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Type { get; set; }

        public Car(string brand, string type)
        {
            Brand = brand;
            Type = type;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Brand, Type);
        }
    }
}
