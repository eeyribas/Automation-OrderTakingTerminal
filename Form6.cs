using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationOrderTakingTerminal
{
    public partial class Form6 : Form
    {
        private SerialPort serialPort;
        private string readData;

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.PortName = textBox1.Text;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = textBox3.Text;
            listViewItem.SubItems.Add(textBox4.Text);
            listView1.Items.Add(listViewItem);

            label5.Text = textBox3.Text;
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                listView1.Items.Remove(item);

            label6.Text = "()";
            label8.Text = "()";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] list = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                list[i] = Convert.ToDouble(listView1.Items[i].SubItems[1].Text.ToString());
                sum += list[i];
            }

            label6.Text = Convert.ToString(sum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sumPrice = Convert.ToDouble(label6.Text);
            double ratio = Convert.ToDouble(textBox2.Text);
            double newPrice = sumPrice * (100 - ratio) / 100;
            label8.Text = Convert.ToString(newPrice);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            readData = serialPort.ReadLine();
            this.Invoke(new EventHandler(Displaydata_Events));
        }

        private void Displaydata_Events(Object sender, EventArgs e)
        {
            textBox3.AppendText(readData);
        }
    }
}
