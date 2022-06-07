namespace EncoderDecoder
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alphaEnRadioButton = new System.Windows.Forms.RadioButton();
            this.alphaRuRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите алфавит";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите функцию";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.alphaEnRadioButton);
            this.panel1.Controls.Add(this.alphaRuRadioButton);
            this.panel1.Location = new System.Drawing.Point(248, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 75);
            this.panel1.TabIndex = 7;
            // 
            // alphaEnRadioButton
            // 
            this.alphaEnRadioButton.AutoSize = true;
            this.alphaEnRadioButton.Location = new System.Drawing.Point(11, 44);
            this.alphaEnRadioButton.Name = "alphaEnRadioButton";
            this.alphaEnRadioButton.Size = new System.Drawing.Size(78, 19);
            this.alphaEnRadioButton.TabIndex = 1;
            this.alphaEnRadioButton.TabStop = true;
            this.alphaEnRadioButton.Text = "Латиница";
            this.alphaEnRadioButton.UseVisualStyleBackColor = true;
            // 
            // alphaRuRadioButton
            // 
            this.alphaRuRadioButton.AutoSize = true;
            this.alphaRuRadioButton.Location = new System.Drawing.Point(12, 11);
            this.alphaRuRadioButton.Name = "alphaRuRadioButton";
            this.alphaRuRadioButton.Size = new System.Drawing.Size(87, 19);
            this.alphaRuRadioButton.TabIndex = 0;
            this.alphaRuRadioButton.TabStop = true;
            this.alphaRuRadioButton.Text = "Кириллица";
            this.alphaRuRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.decryptRadioButton);
            this.panel2.Controls.Add(this.encryptRadioButton);
            this.panel2.Location = new System.Drawing.Point(376, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 74);
            this.panel2.TabIndex = 8;
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Location = new System.Drawing.Point(15, 43);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(112, 19);
            this.decryptRadioButton.TabIndex = 1;
            this.decryptRadioButton.TabStop = true;
            this.decryptRadioButton.Text = "Дешифрование";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Location = new System.Drawing.Point(15, 10);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(98, 19);
            this.encryptRadioButton.TabIndex = 0;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Шифрование";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton alphaRuRadioButton;
        private System.Windows.Forms.RadioButton alphaEnRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.Button button1;
    }
}