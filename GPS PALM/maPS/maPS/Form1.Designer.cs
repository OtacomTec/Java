namespace maPS
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
            this.lstCellIDs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadCellIds = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lstCellIDs
            // 
            this.lstCellIDs.FormattingEnabled = true;
            this.lstCellIDs.Location = new System.Drawing.Point(12, 44);
            this.lstCellIDs.Name = "lstCellIDs";
            this.lstCellIDs.Size = new System.Drawing.Size(227, 550);
            this.lstCellIDs.TabIndex = 0;
            this.lstCellIDs.SelectedIndexChanged += new System.EventHandler(this.lstCellIDs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cell Id\'s";
            // 
            // btnLoadCellIds
            // 
            this.btnLoadCellIds.Location = new System.Drawing.Point(12, 600);
            this.btnLoadCellIds.Name = "btnLoadCellIds";
            this.btnLoadCellIds.Size = new System.Drawing.Size(227, 33);
            this.btnLoadCellIds.TabIndex = 2;
            this.btnLoadCellIds.Text = "Load Cell Ids";
            this.btnLoadCellIds.UseVisualStyleBackColor = true;
            this.btnLoadCellIds.Click += new System.EventHandler(this.btnLoadCellIDs_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(245, 44);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(984, 734);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 785);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnLoadCellIds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCellIDs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCellIDs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadCellIds;
        private System.Windows.Forms.WebBrowser webBrowser1;


    }
}

