using System.Windows.Forms;

namespace ПР7
{
    public partial class Form1 : Form
    {/* Реалізуйте лінійний пошук для знаходження повідомлень у чаті за ключовим словом.*/
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                app ap = new app();
                ap.Text = textBox1.Text;
                ap.ShowDialog();
            }
            else { MessageBox.Show("Не введено ім'я"); }

        }
    }
}
