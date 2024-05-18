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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = comboBox1.Text;
            listViewItem.SubItems.Add(listBox1.Text);
            listViewItem.SubItems.Add(textBox1.Text);
            listViewItem.SubItems.Add(Unit());
            listView1.Items.Add(listViewItem);

            textBox1.Clear();
            listBox1.ClearSelected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                listView1.Items.Remove(item);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            int i = 1;
            int j = 1;
            foreach (ListViewItem item in listView1.Items)
            {
                ws.Cells[i, j] = item.Text.ToString();
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    ws.Cells[i, j] = subitem.Text.ToString();
                    j++;
                }

                j = 1;
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        public String Unit()
        {
            return "$";
        }
    }
}
