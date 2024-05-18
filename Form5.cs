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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add("Street:" + comboBox1.Text);
            listBox3.Items.Add("No:" + listBox1.Text);
            listBox3.Items.Add(textBox1.Text);
            listBox3.Items.Add("Center");
            listBox3.Items.Add("KÜTAHYA");
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox2.Text;
            listViewItem.SubItems.Add(textBox2.Text);
            listView1.Items.Add(listViewItem);

            textBox2.Clear();
            listBox2.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] list = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++) 
            {
                list[i] = Convert.ToDouble(listView1.Items[i].SubItems[1].Text.ToString());
                sum += list[i];
            }

            label7.Text = Convert.ToString(sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                listView1.Items.Remove(item);
            label7.Text = "()";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            textBox2.Clear();
            textBox1.Clear();
            listView1.Items.Clear();

            MessageBox.Show("The order has been sent...", "Notification!!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0 || comboBox1.Text == "Meydan")
            {
                listBox1.Items.Add("Osman");
                listBox1.Items.Add("Köşebaşı");
                listBox1.Items.Add("Merkez");
                listBox1.Items.Add("Sultan");
                listBox1.Items.Add("7.");
                listBox1.Items.Add("Karanfil");

            }
            else if (comboBox1.SelectedIndex == 1 || comboBox1.Text == "Osmanlı")
            {
                listBox1.Items.Add("Belircik");
                listBox1.Items.Add("Menekşe");
                listBox1.Items.Add("Atatürk");
                listBox1.Items.Add("Şehit");
                listBox1.Items.Add("11.");
                listBox1.Items.Add("Hisar");

            }
            else if (comboBox1.SelectedIndex == 2 || comboBox1.Text == "Atakent")
            {
                listBox1.Items.Add("Saygılı");
                listBox1.Items.Add("Sıran Sögüt");
                listBox1.Items.Add("Kanuni Sultan");
                listBox1.Items.Add("Cumhuriyet");
                listBox1.Items.Add("İstiklal");
                listBox1.Items.Add("Adnan Menderes");

            }
            else if (comboBox1.SelectedIndex == 3 || comboBox1.Text == "Laleli")
            {
                listBox1.Items.Add("Bahçe");
                listBox1.Items.Add("Okul");
                listBox1.Items.Add("Köypınar");
                listBox1.Items.Add("Barış");
                listBox1.Items.Add("Bandak");
                listBox1.Items.Add("Nalbant");

            }
            else if (comboBox1.SelectedIndex == 4 || comboBox1.Text == "Paşa")
            {
                listBox1.Items.Add("Kerimoğlu");
                listBox1.Items.Add("Kavaklı Dere");
                listBox1.Items.Add("Cevizli");
                listBox1.Items.Add("Avcılar");
                listBox1.Items.Add("Bayrak");
                listBox1.Items.Add("Çeşmeli");

            }
            else
            {
                listBox1.Items.Add("30 Ağustos");
                listBox1.Items.Add("Kocatepe");
                listBox1.Items.Add("Namık Kemal");
                listBox1.Items.Add("Sarıkaya");
                listBox1.Items.Add("Fatih");
                listBox1.Items.Add("Yunus Emre");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (comboBox2.SelectedIndex == 0 || comboBox2.Text == "Corbalar")
            {
                listBox2.Items.Add("Tarha Çorbası");
                listBox2.Items.Add("Mercimek Çorbası");
                listBox2.Items.Add("Yogurt Çorbası");
                listBox2.Items.Add("Ezogelin Çorbası");
                listBox2.Items.Add("Domates Çorbası");
                listBox2.Items.Add("İşkembe Çorbası");
                listBox2.Items.Add("Kelle Paça Çorbası");
                listBox2.Items.Add("Sebze Çorbası");

            }
            else if (comboBox2.SelectedIndex == 1 || comboBox2.Text == "Ana Yemekler")
            {
                listBox2.Items.Add("Pilav");
                listBox2.Items.Add("Nohut Yemeği");
                listBox2.Items.Add("Fasulye Yemeği");
                listBox2.Items.Add("İskender Kebap");
                listBox2.Items.Add("Tavuk Şiş");
                listBox2.Items.Add("Patates Yemeği");
                listBox2.Items.Add("Köri Soslu Tavuk");

            }
            else if (comboBox2.SelectedIndex == 2 || comboBox2.Text == "Mezeler")
            {
                listBox2.Items.Add("Patates Püresi");
                listBox2.Items.Add("Rus Salatası");
                listBox2.Items.Add("Mevsim Salatası");
                listBox2.Items.Add("Çoban Salatası");
                listBox2.Items.Add("Domates Kızartma");
                listBox2.Items.Add("Soğan Kavurma");
                listBox2.Items.Add("Börek");
                listBox2.Items.Add("Lavaş");
                listBox2.Items.Add("Kızarmış Kaşar");

            }
            else if (comboBox2.SelectedIndex == 3 || comboBox2.Text == "Tatlılar")
            {
                listBox2.Items.Add("Baklava");
                listBox2.Items.Add("Tulumba");
                listBox2.Items.Add("Süt Helvası");
                listBox2.Items.Add("Revani");
                listBox2.Items.Add("Tel Kadayıfı");

            }
            else
            {
                listBox2.Items.Add("Kola");
                listBox2.Items.Add("Fanta");
                listBox2.Items.Add("Ayran");
                listBox2.Items.Add("Şalgam Suyu");
                listBox2.Items.Add("Su");
                listBox2.Items.Add("Meyve Suyu");
                listBox2.Items.Add("Gazoz");
                listBox2.Items.Add("Çay");
            }
        }
    }
}
