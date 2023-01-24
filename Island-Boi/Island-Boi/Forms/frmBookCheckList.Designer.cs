namespace Island_Boi.Forms
{
    partial class frmBookCheckList
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
            this.panelBackCheck = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBackCheck
            // 
            this.panelBackCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackCheck.Location = new System.Drawing.Point(0, 0);
            this.panelBackCheck.Name = "panelBackCheck";
            this.panelBackCheck.Size = new System.Drawing.Size(800, 450);
            this.panelBackCheck.TabIndex = 1;
            // 
            // frmBookCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackCheck);
            this.Name = "frmBookCheckList";
            this.Text = "BOOK CHECKOUT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackCheck;
    }
}