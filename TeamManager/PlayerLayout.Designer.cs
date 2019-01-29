namespace TeamManager
{
    partial class PlayerLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerLayout));
            this.flagSelectedCountry = new System.Windows.Forms.PictureBox();
            this.labelCountryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flagSelectedCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // flagSelectedCountry
            // 
            this.flagSelectedCountry.Location = new System.Drawing.Point(1, -2);
            this.flagSelectedCountry.Name = "flagSelectedCountry";
            this.flagSelectedCountry.Size = new System.Drawing.Size(63, 42);
            this.flagSelectedCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.flagSelectedCountry.TabIndex = 0;
            this.flagSelectedCountry.TabStop = false;
            // 
            // labelCountryName
            // 
            this.labelCountryName.BackColor = System.Drawing.Color.ForestGreen;
            this.labelCountryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountryName.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryName.Location = new System.Drawing.Point(364, -2);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(125, 35);
            this.labelCountryName.TabIndex = 2;
            // 
            // PlayerLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 574);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.flagSelectedCountry);
            this.DoubleBuffered = true;
            this.Name = "PlayerLayout";
            this.Text = "PlayerLayout";
            this.Load += new System.EventHandler(this.PlayerLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flagSelectedCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Player[] players;
        private System.Windows.Forms.PictureBox flagSelectedCountry;
        private System.Windows.Forms.Label labelCountryName;
    }
}