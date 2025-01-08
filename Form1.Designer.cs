namespace QRGeneratorForms
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
            cmbx_Errorlvl = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbx_Errorlvl
            // 
            cmbx_Errorlvl.FormattingEnabled = true;
            cmbx_Errorlvl.Location = new Point(12, 80);
            cmbx_Errorlvl.Name = "cmbx_Errorlvl";
            cmbx_Errorlvl.Size = new Size(232, 23);
            cmbx_Errorlvl.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 2;
            label1.Text = "Nivel de correccion de error:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "Url:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Tamaño del QR:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 133);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(34, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(71, 133);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(34, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 136);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 7;
            label4.Text = "x";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(421, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 437);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 408);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 180);
            button1.Name = "button1";
            button1.Size = new Size(76, 40);
            button1.TabIndex = 9;
            button1.Text = "Selecciona un color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 548);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(cmbx_Errorlvl);
            Name = "Form1";
            Text = "QR Generator";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbx_Errorlvl;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
