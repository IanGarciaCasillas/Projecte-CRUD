﻿namespace Projecte_CRUD
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
            this.lstPersones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPersones
            // 
            this.lstPersones.FormattingEnabled = true;
            this.lstPersones.ItemHeight = 15;
            this.lstPersones.Location = new System.Drawing.Point(1, 3);
            this.lstPersones.Name = "lstPersones";
            this.lstPersones.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPersones.Size = new System.Drawing.Size(530, 409);
            this.lstPersones.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPersones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lstPersones;
    }
}