﻿namespace Pig_Latin
{
    partial class Form1
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(262, 57);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(233, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter a string of letters and spaces.";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(121, 117);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(519, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(317, 197);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(122, 53);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 332);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Pig Latin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

