﻿namespace LBS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblCellID = new System.Windows.Forms.Label();
            this.mnuStart = new System.Windows.Forms.MenuItem();
            this.mnuStop = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnuStart);
            this.mainMenu1.MenuItems.Add(this.mnuStop);
            // 
            // lblCellID
            // 
            this.lblCellID.Location = new System.Drawing.Point(34, 116);
            this.lblCellID.Name = "lblCellID";
            this.lblCellID.Size = new System.Drawing.Size(178, 40);
            this.lblCellID.Text = "label1";
            // 
            // mnuStart
            // 
            this.mnuStart.Text = "START";
            // 
            // mnuStop
            // 
            this.mnuStop.Text = "STOP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblCellID);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCellID;
        private System.Windows.Forms.MenuItem mnuStart;
        private System.Windows.Forms.MenuItem mnuStop;
    }
}

