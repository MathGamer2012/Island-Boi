namespace Island_Boi.Forms
{
    partial class frmBookReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookReturn));
            this.panelBackHold = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelBackHold.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackHold
            // 
            this.panelBackHold.AutoScroll = true;
            this.panelBackHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackHold.Controls.Add(this.lblInstruction);
            this.panelBackHold.Controls.Add(this.lblInfo);
            this.panelBackHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackHold.Location = new System.Drawing.Point(0, 0);
            this.panelBackHold.Name = "panelBackHold";
            this.panelBackHold.Size = new System.Drawing.Size(800, 450);
            this.panelBackHold.TabIndex = 0;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(36, 19);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(101, 20);
            this.lblInstruction.TabIndex = 13;
            this.lblInstruction.Text = "Instructions:";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(37, 42);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(749, 54);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // frmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackHold);
            this.Name = "frmBookReturn";
            this.Text = "BOOK RETURN";
            this.panelBackHold.ResumeLayout(false);
            this.panelBackHold.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackHold;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblInfo;
    }
}