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
            this.SuspendLayout();
            // 
            // panelBackHistory
            // 
            this.panelBackHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackHistory.Location = new System.Drawing.Point(0, 0);
            this.panelBackHistory.Name = "panelBackHistory";
            this.panelBackHistory.Size = new System.Drawing.Size(800, 450);
            this.panelBackHistory.TabIndex = 0;
            // 
            // frmBookHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackHistory);
            this.Name = "frmBookHistory";
            this.Text = "BOOK HISTORY";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackHistory;
    }
}