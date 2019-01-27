namespace TeamManager
{
    partial class Player
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
            this.number = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.Red;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(21, 31);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(22, 21);
            this.number.TabIndex = 2;
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.Red;
            this.surname.Location = new System.Drawing.Point(-1, 57);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(63, 13);
            this.surname.TabIndex = 3;
            this.surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamManager.Properties.Resources.player4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.surname);
            this.Controls.Add(this.number);
            this.DoubleBuffered = true;
            this.Name = "Player";
            this.Size = new System.Drawing.Size(61, 70);
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label surname;
    }
}
