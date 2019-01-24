namespace TeamManager
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
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.playerInfo11 = new TeamManager.PlayerInfo();
            this.playerInfo10 = new TeamManager.PlayerInfo();
            this.playerInfo9 = new TeamManager.PlayerInfo();
            this.playerInfo8 = new TeamManager.PlayerInfo();
            this.playerInfo7 = new TeamManager.PlayerInfo();
            this.playerInfo6 = new TeamManager.PlayerInfo();
            this.playerInfo5 = new TeamManager.PlayerInfo();
            this.playerInfo4 = new TeamManager.PlayerInfo();
            this.playerInfo3 = new TeamManager.PlayerInfo();
            this.playerInfo2 = new TeamManager.PlayerInfo();
            this.playerInfo1 = new TeamManager.PlayerInfo();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.Location = new System.Drawing.Point(42, 24);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(137, 30);
            this.labelCountry.TabIndex = 10;
            this.labelCountry.Text = "label1";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(252, 30);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCountry.TabIndex = 11;
            // 
            // playerInfo11
            // 
            this.playerInfo11.Location = new System.Drawing.Point(6, 598);
            this.playerInfo11.Name = "playerInfo11";
            this.playerInfo11.Size = new System.Drawing.Size(464, 52);
            this.playerInfo11.TabIndex = 9;
            // 
            // playerInfo10
            // 
            this.playerInfo10.Location = new System.Drawing.Point(6, 540);
            this.playerInfo10.Name = "playerInfo10";
            this.playerInfo10.Size = new System.Drawing.Size(464, 52);
            this.playerInfo10.TabIndex = 8;
            // 
            // playerInfo9
            // 
            this.playerInfo9.Location = new System.Drawing.Point(7, 482);
            this.playerInfo9.Name = "playerInfo9";
            this.playerInfo9.Size = new System.Drawing.Size(464, 52);
            this.playerInfo9.TabIndex = 7;
            // 
            // playerInfo8
            // 
            this.playerInfo8.Location = new System.Drawing.Point(6, 307);
            this.playerInfo8.Name = "playerInfo8";
            this.playerInfo8.Size = new System.Drawing.Size(464, 52);
            this.playerInfo8.TabIndex = 7;
            // 
            // playerInfo7
            // 
            this.playerInfo7.Location = new System.Drawing.Point(7, 424);
            this.playerInfo7.Name = "playerInfo7";
            this.playerInfo7.Size = new System.Drawing.Size(464, 52);
            this.playerInfo7.TabIndex = 6;
            // 
            // playerInfo6
            // 
            this.playerInfo6.Location = new System.Drawing.Point(7, 366);
            this.playerInfo6.Name = "playerInfo6";
            this.playerInfo6.Size = new System.Drawing.Size(464, 52);
            this.playerInfo6.TabIndex = 5;
            // 
            // playerInfo5
            // 
            this.playerInfo5.Location = new System.Drawing.Point(7, 308);
            this.playerInfo5.Name = "playerInfo5";
            this.playerInfo5.Size = new System.Drawing.Size(464, 52);
            this.playerInfo5.TabIndex = 4;
            // 
            // playerInfo4
            // 
            this.playerInfo4.Location = new System.Drawing.Point(7, 250);
            this.playerInfo4.Name = "playerInfo4";
            this.playerInfo4.Size = new System.Drawing.Size(464, 52);
            this.playerInfo4.TabIndex = 3;
            // 
            // playerInfo3
            // 
            this.playerInfo3.Location = new System.Drawing.Point(7, 192);
            this.playerInfo3.Name = "playerInfo3";
            this.playerInfo3.Size = new System.Drawing.Size(464, 52);
            this.playerInfo3.TabIndex = 2;
            this.playerInfo3.Load += new System.EventHandler(this.playerInfo3_Load);
            // 
            // playerInfo2
            // 
            this.playerInfo2.Location = new System.Drawing.Point(7, 134);
            this.playerInfo2.Name = "playerInfo2";
            this.playerInfo2.Size = new System.Drawing.Size(464, 52);
            this.playerInfo2.TabIndex = 1;
            // 
            // playerInfo1
            // 
            this.playerInfo1.Location = new System.Drawing.Point(7, 76);
            this.playerInfo1.Name = "playerInfo1";
            this.playerInfo1.Size = new System.Drawing.Size(464, 52);
            this.playerInfo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 666);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.playerInfo11);
            this.Controls.Add(this.playerInfo10);
            this.Controls.Add(this.playerInfo9);
            this.Controls.Add(this.playerInfo8);
            this.Controls.Add(this.playerInfo7);
            this.Controls.Add(this.playerInfo6);
            this.Controls.Add(this.playerInfo5);
            this.Controls.Add(this.playerInfo4);
            this.Controls.Add(this.playerInfo3);
            this.Controls.Add(this.playerInfo2);
            this.Controls.Add(this.playerInfo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerInfo playerInfo1;
        private PlayerInfo playerInfo2;
        private PlayerInfo playerInfo3;
        private PlayerInfo playerInfo4;
        private PlayerInfo playerInfo5;
        private PlayerInfo playerInfo6;
        private PlayerInfo playerInfo7;
        private PlayerInfo playerInfo8;
        private PlayerInfo playerInfo9;
        private PlayerInfo playerInfo10;
        private PlayerInfo playerInfo11;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxCountry;
    }
}

