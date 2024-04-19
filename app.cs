using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР7
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(dataFilePath2))
            {
                foreach (string l in sr.ReadToEnd().Split(";")) { listBox1.Items.Add(l); }
            }
        }
        string dataFilePath2 = "MESSEGES.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string mess = $"{this.Text}:{textBox1.Text}";
                File.AppendAllText(dataFilePath2, mess + ";");
                listBox1.Items.Add(mess);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Пусте повідомлення.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Clear();
            if (textBox1.Text != "")
            {
                foreach (string l in listBox1.Items)
                {
                    string[] arr = l.Split(":");
                    for (int i = 0; i < arr.Length; i++) {
                        if (i != 0)
                        {
                            if (arr[i].Contains(textBox1.Text))
                            {
                                list.Add(l);
                            }
                        }
                    }
                }
                listBox2.Items.AddRange(list.ToArray());
            }
            else
            {
                MessageBox.Show("Пусте повідомлення.");
            }
        }
    }
}
