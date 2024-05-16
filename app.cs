using Microsoft.EntityFrameworkCore;
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
using ПР7.DB;

namespace ПР7
{
    public partial class app : Form
    {
        Dbase mes;
        public app()
        {
            InitializeComponent();
            mes=new Dbase();
            mes.Database.EnsureCreated();
            mes.UserMes.Load();
            foreach (var item in mes.UserMes)
            {
                string l= item.Name + ":" + item.Message;
                listBox1.Items.Add(l); 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string mess = $"{this.Text}:{textBox1.Text}";
                mes.Add(new UserMessage { Name = this.Text,Message=textBox1.Text }) ;
                listBox1.Items.Add(mess);
                textBox1.Text = "";
                mes.SaveChanges();
            }
            else
            {
                MessageBox.Show("Порожнє повідомлення.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (textBox1.Text != "")
            {
                foreach (var item in mes.UserMes)
                {
                    if (item.Message.Contains(textBox1.Text)) { listBox2.Items.Add(item.Message); }
                }
            }
            else
            {
                MessageBox.Show("Введіть текст для пошуку.");
            }
        }
    }
}
