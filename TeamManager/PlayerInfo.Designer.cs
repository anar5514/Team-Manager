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
            this.playerPosition.BackColor = System.Drawing.Color.SeaGreen;
            this.playerPosition.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerPosition.Location = new System.Drawing.Point(28, 3);
            this.playerPosition.Name = "playerPosition";
            this.playerPosition.ReadOnly = true;
            this.playerPosition.Size = new System.Drawing.Size(100, 22);
            this.playerPosition.TabIndex = 0;
            // 
            // playerNumber
            // 
            this.playerNumber.BackColor = System.Drawing.Color.SeaGreen;
            this.playerNumber.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerNumber.Location = new System.Drawing.Point(173, 3);
            this.playerNumber.Name = "playerNumber";
            this.playerNumber.Size = new System.Drawing.Size(116, 22);
            this.playerNumber.TabIndex = 1;
            this.playerNumber.TextChanged += new System.EventHandler(this.playerNumber_TextChanged);
            // 
            // playerSurname
            // 
            this.playerSurname.BackColor = System.Drawing.Color.SeaGreen;
            this.playerSurname.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSurname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerSurname.Location = new System.Drawing.Point(332, 3);
            this.playerSurname.Name = "playerSurname";
            this.playerSurname.Size = new System.Drawing.Size(100, 22);
            this.playerSurname.TabIndex = 2;
            this.playerSurname.TextChanged += new System.EventHandler(this.playerSurname_TextChanged);
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.playerSurname);
            this.Controls.Add(this.playerNumber);
            this.Controls.Add(this.playerPosition);
            this.Name = "PlayerInfo";
            this.Size = new System.Drawing.Size(468, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playerPosition;
        private System.Windows.Forms.TextBox playerNumber;
        private System.Windows.Forms.TextBox playerSurname;
    }
}
