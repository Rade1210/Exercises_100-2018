﻿namespace Exercises_100_2018
{
    partial class PullDataFromDatabase
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
            this.listboxPrintData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listboxPrintData
            // 
            this.listboxPrintData.FormattingEnabled = true;
            this.listboxPrintData.Location = new System.Drawing.Point(31, 48);
            this.listboxPrintData.Name = "listboxPrintData";
            this.listboxPrintData.Size = new System.Drawing.Size(432, 212);
            this.listboxPrintData.TabIndex = 0;
            // 
            // PullDataFromDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 359);
            this.Controls.Add(this.listboxPrintData);
            this.Name = "PullDataFromDatabase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PullDataFromDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxPrintData;
    }
}

