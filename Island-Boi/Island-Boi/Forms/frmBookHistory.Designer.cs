namespace Island_Boi.Forms
{
    partial class frmBookHistory
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
            this.panelBackHistory = new System.Windows.Forms.Panel();
            this.lblHistory = new System.Windows.Forms.Label();
            this.panelBackHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackHistory
            // 
            this.panelBackHistory.AutoScroll = true;
            this.panelBackHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackHistory.Controls.Add(this.lblHistory);
            this.panelBackHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackHistory.Location = new System.Drawing.Point(0, 0);
            this.panelBackHistory.Name = "panelBackHistory";
            this.panelBackHistory.Size = new System.Drawing.Size(800, 450);
            this.panelBackHistory.TabIndex = 0;
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.White;
            this.lblHistory.Location = new System.Drawing.Point(45, 31);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(68, 20);
            this.lblHistory.TabIndex = 14;
            this.lblHistory.Text = "History:";
            // 
            // frmBookHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackHistory);
            this.Name = "frmBookHistory";
            this.Text = "BOOK HISTORY";
            this.panelBackHistory.ResumeLayout(false);
            this.panelBackHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackHistory;
        private System.Windows.Forms.Label lblHistory;
    }
}