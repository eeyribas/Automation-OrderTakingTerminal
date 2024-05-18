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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(Selected1());
            listViewItem.SubItems.Add(Selected2());
            listViewItem.SubItems.Add(textBox1.Text);
            listView1.Items.Add(listViewItem);

            textBox1.Clear();
            listBox1.ClearSelected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(Selected1());
            listViewItem.SubItems.Add(Selected2());
            listViewItem.SubItems.Add(textBox1.Text);
            listView2.Items.Add(listViewItem);

            textBox1.Clear();
            listBox1.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(Selected1());
            listViewItem.SubItems.Add(Selected2());
            listViewItem.SubItems.Add(textBox1.Text);
            listView3.Items.Add(listViewItem);

            textBox1.Clear();
            listBox1.ClearSelected();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(Selected1());
            listViewItem.SubItems.Add(Selected2());
            listViewItem.SubItems.Add(textBox1.Text);
            listView4.Items.Add(listViewItem);

            textBox1.Clear();
            listBox1.ClearSelected();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(Selected1());
            listViewItem.SubItems.Add(Selected2());
            listViewItem.SubItems.Add(textBox1.Text);
            listView5.Items.Add(listViewItem);

            textBox1.Clear();
            listBox1.ClearSelected();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(Selected1());
            listViewItem.SubItems.Add(Selected2());
            listViewItem.SubItems.Add(textBox1.Text);
            listView6.Items.Add(listViewItem);

            textBox1.Clear();
            listBox1.ClearSelected();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                listView1.Items.Remove(item);

            label6.Text = "()";
            label9.Text = "()";
            textBox2.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] items = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                items[i] = Convert.ToDouble(listView1.Items[i].SubItems[3].Text.ToString());
                sum += items[i];
            }

            label6.Text = Convert.ToString(sum);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sumPrice = Convert.ToDouble(label6.Text);
            double ratio = Convert.ToDouble(textBox2.Text);
            double newPrice = sumPrice * (100 - ratio) / 100;
            label9.Text = Convert.ToString(newPrice);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
                listView2.Items.Remove(item);

            label15.Text = "()";
            label12.Text = "()";
            textBox3.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] items = new double[listView2.Items.Count];
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                items[i] = Convert.ToDouble(listView2.Items[i].SubItems[3].Text.ToString());
                sum += items[i];
            }

            label15.Text = Convert.ToString(sum);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double sumPrice = Convert.ToDouble(label15.Text);
            double ratio = Convert.ToDouble(textBox3.Text);
            double newPrice = sumPrice * (100 - ratio) / 100;
            label12.Text = Convert.ToString(newPrice);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView3.SelectedItems)
                listView3.Items.Remove(item);

            label20.Text = "()";
            label17.Text = "()";
            textBox4.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] items = new double[listView3.Items.Count];
            for (int i = 0; i < listView3.Items.Count; i++)
            {
                items[i] = Convert.ToDouble(listView3.Items[i].SubItems[3].Text.ToString());
                sum += items[i];
            }

            label20.Text = Convert.ToString(sum);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double sumPrice = Convert.ToDouble(label20.Text);
            double ratio = Convert.ToDouble(textBox4.Text);
            double newPrice = sumPrice * (100 - ratio) / 100;
            label17.Text = Convert.ToString(newPrice);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView4.SelectedItems)
                listView4.Items.Remove(item);

            label25.Text = "()";
            label22.Text = "()";
            textBox5.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] items = new double[listView4.Items.Count];
            for (int i = 0; i < listView4.Items.Count; i++)
            {
                items[i] = Convert.ToDouble(listView4.Items[i].SubItems[3].Text.ToString());
                sum += items[i];
            }

            label25.Text = Convert.ToString(sum);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double sumPrice = Convert.ToDouble(label25.Text);
            double ratio = Convert.ToDouble(textBox5.Text);
            double newPrice = sumPrice * (100 - ratio) / 100;
            label22.Text = Convert.ToString(newPrice);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView5.SelectedItems)
                listView5.Items.Remove(item);

            label30.Text = "()";
            label27.Text = "()";
            textBox6.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] items = new double[listView5.Items.Count];
            for (int i = 0; i < listView5.Items.Count; i++)
            {
                items[i] = Convert.ToDouble(listView5.Items[i].SubItems[3].Text.ToString());
                sum += items[i];
            }

            label30.Text = Convert.ToString(sum);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double sumPrice = Convert.ToDouble(label30.Text);
            double ratio = Convert.ToDouble(textBox6.Text);
            double newPrice = sumPrice * (100 - ratio) / 100;
            label27.Text = Convert.ToString(newPrice);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView6.SelectedItems)
                listView6.Items.Remove(item);

            label35.Text = "()";
            label32.Text = "()";
            textBox7.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] items = new double[listView6.Items.Count];
            for (int i = 0; i < listView6.Items.Count; i++)
            {
                items[i] = Convert.ToDouble(listView6.Items[i].SubItems[3].Text.ToString());
                sum += items[i];
            }

            label35.Text = Convert.ToString(sum);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double sumPrice = Convert.ToDouble(label35.Text);
            double ratio = Convert.ToDouble(textBox7.Text);
            double newPrice = sumPrice * (100 - ratio) / 100;
            label32.Text = Convert.ToString(newPrice);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0 || comboBox1.Text == "Corbalar")
            {
                listBox1.Items.Add("Tarha Çorbası");
                listBox1.Items.Add("Mercimek Çorbası");
                listBox1.Items.Add("Yogurt Çorbası");
                listBox1.Items.Add("Ezogelin Çorbası");
                listBox1.Items.Add("Domates Çorbası");
                listBox1.Items.Add("İşkembe Çorbası");
                listBox1.Items.Add("Kelle Paça Çorbası");
                listBox1.Items.Add("Sebze Çorbası");
            }
            else if (comboBox1.SelectedIndex == 1 || comboBox1.Text == "Ana Yemekler")
            {
                listBox1.Items.Add("Pilav");
                listBox1.Items.Add("Nohut Yemeği");
                listBox1.Items.Add("Fasulye Yemeği");
                listBox1.Items.Add("İskender Kebap");
                listBox1.Items.Add("Tavuk Şiş");
                listBox1.Items.Add("Patates Yemeği");
                listBox1.Items.Add("Köri Soslu Tavuk");
            }
            else if (comboBox1.SelectedIndex == 2 || comboBox1.Text == "Mezeler")
            {
                listBox1.Items.Add("Patates Püresi");
                listBox1.Items.Add("Rus Salatası");
                listBox1.Items.Add("Mevsim Salatası");
                listBox1.Items.Add("Çoban Salatası");
                listBox1.Items.Add("Domates Kızartma");
                listBox1.Items.Add("Soğan Kavurma");
                listBox1.Items.Add("Börek");
                listBox1.Items.Add("Lavaş");
                listBox1.Items.Add("Kızarmış Kaşar");
            }
            else if (comboBox1.SelectedIndex == 3 || comboBox1.Text == "Tatlılar")
            {
                listBox1.Items.Add("Baklava");
                listBox1.Items.Add("Tulumba");
                listBox1.Items.Add("Süt Helvası");
                listBox1.Items.Add("Revani");
                listBox1.Items.Add("Tel Kadayıfı");
            }
            else
            {
                listBox1.Items.Add("Kola");
                listBox1.Items.Add("Fanta");
                listBox1.Items.Add("Ayran");
                listBox1.Items.Add("Şalgam Suyu");
                listBox1.Items.Add("Su");
                listBox1.Items.Add("Meyve Suyu");
                listBox1.Items.Add("Gazoz");
                listBox1.Items.Add("Çay");
            }
        }

        public string Selected1()
        {
            if (radioButton1.Checked == true) 
                return "LARGE";
            else if (radioButton2.Checked == true) 
                return "MIDDLE";
            else if (radioButton3.Checked == true) 
                return "SMALL";
            else 
                return "NULL";
        }

        public string Selected2()
        {
            if (checkBox1.Checked == true) 
                return "SAUCE";
            else if (checkBox2.Checked == true) 
                return "PEPPER";
            else if (checkBox3.Checked == true) 
                return "SPICE";
            else if (checkBox1.Checked == true && checkBox2.Checked == true) 
                return "SAUCE + SPICE";
            else if (checkBox1.Checked == true && checkBox3.Checked == true) 
                return "SAUCE + PEPPER";
            else if (checkBox2.Checked == true && checkBox3.Checked == true) 
                return "SPICE + PEPPER";
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true) 
                return "SAUCE + SPICE + PEPPER";
            else 
                return "NULL";
        }
    }
}
