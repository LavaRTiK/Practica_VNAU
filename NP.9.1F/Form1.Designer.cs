namespace NP._9._1F
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            name = new ErrorProvider(components);
            old = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)old).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 2;
            label2.Text = "Вік";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(86, 91);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "чол.";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(157, 91);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "жін.";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "Стать";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(280, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(483, 169);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Cursor = Cursors.SizeAll;
            button1.Location = new Point(47, 143);
            button1.Name = "button1";
            button1.Size = new Size(139, 38);
            button1.TabIndex = 8;
            button1.Text = "Добавити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.ContainerControl = this;
            // 
            // old
            // 
            old.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 221);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ListBox";
            ((System.ComponentModel.ISupportInitialize)name).EndInit();
            ((System.ComponentModel.ISupportInitialize)old).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private ListBox listBox1;
        private Button button1;
        private ErrorProvider name;
        private ErrorProvider old;
    }
}
