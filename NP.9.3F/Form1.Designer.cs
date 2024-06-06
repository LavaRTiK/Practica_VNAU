namespace NP._9._3F
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
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            price1 = new Label();
            price2 = new Label();
            price3 = new Label();
            price4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox1 = new TextBox();
            total = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Виберіть розмір фоту";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 36);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Ціна,шт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 267);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Кількість фото";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 405);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "До спалти";
            // 
            // button1
            // 
            button1.Location = new Point(29, 314);
            button1.Name = "button1";
            button1.Size = new Size(252, 63);
            button1.TabIndex = 4;
            button1.Text = "Обрахунок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // price1
            // 
            price1.AutoSize = true;
            price1.Location = new Point(231, 76);
            price1.Name = "price1";
            price1.Size = new Size(36, 20);
            price1.TabIndex = 5;
            price1.Text = "0,00";
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Location = new Point(231, 122);
            price2.Name = "price2";
            price2.Size = new Size(36, 20);
            price2.TabIndex = 6;
            price2.Text = "0,00";
            // 
            // price3
            // 
            price3.AutoSize = true;
            price3.Location = new Point(231, 173);
            price3.Name = "price3";
            price3.Size = new Size(36, 20);
            price3.TabIndex = 7;
            price3.Text = "0,00";
            // 
            // price4
            // 
            price4.AutoSize = true;
            price4.Location = new Point(231, 223);
            price4.Name = "price4";
            price4.Size = new Size(36, 20);
            price4.TabIndex = 8;
            price4.Text = "0,00";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "9*12";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(29, 118);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "10*15";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(29, 171);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(68, 24);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "18*24";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(29, 221);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 24);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "25*35";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(231, 405);
            total.Name = "total";
            total.Size = new Size(36, 20);
            total.TabIndex = 14;
            total.Text = "0,00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 450);
            Controls.Add(total);
            Controls.Add(textBox1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(price4);
            Controls.Add(price3);
            Controls.Add(price2);
            Controls.Add(price1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " Photo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label price1;
        private Label price2;
        private Label price3;
        private Label price4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox1;
        private Label total;
    }
}
