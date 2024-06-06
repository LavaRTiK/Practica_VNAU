namespace NP._9._8F
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Число А";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Число Б";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 9);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Математичні дії";
            // 
            // button1
            // 
            button1.Location = new Point(228, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(228, 72);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSubtract_Click;
            // 
            // button3
            // 
            button3.Location = new Point(228, 101);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonMultiply_Click;
            // 
            // button4
            // 
            button4.Location = new Point(309, 43);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonDivide_Click;
            // 
            // button5
            // 
            button5.Location = new Point(309, 72);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "^";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonPowClick;
            // 
            // button6
            // 
            button6.Location = new Point(309, 101);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Корень";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonSQRT_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(304, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 160);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 12;
            label4.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 192);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox3;
        private Label label4;
    }
}
