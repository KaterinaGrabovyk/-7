using System.Windows.Forms;

namespace ПР7
{
    public partial class Form1 : Form
    {/* Реалізуйте лінійний пошук для знаходження повідомлень у чаті за ключовим словом.*/
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(dataFilePath2))
            {
                File.CreateText(dataFilePath2);
            }
        }
        string dataFilePath2 = "MESSEGES.txt";

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
