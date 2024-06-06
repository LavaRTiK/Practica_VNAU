namespace NP9._7F
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            calculateButton = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Ширана. см";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Висота , см";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(205, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Підвіконня";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(205, 43);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Доставка";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(205, 68);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(103, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Встановлення";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(449, 26);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(146, 51);
            calculateButton.TabIndex = 7;
            calculateButton.Text = "РОЗРАХУНОК";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 163);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "До сплати";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(434, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(404, 94);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 226);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(calculateButton);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button calculateButton;
        private Label label3;
        private TextBox textBox3;
        private ListBox listBox1;
    }
}
