namespace NP._9._13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Число";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(26, 76);
            button1.Name = "button1";
            button1.Size = new Size(67, 65);
            button1.TabIndex = 2;
            button1.Text = "cos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCos_Click;
            // 
            // button2
            // 
            button2.Location = new Point(114, 76);
            button2.Name = "button2";
            button2.Size = new Size(67, 65);
            button2.TabIndex = 3;
            button2.Text = "sin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSin_Click;
            // 
            // button3
            // 
            button3.Location = new Point(198, 76);
            button3.Name = "button3";
            button3.Size = new Size(67, 65);
            button3.TabIndex = 4;
            button3.Text = "tg";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonTg_Click;
            // 
            // button4
            // 
            button4.Location = new Point(284, 76);
            button4.Name = "button4";
            button4.Size = new Size(67, 65);
            button4.TabIndex = 5;
            button4.Text = "ctg";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonCtg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 160);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Результат";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 214);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
    }
}
