using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationOrderTakingTerminal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("No : " + textBox3.Text + " / " + "First Name: " + textBox1.Text + " " + "Surname: " + textBox2.Text + " / " 
                             + "Job Position: " + textBox4.Text + " / " + "Salary: " + textBox5.Text + " / " + "Gender: " + Gender() + " / " 
                             + "Marital Status: " + MaritalStatus());
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Gender()
        {
            if (radioButton1.Checked == true)
                return "Male";
            else
                return "Female";
        }

        public string MaritalStatus()
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.Text == "Single")
                return "Single";
            else
                return "Maried";
        }
    }
}
