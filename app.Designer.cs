namespace ПР7
{
    partial class app
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(0, -2);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(499, 480);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 486);
            textBox1.MaxLength = 200;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(499, 80);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(513, 481);
            button1.Name = "button1";
            button1.Size = new Size(153, 85);
            button1.TabIndex = 2;
            button1.Text = "Надіслати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(697, 481);
            button2.Name = "button2";
            button2.Size = new Size(164, 85);
            button2.TabIndex = 3;
            button2.Text = "Знайти всі варіанти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(513, 79);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(365, 396);
            listBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 31);
            label1.Name = "label1";
            label1.Size = new Size(263, 28);
            label1.TabIndex = 5;
            label1.Text = "ЗНАЙДЕНІ ВАРІАНТИ";
            // 
            // app
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 578);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 4, 5, 4);
            Name = "app";
            Text = "app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox2;
        private Label label1;
    }
}