namespace Island_Boi.Forms
{
    partial class frmBookDonate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookDonate));
            this.panelBackDonate = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCheckDisplayV2 = new System.Windows.Forms.Button();
            this.btnCheckDisplay = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.comboBoxWebCam = new System.Windows.Forms.ComboBox();
            this.pictureBox_Camera = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_Cover = new System.Windows.Forms.PictureBox();
            this.panelBackDonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackDonate
            // 
            this.panelBackDonate.AutoScroll = true;
            this.panelBackDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackDonate.Controls.Add(this.pictureBox_Cover);
            this.panelBackDonate.Controls.Add(this.label5);
            this.panelBackDonate.Controls.Add(this.lblQuantity);
            this.panelBackDonate.Controls.Add(this.lblRating);
            this.panelBackDonate.Controls.Add(this.lblPublisher);
            this.panelBackDonate.Controls.Add(this.lblPublished);
            this.panelBackDonate.Controls.Add(this.lblAuthor);
            this.panelBackDonate.Controls.Add(this.label54);
            this.panelBackDonate.Controls.Add(this.lblTitle);
            this.panelBackDonate.Controls.Add(this.label4);
            this.panelBackDonate.Controls.Add(this.label3);
            this.panelBackDonate.Controls.Add(this.label2);
            this.panelBackDonate.Controls.Add(this.label1);
            this.panelBackDonate.Controls.Add(this.panel2);
            this.panelBackDonate.Controls.Add(this.lblInstruction);
            this.panelBackDonate.Controls.Add(this.lblInfo);
            this.panelBackDonate.Controls.Add(this.btnCheckDisplayV2);
            this.panelBackDonate.Controls.Add(this.btnCheckDisplay);
            this.panelBackDonate.Controls.Add(this.txtISBN);
            this.panelBackDonate.Controls.Add(this.lblISBN);
            this.panelBackDonate.Controls.Add(this.panel1);
            this.panelBackDonate.Controls.Add(this.lblDisplay);
            this.panelBackDonate.Controls.Add(this.txtDisplay);
            this.panelBackDonate.Controls.Add(this.lblCamera);
            this.panelBackDonate.Controls.Add(this.comboBoxWebCam);
            this.panelBackDonate.Controls.Add(this.pictureBox_Camera);
            this.panelBackDonate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackDonate.Location = new System.Drawing.Point(0, 0);
            this.panelBackDonate.Name = "panelBackDonate";
            this.panelBackDonate.Size = new System.Drawing.Size(800, 450);
            this.panelBackDonate.TabIndex = 0;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(26, 19);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(101, 20);
            this.lblInstruction.TabIndex = 11;
            this.lblInstruction.Text = "Instructions:";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(27, 42);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(749, 54);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnCheckDisplayV2
            // 
            this.btnCheckDisplayV2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckDisplayV2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCheckDisplayV2.FlatAppearance.BorderSize = 0;
            this.btnCheckDisplayV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDisplayV2.Image = global::Island_Boi.Properties.Resources.sendv2;
            this.btnCheckDisplayV2.Location = new System.Drawing.Point(713, 237);
            this.btnCheckDisplayV2.Name = "btnCheckDisplayV2";
            this.btnCheckDisplayV2.Size = new System.Drawing.Size(29, 20);
            this.btnCheckDisplayV2.TabIndex = 9;
            this.btnCheckDisplayV2.UseVisualStyleBackColor = false;
            // 
            // btnCheckDisplay
            // 
            this.btnCheckDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCheckDisplay.FlatAppearance.BorderSize = 0;
            this.btnCheckDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDisplay.Image = global::Island_Boi.Properties.Resources.sendv2;
            this.btnCheckDisplay.Location = new System.Drawing.Point(344, 395);
            this.btnCheckDisplay.Name = "btnCheckDisplay";
            this.btnCheckDisplay.Size = new System.Drawing.Size(29, 20);
            this.btnCheckDisplay.TabIndex = 8;
            this.btnCheckDisplay.UseVisualStyleBackColor = false;
            this.btnCheckDisplay.Click += new System.EventHandler(this.btnCheckDisplay_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtISBN.ForeColor = System.Drawing.Color.White;
            this.txtISBN.Location = new System.Drawing.Point(456, 237);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(251, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(538, 205);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(98, 20);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "Enter ISBN:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Location = new System.Drawing.Point(413, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 336);
            this.panel1.TabIndex = 5;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(26, 395);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(70, 20);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "Display:";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtDisplay.ForeColor = System.Drawing.Color.White;
            this.txtDisplay.Location = new System.Drawing.Point(105, 395);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(233, 20);
            this.txtDisplay.TabIndex = 3;
            // 
            // lblCamera
            // 
            this.lblCamera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.ForeColor = System.Drawing.Color.White;
            this.lblCamera.Location = new System.Drawing.Point(26, 100);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(73, 20);
            this.lblCamera.TabIndex = 2;
            this.lblCamera.Text = "Camera:";
            // 
            // comboBoxWebCam
            // 
            this.comboBoxWebCam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxWebCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboBoxWebCam.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxWebCam.FormattingEnabled = true;
            this.comboBoxWebCam.Location = new System.Drawing.Point(105, 102);
            this.comboBoxWebCam.Name = "comboBoxWebCam";
            this.comboBoxWebCam.Size = new System.Drawing.Size(269, 21);
            this.comboBoxWebCam.TabIndex = 1;
            // 
            // pictureBox_Camera
            // 
            this.pictureBox_Camera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_Camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pictureBox_Camera.Location = new System.Drawing.Point(30, 133);
            this.pictureBox_Camera.Name = "pictureBox_Camera";
            this.pictureBox_Camera.Size = new System.Drawing.Size(344, 251);
            this.pictureBox_Camera.TabIndex = 0;
            this.pictureBox_Camera.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Location = new System.Drawing.Point(27, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 10);
            this.panel2.TabIndex = 22;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(273, 684);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 13);
            this.lblQuantity.TabIndex = 184;
            // 
            // lblRating
            // 
            this.lblRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRating.AutoSize = true;
            this.lblRating.ForeColor = System.Drawing.Color.White;
            this.lblRating.Location = new System.Drawing.Point(263, 583);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 13);
            this.lblRating.TabIndex = 183;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.ForeColor = System.Drawing.Color.White;
            this.lblPublisher.Location = new System.Drawing.Point(66, 726);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(0, 13);
            this.lblPublisher.TabIndex = 182;
            // 
            // lblPublished
            // 
            this.lblPublished.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPublished.AutoSize = true;
            this.lblPublished.ForeColor = System.Drawing.Color.White;
            this.lblPublished.Location = new System.Drawing.Point(73, 631);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(0, 13);
            this.lblPublished.TabIndex = 181;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(67, 545);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(0, 13);
            this.lblAuthor.TabIndex = 180;
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(246, 652);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(76, 20);
            this.label54.TabIndex = 179;
            this.label54.Text = "Quantity:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(99, 469);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 29);
            this.lblTitle.TabIndex = 178;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 177;
            this.label4.Text = "Rating:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 696);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 176;
            this.label3.Text = "Publisher:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 175;
            this.label2.Text = "Published:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 174;
            this.label1.Text = "Author:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 185;
            this.label5.Text = "Title:";
            // 
            // pictureBox_Cover
            // 
            this.pictureBox_Cover.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_Cover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pictureBox_Cover.Location = new System.Drawing.Point(423, 469);
            this.pictureBox_Cover.Name = "pictureBox_Cover";
            this.pictureBox_Cover.Size = new System.Drawing.Size(305, 336);
            this.pictureBox_Cover.TabIndex = 200;
            this.pictureBox_Cover.TabStop = false;
            // 
            // frmBookDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackDonate);
            this.Name = "frmBookDonate";
            this.Text = "BOOK DONATE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookDonate_FormClosing);
            this.Load += new System.EventHandler(this.frmBookDonate_Load);
            this.panelBackDonate.ResumeLayout(false);
            this.panelBackDonate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackDonate;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox comboBoxWebCam;
        private System.Windows.Forms.PictureBox pictureBox_Camera;
        private System.Windows.Forms.Button btnCheckDisplay;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnCheckDisplayV2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPublished;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Cover;
    }
}