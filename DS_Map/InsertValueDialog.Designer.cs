﻿namespace DSPRE
{
    partial class InsertValueDialog
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
            this.inputValUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputValUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.inputValUpDown.Hexadecimal = true;
            this.inputValUpDown.Location = new System.Drawing.Point(22, 31);
            this.inputValUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.inputValUpDown.Name = "numericUpDown1";
            this.inputValUpDown.Size = new System.Drawing.Size(197, 20);
            this.inputValUpDown.TabIndex = 1;
            this.inputValUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(22, 57);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(99, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(127, 57);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(92, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Discard";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // InsertValueDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 90);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.inputValUpDown);
            this.Controls.Add(this.label1);
            this.Name = "InsertValueDialog";
            this.Text = "Insert Value";
            ((System.ComponentModel.ISupportInitialize)(this.inputValUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown inputValUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button backButton;
    }
}