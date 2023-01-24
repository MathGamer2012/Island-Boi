namespace Island_Boi.Forms
{
    partial class frmBookReview
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
            this.panelBackReview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBackReview
            // 
            this.panelBackReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackReview.Location = new System.Drawing.Point(0, 0);
            this.panelBackReview.Name = "panelBackReview";
            this.panelBackReview.Size = new System.Drawing.Size(800, 450);
            this.panelBackReview.TabIndex = 0;
            // 
            // frmBookReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackReview);
            this.Name = "frmBookReview";
            this.Text = "BOOK REVIEW";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackReview;
    }
}