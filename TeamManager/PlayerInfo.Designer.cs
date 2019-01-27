namespace TeamManager
{
    partial class PlayerInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerPosition = new System.Windows.Forms.TextBox();
            this.playerNumber = new System.Windows.Forms.TextBox();
            this.playerSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerPosition
            // 
            this.playerPosition.Location = new System.Drawing.Point(28, 3);
            this.playerPosition.Name = "playerPosition";
            this.playerPosition.ReadOnly = true;
            this.playerPosition.Size = new System.Drawing.Size(100, 20);
            this.playerPosition.TabIndex = 0;
            // 
            // playerNumber
            // 
            this.playerNumber.Location = new System.Drawing.Point(173, 3);
            this.playerNumber.Name = "playerNumber";
            this.playerNumber.Size = new System.Drawing.Size(116, 20);
            this.playerNumber.TabIndex = 1;
            // 
            // playerSurname
            // 
            this.playerSurname.Location = new System.Drawing.Point(332, 3);
            this.playerSurname.Name = "playerSurname";
            this.playerSurname.Size = new System.Drawing.Size(100, 20);
            this.playerSurname.TabIndex = 2;
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.playerSurname);
            this.Controls.Add(this.playerNumber);
            this.Controls.Add(this.playerPosition);
            this.Name = "PlayerInfo";
            this.Size = new System.Drawing.Size(466, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playerPosition;
        private System.Windows.Forms.TextBox playerNumber;
        private System.Windows.Forms.TextBox playerSurname;
    }
}
