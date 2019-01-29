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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.number = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(71)))), ((int)(((byte)(188)))));
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(23, 32);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(14, 17);
            this.number.TabIndex = 2;
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            this.surname.Location = new System.Drawing.Point(-1, 57);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(64, 15);
            this.surname.TabIndex = 3;
            this.surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.surname);
            this.Controls.Add(this.number);
            this.DoubleBuffered = true;
            this.Name = "Player";
            this.Size = new System.Drawing.Size(63, 72);
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label surname;
    }
}
