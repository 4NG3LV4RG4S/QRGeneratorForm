﻿namespace QRGeneratorForms
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(cmbx_Errorlvl);
            Name = "Form1";
            Text = "QR Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbx_Errorlvl;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}