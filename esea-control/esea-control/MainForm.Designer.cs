namespace esea_control
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.infoTitle = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.mainButton = new System.Windows.Forms.Button();
            this.moreButton = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::esea_control.Properties.Resources.icons8_warning_shield_96;
            this.pictureBox.Location = new System.Drawing.Point(99, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(96, 96);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // infoTitle
            // 
            this.infoTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTitle.Location = new System.Drawing.Point(12, 111);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(269, 23);
            this.infoTitle.TabIndex = 1;
            this.infoTitle.Text = "ESEA anticheat is running!";
            this.infoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(12, 134);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(269, 88);
            this.infoText.TabIndex = 2;
            this.infoText.Text = "One or more services have been found running in the system. You can disable them " +
    "bellow.";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(99, 225);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(96, 23);
            this.mainButton.TabIndex = 3;
            this.mainButton.Text = "Disable";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // moreButton
            // 
            this.moreButton.ActiveLinkColor = System.Drawing.Color.Black;
            this.moreButton.AutoSize = true;
            this.moreButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moreButton.Location = new System.Drawing.Point(131, 257);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(31, 13);
            this.moreButton.TabIndex = 4;
            this.moreButton.TabStop = true;
            this.moreButton.Text = "More";
            this.moreButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moreButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moreButton_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.infoTitle);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESEA Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label infoTitle;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.LinkLabel moreButton;
    }
}

